using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreBæltsBroencar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace StoreBæltsBroencar.Tests;

[TestClass()]
public class StoreBæltsBroenTests
{
	[TestMethod]
	public void Price_WeekendWithoutBrobizz_ReturnsWeekendDiscount()
	{
		// Arrange: Søndag uden Brobizz
		var car = new StoreBæltsBroenCar("CAR123", new DateTime(2025, 10, 5), brobizz: false);

		// Act
		double actualPrice = car.Price();

		// Assert: Kun weekendrabat skal gælde
		double expectedPrice = 230.0 * 0.85;
		Assert.AreEqual(expectedPrice, actualPrice, 0.01, "Weekend discount should apply without Brobizz.");
	}

	[TestMethod]
	public void Price_WeekdayWithBrobizz_ReturnsBrobizzDiscount()
	{
		// Arrange: Tirsdag med Brobizz
		var car = new StoreBæltsBroenCar("CAR123", new DateTime(2025, 9, 30), brobizz: true);

		// Act
		double actualPrice = car.Price();

		// Assert: Kun Brobizz-rabat skal gælde
		double expectedPrice = 230.0 * 0.95;
		Assert.AreEqual(expectedPrice, actualPrice, 0.01, "Brobizz discount should apply on weekdays.");
	}

}


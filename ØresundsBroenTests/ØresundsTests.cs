using Microsoft.VisualStudio.TestTools.UnitTesting;
using ØresundsBroen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BridgeTicket;
namespace ØresundsBroen.Tests;

[TestClass()]
public class ØresundsTests
{
	[TestMethod]
	public void Price_WithoutBrobizz_ReturnsFullPrice()
	{
		// Arrange: Bil uden Brobizz
		var car = new ØresundsCar("CAR123", new DateTime(2025, 9, 30), brobizz: false);

		// Act
		double actualPrice = car.Price();

		// Assert
		Assert.AreEqual(430.0, actualPrice, 0.01, "Price should be 430 kr without Brobizz.");
	}

	[TestMethod]
	public void Price_WithBrobizz_ReturnsDiscountedPrice()
	{
		// Arrange: Bil med Brobizz
		var car = new ØresundsCar("CAR123", new DateTime(2025, 9, 30), brobizz: true);

		// Act
		double actualPrice = car.Price();

		// Assert
		Assert.AreEqual(178.0, actualPrice, 0.01, "Price should be 178 kr with Brobizz.");
	}

	[TestMethod]
	public void VehicleType_ReturnsOresundsCar()
	{
		// Arrange
		var car = new ØresundsCar("CAR123", DateTime.Now);

		// Act
		string type = car.VehicleType();

		// Assert
		Assert.AreEqual("Øresunds Car", type, "VehicleType should return 'Øresunds Car'.");
	}

	[TestClass]
	public class OresundsMCTests
	{
		[TestMethod]
		public void Price_WithoutBrobizz_ReturnsFullPrice()
		{
			// Arrange: MC uden Brobizz
			var mc = new ØresundsMC("MC123", new DateTime(2025, 9, 30), brobizz: false);

			// Act
			double actualPrice = mc.Price();

			// Assert
			Assert.AreEqual(235.0, actualPrice, 0.01, "Price should be 235 kr without Brobizz.");
		}

		[TestMethod]
		public void Price_WithBrobizz_ReturnsDiscountedPrice()
		{
			// Arrange: MC med Brobizz
			var mc = new ØresundsMC("MC123", new DateTime(2025, 9, 30), brobizz: true);

			// Act
			double actualPrice = mc.Price();

			// Assert
			Assert.AreEqual(92.0, actualPrice, 0.01, "Price should be 92 kr with Brobizz.");
		}

		[TestMethod]
		public void VehicleType_ReturnsOresundsMC()
		{
			// Arrange
			var mc = new ØresundsMC("MC123", DateTime.Now);

			// Act
			string type = mc.VehicleType();

			// Assert
			Assert.AreEqual("Øresunds MC", type, "VehicleType should return 'Øresunds MC'.");
		}
	}

}
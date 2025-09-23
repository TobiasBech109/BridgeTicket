using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BridgeTicket;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace BridgeTicketTests;


[TestClass()]
public class CarTests
{

	// Tester at Price returnerer den korrekte faste pris
	[TestMethod]
	public void Price_ReturnsFixedValue()
	{
		// Arrange: Opretter en bil
		var car = new Car();

		// Act: Kalder Price()
		double price = car.Price();

		// Assert: Tjekker at prisen er 230
		Assert.AreEqual(230.0, price);
	}

	// Tester at VehicleType returnerer "Car"
	[TestMethod]
	public void VehicleType_ReturnCarValue()
	{

		// Arrange: Opretter en bil
		var car = new Car();

		// Act: Kalder VehicleType()
		string type = car.VehicleType();

		// Assert: Tjekker at typen er "Car"
		Assert.AreEqual("Car", type);
	}

}
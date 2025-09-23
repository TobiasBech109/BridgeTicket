using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BridgeTicket;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace BridgeTicketTests;


[TestClass()]
public class VehicleTests
{

	// Tester at Price returnerer den korrekte faste pris
	[TestMethod]
	public void Price_ReturnsFixedCarValue()
	{
		// Arrange: Opretter en bil
		var car = new Car("DE12132", new DateTime(2025, 9, 23));

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
		var car = new Car("DE12132", new DateTime(2025, 9, 23));

		// Act: Kalder VehicleType()
		string type = car.VehicleType();

		// Assert: Tjekker at typen er "Car"
		Assert.AreEqual("Car", type);
	}

	// Tester at Price returnerer den korrekte faste pris
	[TestMethod]
	public void Price_ReturnsFixedMCValue()
	{
		// Arrange: Opretter en MC
		var mc = new MC("DE12132", new DateTime(2025, 9, 23));

		// Act: Kalder Price()
		double price = mc.Price();

		// Assert: Tjekker at prisen er 125
		Assert.AreEqual(125.0, price);
	}

	// Tester at VehicleType returnerer "MC"
	[TestMethod]
	public void VehicleType_ReturnMCValue()
	{

		// Arrange: Opretter en MC
		var mc = new MC("DE12132", new DateTime(2025, 9, 23));

		// Act: Kalder VehicleType()
		string type = mc.VehicleType();

		// Assert: Tjekker at typen er "MC"
		Assert.AreEqual("MC", type);
	}// Tester at VehicleType returnerer "MC"


	// Tester at en for lang nummerplade kaster en ArgumentException
	[TestMethod]
	public void LicensePlate_TooLong_ThrowsArgumentException()
	{
		// Arrange & Act & Assert: Opretter en bil med en for lang nummerplade og tjekker at det kaster en ArgumentException
		Assert.ThrowsException<ArgumentException>(() => new Car("TOOLONG123", DateTime.Now));
	}

	[DataRow("TOOLONG123")]
	[DataRow("123456789")]
	[DataRow("LONGPLATE1")]
	[TestMethod]
	public void LicensePlate_TooLong_ThrowsArgumentException2()
	{
		// Arrange 
		Exception exception = null;

		// Act
		try
		{
			var car = new Car(Licenseplate, DateTime.Now);
		}
		catch (Exception ex)
		{
			exception = ex;
		}

		// Assert
		Assert.IsNotNull(exception);
	}

}
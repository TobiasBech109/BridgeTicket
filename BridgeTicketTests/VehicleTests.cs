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
		Assert.AreEqual(120.0, price);
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
	public void LicensePlate_TooLong_ThrowsArgumentException2(string licensePlate)
	{
		// Arrange initialiserer variabler
		Exception exception = null;

		// Act og Assert: Prøver at oprette en bil med en for lang nummerplade og fanger exceptionen
		try
		{
			var car = new Car(licensePlate, DateTime.Now);
		}
		catch (Exception ex)
		{
			exception = ex;
		}

		// Assert tjekker at der er kastet en exception
		Assert.IsNotNull(exception);
	}

	[TestMethod]
	public void CarPrice_WithBrobizz_ShouldApplyDiscount()
		{
		// Arrange opretter en bil med Brobizz
		var car = new Car("AB12345", DateTime.Now, brobizz: true);
		double expectedPrice = 230 * 0.9;

		// Act henter prisen fra objektet
		double actualPrice = car.Price();

		// Assert tjekker at prisen er rabatteret
		Assert.AreEqual(expectedPrice, actualPrice, 0.01, "Price should be discounted by 10% when Brobizz is used.");
		}


	[TestMethod]
	public void MCPrice_WithBrobizz_ShouldApplyDiscount()
	{
		// Arrange: Opretter en MC med Brobizz aktiveret
		var mc = new MC("MC12345", DateTime.Now, brobizz: true);
		double expectedPrice = 120 * 0.9;

		// Act: Henter prisen fra objektet
		double actualPrice = mc.Price();

		// Assert: Tjekker at prisen er rabatteret
		Assert.AreEqual(expectedPrice, actualPrice, 0.01, "Price should be discounted by 10% when Brobizz is used.");
	}



	[TestMethod]
	public void CarPrice_WithoutBrobizz_ShouldReturnFullPrice()
	{
		// Arrange: Opretter en bil uden Brobizz
		var car = new Car("AB12345", DateTime.Now, brobizz: false);
		double expectedPrice = 230;

		// Act henter prisen fra objektet
		double actualPrice = car.Price();

		// Assert tjekker at prisen er fuld
		Assert.AreEqual(expectedPrice, actualPrice, 0.01, "Price should be full when Brobizz is not used.");
	}



}
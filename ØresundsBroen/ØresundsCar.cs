using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BridgeTicket;
namespace ØresundsBroen;

public class ØresundsCar : Vehicle
{

	/// <summary>
	/// Denne her constructor bruger vi til at initialisere vores properties
	/// </summary>
	public ØresundsCar(string licenseplate, DateTime date, bool brobizz = false)
		: base(licenseplate, date, brobizz)
	{
	}

	/// <summary>
	/// Bruger vi for at sikre at prisen vil være fast
	/// </summary>
	/// <returns></returns>

	public override double Price()
	{
		double price = 430.0;

		return Brobizz ? price = 178 : price;

	}


	/// <summary>
	/// Bruger vi senere til at override med noget polymorfi
	/// </summary>
	/// <returns></returns>
	public override string VehicleType()
	{
		return "Øresunds Car";
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BridgeTicket;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace StoreBæltsBroenMC;



public class StoreBæltsBroenMC : Vehicle
{
	/// <summary>
	/// Denne her constructor bruger vi til at initialisere vores properties
	/// </summary>
	public StoreBæltsBroenMC(string licenseplate, DateTime date, bool brobizz = false)
		: base(licenseplate, date, brobizz)
	{
	}

	/// <summary>
	/// Bruger vi for at sikre at prisen vil være fast, med mindre Brobizz er brugt eller det er weekend
	/// </summary>
	/// <returns>Den beregnede pris</returns>
	public override double Price()
	{
		double price = 230.0;

		// Brobizz-rabat: 5%
		if (Brobizz)
		{
			price *= 0.95;
		}

		return price;
	}


	/// <summary>
	/// Bruger vi senere til at override med noget polymorfi
	/// </summary>
	/// <returns></returns>
	public override string VehicleType()
	{
		return "Storebælt MC";
	}
}
using BridgeTicket;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace StoreBæltsBroencar;

public class StoreBæltsBroenCar : Vehicle
{
	/// <summary>
	/// Denne her constructor bruger vi til at initialisere vores properties
	/// </summary>
	public StoreBæltsBroenCar(string licenseplate, DateTime date, bool brobizz = false)
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

		// Weekend-rabat: 15% (kun for biler)
		if ((Date.DayOfWeek == DayOfWeek.Saturday || Date.DayOfWeek == DayOfWeek.Sunday)
			&& VehicleType() == "Storebælt Car")
		{
			return price * 0.85; // Returnér direkte, så Brobizz ikke anvendes
		}

		// Brobizz-rabat: 5% (kun hvis det ikke er weekend)
		if (Brobizz)
		{
			return price * 0.95;
		}

		// Ingen rabat
		return price;
	}




	/// <summary>
	/// Bruger vi senere til at override med noget polymorfi
	/// </summary>
	/// <returns></returns>
	public override string VehicleType()
	{
		return "Storebælt Car";
	}

}

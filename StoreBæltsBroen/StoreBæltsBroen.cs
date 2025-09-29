using BridgeTicket;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace StoreBæltsBroen;

public abstract class StoreBæltsBroen : Vehicle
{

	/// <summary>
	/// Denne her property bruger til identifikation af bilen.
	/// </summary>
	public string Licenseplate { get; set; }
	/// <summary>
	/// Det bruger vi for at anse tidspunktet af bilen kører over broen
	/// </summary>
	public DateTime Date { get; set; }


	/// <summary>
	/// Denne her constructor bruger vi til at initialisere vores properties
	/// </summary>
	public StoreBæltsBroen(string licenseplate, DateTime date, bool brobizz = false)
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

		// Weekend-rabat: 15%
		if (Date.DayOfWeek == DayOfWeek.Saturday || Date.DayOfWeek == DayOfWeek.Sunday && VehicleType() == "Car")
		{
			price *= 0.85;
		}

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
		return "Car";
	}

}

using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BridgeTicket;

public class Car : Vehicle
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
	public Car(string licenseplate, DateTime date, bool brobizz = false) 
		: base(licenseplate, date, brobizz)
	{
	}

	/// <summary>
	/// Bruger vi for at sikre at prisen vil være fast, med mindre brobizz er brugt eller det er weekend
	/// </summary>
	/// <returns></returns>
	public override double Price()
	{
		double price = 230.0;

		// Weekendrabat
		if (Date.DayOfWeek == DayOfWeek.Saturday || Date.DayOfWeek == DayOfWeek.Sunday)
		{
			price *= 0.8; // 20% rabat i weekenden
		}

		// Brobizz-rabat gælder kun hvis det ikke er weekend
		if (!(Date.DayOfWeek == DayOfWeek.Saturday || Date.DayOfWeek == DayOfWeek.Sunday) && Brobizz)
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BridgeTicket;

public class MC : Vehicle
{
	/// <summary>
	/// Denne her property bruger til identifikation af motorcyklen
	/// </summary>
	public string Licenseplate { get; set; }
	
	/// <summary>
	/// Det bruger vi for at anse tidspunktet af motorcyklen kører over broen
	/// </summary>
	public DateTime Date { get; set; }

	/// <summary>
	/// Denne her constructor bruger vi til at initialisere vores properties
	/// </summary>
	public MC(string licenseplate, DateTime date, bool brobizz = false) 
		: base(licenseplate, date, brobizz)
	{
	}


	/// <summary>
	/// Bruger vi for at sikre at prisen vil være fast
	/// </summary>
	/// <returns></returns>

	public override double Price()
	{
		double price = 120.0;
		return Brobizz ? price * 0.9 : price; // 5% rabat med Brobizz
		
	}
	
	
	/// <summary>
	/// Bruger vi senere til at override med noget polymorfi
	/// </summary>
	/// <returns></returns>
	public override string VehicleType()
	{
		return "MC";
	}
}
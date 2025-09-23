using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BridgeTicket;

public class MC
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
	/// Bruger vi for at sikre at prisen vil være fast
	/// </summary>
	/// <returns></returns>
	
	public double Price()
	{
		return 125;
	}
	
	/// <summary>
	/// Bruger vi senere til at override med noget polymorfi
	/// </summary>
	/// <returns></returns>
	public string VehicleType()
	{
		return "MC";
	}
}
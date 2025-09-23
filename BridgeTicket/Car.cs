using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BridgeTicket;

public class Car : Vehicle
{

	/// <summary>
	/// Denne her property bruger til identifikation af bilen
	/// </summary>
	public string Licenseplate { get; set; }
	/// <summary>
	/// Det bruger vi for at anse tidspunktet af bilen kører over broen
	/// </summary>
	public DateTime Date { get; set; }

	/// <summary>
	/// Bruger vi for at sikre at prisen vil være fast
	/// </summary>
	/// <returns></returns>
	public override double Price()
	{
		return 230;
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

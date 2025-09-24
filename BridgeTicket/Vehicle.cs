using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BridgeTicket;

public abstract class Vehicle
{

	/// <summary>
	/// Denne her property bruger til identifikation af køretøjet.
	/// </summary>
	public string Licenseplate { get; set; }

	/// <summary>
	/// Det bruger vi for at anse tidspunktet af bilen kører over broen
	/// </summary>
	public DateTime Date { get; set; }

	public bool Brobizz { get; set; }


	/// <summary>
	/// Denne her constructor bruger vi til at initialisere vores properties
	/// </summary>
	protected Vehicle(string licenseplate, DateTime date)
	{
		Licenseplate = licenseplate;
		Date = date;

		SetLicensePlate();
	}

	public void SetLicensePlate()
	{
		if (Licenseplate.Length > 7)
		{
			throw new ArgumentException("License plate cannot be longer than 7 characters.");
		}
	}

	/// <summary>
	/// Bruger vi for at sikre at prisen vil være fast
	/// </summary>
	/// <returns></returns>
	public abstract double Price();

	/// <summary>
	/// Den er abstrakt, fordi vi skal override den i de klasser der nedarver fra Vehicle
	/// </summary>
	/// <returns></returns>
	public abstract string VehicleType();
	

}
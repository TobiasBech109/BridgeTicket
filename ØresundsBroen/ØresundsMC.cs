using BridgeTicket;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace ØresundsBroen;

public class ØresundsMC : Vehicle
{

	/// <summary>
	/// Denne her constructor bruger vi til at initialisere vores properties
	/// </summary>
	public ØresundsMC(string licenseplate, DateTime date, bool brobizz = false)
		: base(licenseplate, date, brobizz)
	{
	}

	/// <summary>
	/// Bruger vi for at sikre at prisen vil være fast
	/// </summary>
	/// <returns></returns>

	public override double Price()
	{
		double price = 235.0;

		return Brobizz ? price = 92 : price; 

	}


	/// <summary>
	/// Bruger vi senere til at override med noget polymorfi
	/// </summary>
	/// <returns></returns>
	public override string VehicleType()
	{
		return "Øresunds MC";
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BridgeTicket;
namespace StoreBæltsBroen;

public class StorebæltRepository
{
	// Statisk liste til billetter
	private static List<Vehicle> _tickets = new List<Vehicle>();

	// Tilføj en ny billet
	public static void AddTicket(Vehicle ticket)
	{
		_tickets.Add(ticket);
	}

	// Hent alle billetter
	public static List<Vehicle> GetAllTickets()
	{
		return _tickets;
	}

	// Hent billetter for en bestemt nummerplade
	public static List<Vehicle> GetTicketsByLicensePlate(string licensePlate)
	{
		return _tickets.Where(t => t.Licenseplate == licensePlate).ToList();
	}
}

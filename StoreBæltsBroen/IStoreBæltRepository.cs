using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BridgeTicket;
namespace StoreBæltsBroen;

public interface IStoreBæltRepository
{
	public interface IStorebaeltRepository
	{
		void AddTicket(Vehicle ticket);
		List<Vehicle> GetAllTickets();
		List<Vehicle> GetTicketsByLicensePlate(string licensePlate);
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITS_Support.Models
{
    public class TestingViewModel
    {
        public IEnumerable<GeneralTicketModel> GeneralTickets { get; set; }
        public IEnumerable<TechnicalTicketModel> TechnicalTickets { get; set; }
        public IEnumerable<RoomTicketModel> RoomTickets { get; set; }
        public IEnumerable<RoomModel> Rooms { get; set; }
        public IEnumerable<CampusModel> Campuses { get; set; }
        public IEnumerable<AssetModel> Assets { get; set; }
    }
}

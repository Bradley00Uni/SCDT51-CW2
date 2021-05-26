using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITS_Support.Models
{
    public class CampusRoomViewModel
    {
        public IEnumerable<CampusModel> Campuses { get; set; }
        public IEnumerable<RoomModel> Rooms { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITS_Support.Models
{
    public class RoomAssetViewModel
    {
        public IEnumerable<AssetModel> Assets { get; set; }
        public IEnumerable<RoomModel> Rooms { get; set; }
        public IEnumerable<CampusModel> Campuses { get; set; }
        public IEnumerable<TechnicalTicketModel> T_Tickets { get; set; }
        public IEnumerable<TypeModel> Types { get; set; }
    }
}

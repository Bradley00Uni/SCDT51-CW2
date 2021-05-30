using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITS_Support.Models
{
    public class TechnicalTicketViewModel
    {
        public IEnumerable<TechnicalTicketModel> TechnicalTickets { get; set; }
        public IEnumerable<RoomModel> Rooms { get; set; } 
    }
}

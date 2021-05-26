using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITS_Support.Models
{
    public class RoomViewModel
    {
        public RoomModel Room { get; set; }
        public IEnumerable<SelectListItem> CampusList { get; set; }
    }
}

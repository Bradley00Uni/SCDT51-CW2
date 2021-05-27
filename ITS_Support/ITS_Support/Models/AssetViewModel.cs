using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITS_Support.Models
{
    public class AssetViewModel
    {
        public AssetModel Asset { get; set; }
        public IEnumerable<SelectListItem> RoomList { get; set; }
        public IEnumerable<SelectListItem> CampusList { get; set; }
        public IEnumerable<SelectListItem> TypeList { get; set; }
    }
}

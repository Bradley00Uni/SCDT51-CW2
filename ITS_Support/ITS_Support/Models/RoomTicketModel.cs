using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ITS_Support.Models
{
    public class RoomTicketModel : TicketAbstractModel
    {
        [Required]
        public string RaisedBy { get; set; }

        [Required]
        public int RoomId { get; set; }

        [ForeignKey("RoomId")]
        public RoomModel Room { get; set; }

        public List<UpdateModel> Updates { get; set; }

        public RoomTicketModel()
        {
            Updates = new List<UpdateModel>();
        }
    }
}

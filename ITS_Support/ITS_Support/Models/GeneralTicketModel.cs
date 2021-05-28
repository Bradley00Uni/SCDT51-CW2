using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITS_Support.Models
{
    public class GeneralTicketModel : TicketAbstractModel
    {
        public List<UpdateModel> Updates { get; set; }

        public GeneralTicketModel()
        {
            Updates = new List<UpdateModel>();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ITS_Support.Models
{
    public class TechnicalTicketModel : TicketAbstractModel
    {
        [Required]
        public string RaisedBy { get; set; }

        public RaisedTypes RaisedRole { get; set; }

        [Display(Name ="Device Affected")]
        [Required]
        public int AssetId { get; set; }

        [ForeignKey("AssetId")]
        public AssetModel Asset { get; set; }

        public List<UpdateModel> Updates { get; set; }

        public TechnicalTicketModel()
        {
            Updates = new List<UpdateModel>();
        }
    }

    public enum RaisedTypes
    {
        Student,
        Staff,
        Support
    }
}

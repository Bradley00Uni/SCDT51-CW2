using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ITS_Support.Models
{
    public class UpdateModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Update { get; set; }

        [Required]
        public string Status { get; set; }

        [Required]
        public string CreatedBy { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }
    }

    public enum StatusOptions
    {
        Created,
        Acknowledged,
        Investigating,
        InProgress,
        Complete


    }
}

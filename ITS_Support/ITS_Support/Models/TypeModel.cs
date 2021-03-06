using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ITS_Support.Models
{
    public class TypeModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Category { get; set; }

        public string DisplayImage { get; set; }
    }
}

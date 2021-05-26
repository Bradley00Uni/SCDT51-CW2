using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ITS_Support.Models
{
    public class RoomModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Campus { get; set; }

        [Display(Name = "Last Editied by")]
        public string Creator { get; set; }

        [Display(Name = "Created At")]
        public DateTime CreatedAt { get; set; }

        [Display(Name = "Last Edited")]
        public DateTime LastEdited { get; set; }
    }
}

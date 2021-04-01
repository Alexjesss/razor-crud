using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorCrud.Models
{
    public class Director
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Movie { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
    }
}

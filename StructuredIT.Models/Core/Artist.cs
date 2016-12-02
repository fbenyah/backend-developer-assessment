using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuredIT.Models.Core
{
    public class Artist
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string UniqueIdentifier { get; set; }

        [Required]
        [StringLength(250)]
        public string Name { get; set; }

        [Required]
        [StringLength(3)]
        public string CountryCode { get; set; }
        
        public string Aliases { get; set; }
    }
}

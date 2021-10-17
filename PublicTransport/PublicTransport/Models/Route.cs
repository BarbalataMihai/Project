using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PublicTransport.Models
{
    public class Route
    {
        [Key]
        public int RouteId { get; set; }
        [Required]

        public string Name { get; set; }
        [Required]
        public string Station { get; set; }
        public Bus Bus { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PublicTransport.Models
{
    public class Bus
    {
        [Key]
        public int BusID { get; set; }
        [Required]
        public string Name { get; set; }



    }
}

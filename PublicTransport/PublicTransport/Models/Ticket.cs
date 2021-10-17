using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PublicTransport.Models
{
    public class Ticket
    {
        [Key]
        public int Ticid { get; set; }
        [Required]
        public string Tic_name { get; set; }
        [Required]
        public int Travels { get; set; }
        [Required]
        public int Price { get; set; }
    }
}

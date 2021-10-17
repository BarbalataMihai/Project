using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PublicTransport.Models
{
    public class Subscription
    {
        [Key]
        public int Subid { get; set; }
        public string Sub_name { get; set; }
        [Required]
        public string Duration { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public ICollection<Bus> Buses { get; set; }
    }
}

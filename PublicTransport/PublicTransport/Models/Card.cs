using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PublicTransport.Models
{
    public class Card
    {
        [Key]
        public int CardId { get; set; }
        [Required]
        public DateTime Expiration { get; set; }
        [Required]
        public string Name { get; set; }
        public string CVC { get; set; }
        public string Number { get; set; }

    }
}

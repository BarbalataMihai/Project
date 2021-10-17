using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PublicTransport.Models
{
    public class Transaction_history
    {
        [Key]
        public int Transid { get; set; }
        [Required]
        public DateTime data { get; set; }
    }
}

using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PublicTransport.Models
{
    public class User:IdentityUser
    {
      
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
       


        public ICollection<Ticket> Tickets { get; set; }

        public ICollection<Subscription> Subscriptions { get; set; }
        public ICollection<Transaction_history> Transaction_Histories { get; set; }
        public ICollection<Card> Cards { get; set; }
    }
}

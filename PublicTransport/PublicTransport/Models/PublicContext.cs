using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PublicTransport.Models
{
    public class PublicContext : IdentityDbContext<User>
    {
        public PublicContext(DbContextOptions<PublicContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }

        public DbSet<Subscription> Subscription { get; set; }

        public DbSet<Ticket> Ticket { get; set; }

        public DbSet<Card> Card { get; set; }

        public DbSet<Bus> Bus { get; set; }

        public DbSet<Route> Route { get; set; }
        public DbSet<Transaction_history> Transaction_Histories { get; set; }

  
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Payment_system.Models
{
    public class Payment_systemContext : DbContext
    {
        public Payment_systemContext (DbContextOptions<Payment_systemContext> options)
            : base(options)
        {
        }

        public DbSet<Payment_system.Models.Payment> Payment { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Gymany.Models;

namespace DemoDB.Models
{
    public class AppDBContext: DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options):base(options){
            
        }
        //public DbSet<Customer> Customers{ get; set; }
    }
}
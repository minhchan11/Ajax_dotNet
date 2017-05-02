using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ajax.Models
{
    public class AjaxDbContext : DbContext
    {
        public virtual DbSet<Destination> Destinations { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Ajax;integrated security = True");
        }
    }
}

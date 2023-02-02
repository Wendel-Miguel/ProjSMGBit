using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjSMGBit.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace ProjSMGBit.Data.Context
{
    public class AppDbContext : DbContext
    {
         public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Travel> Travels { get; set; }
    }
}
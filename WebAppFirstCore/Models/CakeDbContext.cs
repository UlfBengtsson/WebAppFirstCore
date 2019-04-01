using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppFirstCore.Models
{
    public class CakeDbContext : DbContext
    {
        public CakeDbContext(DbContextOptions<CakeDbContext> options) : base(options)
        { }
        public DbSet<Cake> Cakes { get; set; }
    }
}
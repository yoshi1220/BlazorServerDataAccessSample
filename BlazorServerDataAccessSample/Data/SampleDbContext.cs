using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlazorServerDataAccessSample.Data.Models;

namespace BlazorServerDataAccessSample.Data
{
    public class SampleDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public SampleDbContext(DbContextOptions<SampleDbContext> options) : base(options)
        {
        }
    }
}

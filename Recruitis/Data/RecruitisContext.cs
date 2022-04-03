using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Recruitis.Models;

namespace Recruitis.Data
{
    public class RecruitisContext : DbContext
    {
        public RecruitisContext(DbContextOptions<RecruitisContext> options)
            : base(options)
        {
        }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Company> Companys { get; set; }
        public DbSet<Risk> Risks { get; set; }
        public DbSet<Status> Statuss { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>().ToTable("Client");
            modelBuilder.Entity<Company>().ToTable("Company");
            modelBuilder.Entity<Risk>().ToTable("Risk");
            modelBuilder.Entity<Status>().ToTable("Status");
        }


    }
}

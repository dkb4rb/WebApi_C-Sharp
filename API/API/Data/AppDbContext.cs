using API.Models;
using Microsoft.EntityFrameworkCore;
using System;


namespace API.Data {

    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {

        }

        public DbSet<Ownerr> Ownerr { get; set; }

        public DbSet<API.Models.Property> Property { get; set; }

        public DbSet<API.Models.PropertyImage> PropertyImage { get; set; }

        public DbSet<API.Models.PropertyTrace> PropertyTrace { get; set; }

    }

}
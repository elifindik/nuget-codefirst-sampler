﻿using Nuget_CodeFirst_Sampler.Models;
using System.Data.Entity;

namespace Nuget_CodeFirst_Sampler.Context
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }

        public DatabaseContext()
        {
            Database.SetInitializer(new DatabaseInitializer());
        }
    }
}
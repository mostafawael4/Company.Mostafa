﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Company.DAL.Models;
using Microsoft.EntityFrameworkCore;
namespace Company.DAL.Data.Contexts
{
    public class CompanyDbcontext : DbContext
    {
        public CompanyDbcontext() : base()
        {
             
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .; Database = Company; Trusted_Connection = True; TrustServerCertificate = True");
        }


        public DbSet<Department> Departments { get; set; }
        public object Department { get; set; }
    }

}

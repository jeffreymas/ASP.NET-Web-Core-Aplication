﻿using LearnNetCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnNetCore.Context
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<RoleUser> RoleUsers { get; set; }
        public DbSet<Departments> Departments { get; set; }
        public DbSet<Divisions> Divisions { get; set; }
        public DbSet<Employees> Employees { get; set; }
        protected override void OnModelCreating( ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employees>()
                        .HasOne<User>(e => e.User)
                        .WithOne(u => u.Employees)
                        .HasForeignKey<Employees>(u => u.EmpId);
        }
        
    }
}

using EmployeeManagement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Api.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        { 
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Department>().HasData(new Department { DepartmentId = 1, DepartmentName = "IT" });
            modelBuilder.Entity<Department>().HasData(new Department { DepartmentId = 2, DepartmentName = "HR" });
            modelBuilder.Entity<Department>().HasData(new Department { DepartmentId = 3, DepartmentName = "Payroll" });
            modelBuilder.Entity<Department>().HasData(new Department { DepartmentId = 4, DepartmentName = "Admin" });

            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    EmployeeId = 1,
                    FirstName = "F1",
                    LastName = "L1",
                    DateOfBirth = new DateTime(2000, 1, 1),
                    DepartmentId = 1,
                    Email = "f1@gmail.com",
                    Gender = Gender.Male,
                    PhotoPath = "images/1.png"
                });

            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    EmployeeId = 2,
                    FirstName = "F2",
                    LastName = "L2",
                    DateOfBirth = new DateTime(2000, 2, 2),
                    DepartmentId = 2,
                    Email = "f2@gmail.com",
                    Gender = Gender.Female,
                    PhotoPath = "images/2.png"
                });
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    EmployeeId = 3,
                    FirstName = "F3",
                    LastName = "L3",
                    DateOfBirth = new DateTime(2000, 3, 3),
                    DepartmentId = 3,
                    Email = "f3@gmail.com",
                    Gender = Gender.Other,
                    PhotoPath = "images/3.png"
                });
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    EmployeeId = 4,
                    FirstName = "F4",
                    LastName = "L4",
                    DateOfBirth = new DateTime(2000, 4, 4),
                    DepartmentId = 3,
                    Email = "f4@gmail.com",
                    Gender = Gender.Female,
                    PhotoPath = "images/4.png"
                });
        }
    }
}

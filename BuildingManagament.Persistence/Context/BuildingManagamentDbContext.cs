using BuildingManagament.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingManagament.Persistence.Context
{
    public class BuildingManagamentDbContext : DbContext
    {
        public BuildingManagamentDbContext(DbContextOptions<BuildingManagamentDbContext> options)
          : base(options) { }

        public DbSet<Building> Buildings => Set<Building>();
        public DbSet<Unit> Units => Set<Unit>();
        public DbSet<User> Users => Set<User>();
        public DbSet<Role> Roles => Set<Role>();
        public DbSet<Meeting> Meetings => Set<Meeting>();
        public DbSet<Decision> Decisions => Set<Decision>();
        public DbSet<Vote> Votes => Set<Vote>();
        public DbSet<ExpenseCategory> ExpenseCategories => Set<ExpenseCategory>();
        public DbSet<Expense> Expenses => Set<Expense>();
        public DbSet<DuePlan> DuePlans => Set<DuePlan>();
        public DbSet<Payment> Payments => Set<Payment>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            foreach (var fk in modelBuilder.Model.GetEntityTypes()
                .SelectMany(e => e.GetForeignKeys()))
            {
                fk.DeleteBehavior = DeleteBehavior.NoAction;
            }
        }


    }
}

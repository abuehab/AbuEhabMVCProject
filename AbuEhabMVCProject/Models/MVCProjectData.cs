using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;

namespace AbuEhabMVCProject.Models
{
    public class MVCProjectData : DbContext
    {

        public DbSet <Project> Projects { get; set; }
        public DbSet <User> Users { get; set; }
        public DbSet <Beneficiary> Beneficiaries { get; set; }
        public DbSet <Actitvity> Actitvities { get; set; }
        

        protected override void OnModelCreating(DbModelBuilder AbuEhabBuilder)
        {
            AbuEhabBuilder.Entity<Project>().MapToStoredProcedures();
            AbuEhabBuilder.Entity<User>().MapToStoredProcedures();
            AbuEhabBuilder.Entity<Beneficiary>().MapToStoredProcedures();
            AbuEhabBuilder.Entity<Actitvity>().MapToStoredProcedures();
            base.OnModelCreating(AbuEhabBuilder);
        }
    }
}
﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sibintek
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SibintekEntities : DbContext
    {
        private static SibintekEntities _context;
        public static SibintekEntities GetContext()
        {
            if (_context == null)
                _context = new SibintekEntities();
            return _context;
        }
        
        public SibintekEntities()
            : base("name=SibintekEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<ArchitecturalDesign> ArchitecturalDesign { get; set; }
        public DbSet<AZI> AZI { get; set; }
        public DbSet<BelongingToSystem> BelongingToSystem { get; set; }
        public DbSet<BusinessUnitSupport> BusinessUnitSupport { get; set; }
        public DbSet<CostType> CostType { get; set; }
        public DbSet<CoveredByTheProjectType> CoveredByTheProjectType { get; set; }
        public DbSet<CriticalityLevel> CriticalityLevel { get; set; }
        public DbSet<DecisionMakingLevel> DecisionMakingLevel { get; set; }
        public DbSet<EconomicEffect> EconomicEffect { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<EmployeeFTE> EmployeeFTE { get; set; }
        public DbSet<EmployeeType> EmployeeType { get; set; }
        public DbSet<ICLevel> ICLevel { get; set; }
        public DbSet<InternetAccess> InternetAccess { get; set; }
        public DbSet<PrivacyLevel> PrivacyLevel { get; set; }
        public DbSet<ProjectType> ProjectType { get; set; }
        public DbSet<PurchaseOfEquipment> PurchaseOfEquipment { get; set; }
        public DbSet<PurchasingSoftwareLicenses> PurchasingSoftwareLicenses { get; set; }
        public DbSet<Sum> Sum { get; set; }
        public DbSet<TypeByContent> TypeByContent { get; set; }
        public DbSet<Classifier> Classifier { get; set; }
    }
}

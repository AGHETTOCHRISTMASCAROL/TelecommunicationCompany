﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OfficeApp.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TelecommunicationsСompanyEntities : DbContext
    {
        public TelecommunicationsСompanyEntities()
            : base("name=TelecommunicationsСompanyEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Building> Building { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<ClientPayerCodes> ClientPayerCodes { get; set; }
        public virtual DbSet<Hardware> Hardware { get; set; }
        public virtual DbSet<HardwareForService> HardwareForService { get; set; }
        public virtual DbSet<Manufacturer> Manufacturer { get; set; }
        public virtual DbSet<PayerCode> PayerCode { get; set; }
        public virtual DbSet<PayerCodeServices> PayerCodeServices { get; set; }
        public virtual DbSet<PaymentTransactions> PaymentTransactions { get; set; }
        public virtual DbSet<Post> Post { get; set; }
        public virtual DbSet<PostLogin> PostLogin { get; set; }
        public virtual DbSet<Request> Request { get; set; }
        public virtual DbSet<Service> Service { get; set; }
        public virtual DbSet<Staff> Staff { get; set; }
        public virtual DbSet<StaffOnRequest> StaffOnRequest { get; set; }
        public virtual DbSet<Street> Street { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TempStatement> TempStatement { get; set; }
        public virtual DbSet<TypeOfHardware> TypeOfHardware { get; set; }
        public virtual DbSet<TypeOfService> TypeOfService { get; set; }
        public virtual DbSet<TypeOfTransaction> TypeOfTransaction { get; set; }
    }
}

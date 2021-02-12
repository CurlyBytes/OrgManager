﻿// <auto-generated />
using System;
using JDS.OrgManager.Persistence.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace JDS.OrgManager.Persistence.Migrations
{
    [DbContext(typeof(ApplicationWriteDbContext))]
    partial class ApplicationWriteDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("JDS.OrgManager.Application.Common.Currencies.CurrencyEntity", b =>
                {
                    b.Property<string>("Code")
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Code");

                    b.ToTable("Currencies");
                });

            modelBuilder.Entity("JDS.OrgManager.Application.Common.Employees.EmployeeEntity", b =>
                {
                    b.Property<int>("TenantId")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Address1")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Address2")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<int>("AspNetUsersId")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<DateTime>("CreatedUtc")
                        .HasColumnType("datetime2");

                    b.Property<string>("CurrencyCode")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.Property<DateTime>("DateHired")
                        .HasColumnType("date");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<DateTime?>("DateTerminated")
                        .HasColumnType("date");

                    b.Property<int>("EmployeeLevel")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("LastModifiedBy")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<DateTime?>("LastModifiedUtc")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.Property<string>("MiddleName")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<int>("PaidTimeOffPolicyId")
                        .HasColumnType("int");

                    b.Property<decimal?>("PtoHoursRemaining")
                        .HasColumnType("decimal(18,4)");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(18,4)");

                    b.Property<string>("SocialSecurityNumber")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("TenantId", "Id");

                    b.HasIndex("CurrencyCode");

                    b.HasIndex("TenantId", "PaidTimeOffPolicyId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("JDS.OrgManager.Application.Common.Employees.EmployeeManagerEntity", b =>
                {
                    b.Property<int>("TenantId")
                        .HasColumnType("int");

                    b.Property<int>("ManagerId")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.HasKey("TenantId", "ManagerId", "EmployeeId");

                    b.HasIndex("TenantId", "EmployeeId");

                    b.ToTable("EmployeeManagers");
                });

            modelBuilder.Entity("JDS.OrgManager.Application.Common.TimeOff.PaidTimeOffPolicyEntity", b =>
                {
                    b.Property<int>("TenantId")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("AllowsUnlimitedPto")
                        .HasColumnType("bit");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<DateTime>("CreatedUtc")
                        .HasColumnType("datetime2");

                    b.Property<int>("EmployeeLevel")
                        .HasColumnType("int");

                    b.Property<bool>("IsDefaultForEmployeeLevel")
                        .HasColumnType("bit");

                    b.Property<string>("LastModifiedBy")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<DateTime?>("LastModifiedUtc")
                        .HasColumnType("datetime2");

                    b.Property<decimal?>("MaxPtoHours")
                        .HasColumnType("decimal(18,4)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal?>("PtoAccrualRate")
                        .HasColumnType("decimal(18,4)");

                    b.HasKey("TenantId", "Id");

                    b.ToTable("PaidTimeOffPolicies");
                });

            modelBuilder.Entity("JDS.OrgManager.Application.Customers.CustomerEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Address1")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Address2")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<int>("AspNetUsersId")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int?>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<DateTime>("CreatedUtc")
                        .HasColumnType("datetime2");

                    b.Property<string>("CurrencyCode")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("LastModifiedBy")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<DateTime?>("LastModifiedUtc")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.Property<string>("MiddleName")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<int?>("Title")
                        .HasColumnType("int");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.HasIndex("CurrencyCode");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("JDS.OrgManager.Application.Tenants.TenantAspNetUserEntity", b =>
                {
                    b.Property<int>("TenantId")
                        .HasColumnType("int");

                    b.Property<int>("AspNetUsersId")
                        .HasColumnType("int");

                    b.HasKey("TenantId", "AspNetUsersId");

                    b.ToTable("TenantAspNetUsers");
                });

            modelBuilder.Entity("JDS.OrgManager.Application.Tenants.TenantEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<Guid>("AssignmentKey")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<DateTime>("CreatedUtc")
                        .HasColumnType("datetime2");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("LastModifiedBy")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<DateTime?>("LastModifiedUtc")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Tenants");
                });

            modelBuilder.Entity("JDS.OrgManager.Application.Common.Employees.EmployeeEntity", b =>
                {
                    b.HasOne("JDS.OrgManager.Application.Common.Currencies.CurrencyEntity", "Currency")
                        .WithMany()
                        .HasForeignKey("CurrencyCode")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("JDS.OrgManager.Application.Tenants.TenantEntity", "Tenant")
                        .WithMany("Employees")
                        .HasForeignKey("TenantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("JDS.OrgManager.Application.Common.TimeOff.PaidTimeOffPolicyEntity", "PaidTimeOffPolicy")
                        .WithMany()
                        .HasForeignKey("TenantId", "PaidTimeOffPolicyId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Currency");

                    b.Navigation("PaidTimeOffPolicy");

                    b.Navigation("Tenant");
                });

            modelBuilder.Entity("JDS.OrgManager.Application.Common.Employees.EmployeeManagerEntity", b =>
                {
                    b.HasOne("JDS.OrgManager.Application.Common.Employees.EmployeeEntity", "Employee")
                        .WithMany("Managers")
                        .HasForeignKey("TenantId", "EmployeeId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("JDS.OrgManager.Application.Common.Employees.EmployeeEntity", "Manager")
                        .WithMany("Subordinates")
                        .HasForeignKey("TenantId", "ManagerId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Manager");
                });

            modelBuilder.Entity("JDS.OrgManager.Application.Customers.CustomerEntity", b =>
                {
                    b.HasOne("JDS.OrgManager.Application.Common.Currencies.CurrencyEntity", "Currency")
                        .WithMany()
                        .HasForeignKey("CurrencyCode")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Currency");
                });

            modelBuilder.Entity("JDS.OrgManager.Application.Tenants.TenantAspNetUserEntity", b =>
                {
                    b.HasOne("JDS.OrgManager.Application.Tenants.TenantEntity", "Tenant")
                        .WithMany("AspNetUsers")
                        .HasForeignKey("TenantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tenant");
                });

            modelBuilder.Entity("JDS.OrgManager.Application.Tenants.TenantEntity", b =>
                {
                    b.HasOne("JDS.OrgManager.Application.Customers.CustomerEntity", "Customer")
                        .WithMany("Tenants")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("JDS.OrgManager.Application.Common.Employees.EmployeeEntity", b =>
                {
                    b.Navigation("Managers");

                    b.Navigation("Subordinates");
                });

            modelBuilder.Entity("JDS.OrgManager.Application.Customers.CustomerEntity", b =>
                {
                    b.Navigation("Tenants");
                });

            modelBuilder.Entity("JDS.OrgManager.Application.Tenants.TenantEntity", b =>
                {
                    b.Navigation("AspNetUsers");

                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}

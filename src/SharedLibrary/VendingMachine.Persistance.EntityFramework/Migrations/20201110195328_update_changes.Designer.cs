﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VendingMachine.Persistance.EntityFramework.Context;

namespace VendingMachine.Persistance.EntityFramework.Migrations
{
    [DbContext(typeof(VendingMachineDbContext))]
    [Migration("20201110195328_update_changes")]
    partial class update_changes
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("VendingMachine.Domain.Models.Models.Public.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<DateTime>("CreationTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<Guid?>("CreatorUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("DeleterUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DeletionTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<Guid?>("LastModifierUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("ModicationTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("ProductDescription")
                        .HasColumnType("nvarchar(1000)")
                        .HasMaxLength(1000);

                    b.Property<Guid?>("ProductImageId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<decimal>("ProductPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<long>("StatusId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("ProductImageId");

                    b.HasIndex("StatusId");

                    b.ToTable("Products","dbo");
                });

            modelBuilder.Entity("VendingMachine.Domain.Models.Models.Public.ProductImage", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<DateTime>("CreationTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<Guid?>("CreatorUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("DeleterUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DeletionTime")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("ImageData")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("ImageDescription")
                        .HasColumnType("nvarchar(1000)")
                        .HasMaxLength(1000);

                    b.Property<string>("ImageName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<Guid?>("LastModifierUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("ModicationTime")
                        .HasColumnType("datetime2");

                    b.Property<long>("StatusId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("StatusId");

                    b.ToTable("ProductImages","dbo");
                });

            modelBuilder.Entity("VendingMachine.Domain.Models.Models.Public.Sale", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<decimal>("Change")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("CreationTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<long>("StatusId")
                        .HasColumnType("bigint");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("StatusId");

                    b.ToTable("Sales","dbo");
                });

            modelBuilder.Entity("VendingMachine.Domain.Models.Models.Public.Status", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("ActiveStatus")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<DateTime>("CreationTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<Guid?>("CreatorUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("DeleterUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DeletionTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<Guid?>("LastModifierUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("ModicationTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("StatusCode")
                        .HasColumnType("int");

                    b.Property<string>("StatusDescription")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<string>("StatusName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("StatusCode")
                        .IsUnique();

                    b.ToTable("Statuses","dbo");
                });

            modelBuilder.Entity("VendingMachine.Domain.Models.Models.Public.StockInventory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<DateTime>("CreationTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<Guid?>("CreatorUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("DeleterUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DeletionTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<bool>("IsOutOfStock")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<Guid?>("LastModifierUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("ModicationTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<long>("StatusId")
                        .HasColumnType("bigint");

                    b.Property<int>("TotalItems")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("StatusId");

                    b.ToTable("StockInventories","dbo");
                });

            modelBuilder.Entity("VendingMachine.Domain.Models.Models.Public.Product", b =>
                {
                    b.HasOne("VendingMachine.Domain.Models.Models.Public.ProductImage", "ProductImage")
                        .WithMany()
                        .HasForeignKey("ProductImageId");

                    b.HasOne("VendingMachine.Domain.Models.Models.Public.Status", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("VendingMachine.Domain.Models.Models.Public.ProductImage", b =>
                {
                    b.HasOne("VendingMachine.Domain.Models.Models.Public.Status", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("VendingMachine.Domain.Models.Models.Public.Sale", b =>
                {
                    b.HasOne("VendingMachine.Domain.Models.Models.Public.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VendingMachine.Domain.Models.Models.Public.Status", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("VendingMachine.Domain.Models.Models.Public.StockInventory", b =>
                {
                    b.HasOne("VendingMachine.Domain.Models.Models.Public.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VendingMachine.Domain.Models.Models.Public.Status", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

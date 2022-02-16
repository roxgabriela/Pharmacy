﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PharmacyStorage.Data;

namespace PharmacyStorage.Migrations
{
    [DbContext(typeof(PharmacyStorageContext))]
    [Migration("20220112225106_One_medicine")]
    partial class One_medicine
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PharmacyStorage.Models.Client", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CNP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClientName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("PharmacyStorage.Models.Doctor", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DoctorName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Specialization")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Doctor");
                });

            modelBuilder.Entity("PharmacyStorage.Models.Medicine", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ExpirationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("ProviderID")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ProviderID");

                    b.ToTable("Medicine");
                });

            modelBuilder.Entity("PharmacyStorage.Models.Prescription", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClientID")
                        .HasColumnType("int");

                    b.Property<string>("Diagnosis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DoctorID")
                        .HasColumnType("int");

                    b.Property<int>("MedicineID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ClientID");

                    b.HasIndex("DoctorID");

                    b.HasIndex("MedicineID");

                    b.ToTable("Prescription");
                });

            modelBuilder.Entity("PharmacyStorage.Models.Provider", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FactoryAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Provider");
                });

            modelBuilder.Entity("PharmacyStorage.Models.Medicine", b =>
                {
                    b.HasOne("PharmacyStorage.Models.Provider", "Provider")
                        .WithMany("Medication")
                        .HasForeignKey("ProviderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Provider");
                });

            modelBuilder.Entity("PharmacyStorage.Models.Prescription", b =>
                {
                    b.HasOne("PharmacyStorage.Models.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PharmacyStorage.Models.Doctor", "Doctor")
                        .WithMany()
                        .HasForeignKey("DoctorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PharmacyStorage.Models.Medicine", "Medicine")
                        .WithMany()
                        .HasForeignKey("MedicineID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("Doctor");

                    b.Navigation("Medicine");
                });

            modelBuilder.Entity("PharmacyStorage.Models.Provider", b =>
                {
                    b.Navigation("Medication");
                });
#pragma warning restore 612, 618
        }
    }
}

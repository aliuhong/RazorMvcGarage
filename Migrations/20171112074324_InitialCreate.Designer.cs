﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using RazorMvcGarage.Models;
using System;

namespace RazorMvcGarage.Migrations
{
    [DbContext(typeof(RepairContext))]
    [Migration("20171112074324_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RazorMvcGarage.Models.Repair", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Miles");

                    b.Property<DateTime>("RepairDate");

                    b.Property<string>("RepairType")
                        .IsRequired();

                    b.Property<string>("Vehicle")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.Property<string>("Workdone")
                        .IsRequired();

                    b.Property<string>("Workshop")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("ID");

                    b.ToTable("Repair");
                });
#pragma warning restore 612, 618
        }
    }
}

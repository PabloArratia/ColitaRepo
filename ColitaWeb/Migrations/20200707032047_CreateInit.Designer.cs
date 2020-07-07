﻿// <auto-generated />
using System;
using ColitaWeb;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ColitaWeb.Migrations
{
    [DbContext(typeof(colitaContext))]
    [Migration("20200707032047_CreateInit")]
    partial class CreateInit
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ColitaWeb.Models.ColitaEF", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("ColitaDescription")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ColitaName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("EstadoDeColita")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("ColitasEF");
                });
#pragma warning restore 612, 618
        }
    }
}

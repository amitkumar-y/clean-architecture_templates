﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Template.Infraestructure.DataContext;

#nullable disable

namespace Template.Infraestructure.Migrations
{
    [DbContext(typeof(TemplateDbContext))]
    [Migration("20220909131647_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Template.Domain.Entities.TemplateEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("ExampleString")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Template");
                });
#pragma warning restore 612, 618
        }
    }
}
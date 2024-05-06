﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using montaspro.nicolo._4i.rubricaWebDb.Models;

#nullable disable

namespace montaspro.nicolo._4i.rubricaWebDb.Migrations
{
    [DbContext(typeof(dbContext))]
    [Migration("20240417064641_AggiuntaEmail")]
    partial class AggiuntaEmail
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0");

            modelBuilder.Entity("montaspro.nicolo._4i.rubricaWebDb.Models.Persona", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("cognome")
                        .HasColumnType("TEXT");

                    b.Property<string>("nome")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Persone");
                });
#pragma warning restore 612, 618
        }
    }
}

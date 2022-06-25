﻿// <auto-generated />

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Nikan.Services.Identity.Admin.EntityFramework.Shared.DbContexts;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using System;

namespace Nikan.Services.Identity.Admin.EntityFramework.PostgreSQL.Migrations.Logging
{
  [DbContext(typeof(AdminLogDbContext))]
  partial class AdminLogDbContextModelSnapshot : ModelSnapshot
  {
    protected override void BuildModel(ModelBuilder modelBuilder)
    {
#pragma warning disable 612, 618
      modelBuilder
          .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
          .HasAnnotation("ProductVersion", "3.0.0")
          .HasAnnotation("Relational:MaxIdentifierLength", 63);

      modelBuilder.Entity("Skoruba.IdentityServer4.Admin.EntityFramework.Entities.Log", b =>
          {
            b.Property<long>("Id")
                      .ValueGeneratedOnAdd()
                      .HasColumnType("bigint")
                      .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            b.Property<string>("Exception")
                      .HasColumnType("text");

            b.Property<string>("Level")
                      .HasColumnType("character varying(128)")
                      .HasMaxLength(128);

            b.Property<string>("LogEvent")
                      .HasColumnType("text");

            b.Property<string>("Message")
                      .HasColumnType("text");

            b.Property<string>("MessageTemplate")
                      .HasColumnType("text");

            b.Property<string>("Properties")
                      .HasColumnType("text");

            b.Property<DateTimeOffset>("TimeStamp")
                      .HasColumnType("timestamp with time zone");

            b.HasKey("Id");

            b.ToTable("Log");
          });
#pragma warning restore 612, 618
    }
  }
}









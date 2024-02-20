﻿// <auto-generated />
using System;
using DAL.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DAL.Migrations
{
    [DbContext(typeof(ToDoContext))]
    [Migration("20240220155817_AddedNullDescription")]
    partial class AddedNullDescription
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DAL.Entities.ToDoItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("ToDoItems");

                    b.HasData(
                        new
                        {
                            Id = new Guid("6eef816d-0700-49ab-b206-a88b912ec537"),
                            Description = "Buy milk, chocolate and bread.",
                            Status = false,
                            Title = "Shopping"
                        },
                        new
                        {
                            Id = new Guid("23a349e0-3620-45b4-87e8-8b667a7386e8"),
                            Description = "",
                            Status = true,
                            Title = "Finish homework"
                        },
                        new
                        {
                            Id = new Guid("960f291a-6417-449e-b2a7-9b2ab893c01b"),
                            Description = "Revise materials for exam, which will happen at 14:00 tomorrow.",
                            Status = false,
                            Title = "Cram at night"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
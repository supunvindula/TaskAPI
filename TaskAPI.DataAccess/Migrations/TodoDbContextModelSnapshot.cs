﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TaskAPI.DataAccess;

namespace TaskAPI.DataAccess.Migrations
{
    [DbContext(typeof(TodoDbContext))]
    partial class TodoDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TaskAPI.Models.Todo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Due")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Todos");

                    b.HasData(
                        new
                        {
                            Id = 7,
                            Created = new DateTime(2022, 1, 30, 16, 11, 37, 915, DateTimeKind.Local).AddTicks(5236),
                            Description = "Get some text books for school",
                            Due = new DateTime(2022, 2, 4, 16, 11, 37, 918, DateTimeKind.Local).AddTicks(8992),
                            Status = 0,
                            Title = "Get books for school - DB"
                        },
                        new
                        {
                            Id = 8,
                            Created = new DateTime(2022, 1, 30, 16, 11, 37, 919, DateTimeKind.Local).AddTicks(9188),
                            Description = "Buy from Daraz",
                            Due = new DateTime(2022, 2, 2, 16, 11, 37, 919, DateTimeKind.Local).AddTicks(9198),
                            Status = 0,
                            Title = "Get a headphone - DB"
                        },
                        new
                        {
                            Id = 9,
                            Created = new DateTime(2022, 1, 30, 16, 11, 37, 919, DateTimeKind.Local).AddTicks(9314),
                            Description = "To protect from mosquitos",
                            Due = new DateTime(2022, 2, 3, 16, 11, 37, 919, DateTimeKind.Local).AddTicks(9315),
                            Status = 0,
                            Title = "Put a cover to the window - DB"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
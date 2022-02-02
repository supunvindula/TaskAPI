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

            modelBuilder.Entity("TaskAPI.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddressNo")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Street")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AddressNo = "45",
                            City = "Gampaha",
                            FullName = "Supun Vindula",
                            Street = "Daham Mawatha"
                        },
                        new
                        {
                            Id = 2,
                            AddressNo = "15",
                            City = "Kandy",
                            FullName = "Kushini Kalupahana",
                            Street = "Nawam Mawatha"
                        },
                        new
                        {
                            Id = 3,
                            AddressNo = "789",
                            City = "Colombo",
                            FullName = "Maneesha Randeniya",
                            Street = "Bulls Rd"
                        },
                        new
                        {
                            Id = 4,
                            AddressNo = "25",
                            City = "Palastine",
                            FullName = "Basuru Wickramarachchi",
                            Street = "Radan Rd"
                        });
                });

            modelBuilder.Entity("TaskAPI.Models.Todo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Due")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.ToTable("Todos");

                    b.HasData(
                        new
                        {
                            Id = 7,
                            AuthorId = 1,
                            Created = new DateTime(2022, 2, 2, 8, 19, 15, 355, DateTimeKind.Local).AddTicks(8105),
                            Description = "Get some text books for school",
                            Due = new DateTime(2022, 2, 7, 8, 19, 15, 358, DateTimeKind.Local).AddTicks(4945),
                            Status = 0,
                            Title = "Get books for school - DB"
                        },
                        new
                        {
                            Id = 8,
                            AuthorId = 2,
                            Created = new DateTime(2022, 2, 2, 8, 19, 15, 358, DateTimeKind.Local).AddTicks(5732),
                            Description = "Buy from Daraz",
                            Due = new DateTime(2022, 2, 5, 8, 19, 15, 358, DateTimeKind.Local).AddTicks(5735),
                            Status = 2,
                            Title = "Get a headphone - DB"
                        },
                        new
                        {
                            Id = 9,
                            AuthorId = 1,
                            Created = new DateTime(2022, 2, 2, 8, 19, 15, 358, DateTimeKind.Local).AddTicks(5751),
                            Description = "To protect from mosquitos",
                            Due = new DateTime(2022, 2, 6, 8, 19, 15, 358, DateTimeKind.Local).AddTicks(5753),
                            Status = 0,
                            Title = "Put a cover to the window - DB"
                        });
                });

            modelBuilder.Entity("TaskAPI.Models.Todo", b =>
                {
                    b.HasOne("TaskAPI.Models.Author", "Author")
                        .WithMany("Todos")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });

            modelBuilder.Entity("TaskAPI.Models.Author", b =>
                {
                    b.Navigation("Todos");
                });
#pragma warning restore 612, 618
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TaskAPI.Models;

namespace TaskAPI.DataAccess
{
    public class TodoDbContext : DbContext
    {
        public DbSet<Todo> Todos { get; set; }
        public DbSet<Author> Authors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=localhost; Database=MyTodoDb; Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasData(new Author[] 
            {
                new Author {Id = 1, FullName= "Supun Vindula", AddressNo="45", Street="Daham Mawatha", City="Gampaha",JobRole="Developer"},
                new Author {Id = 2, FullName= "Kushini Kalupahana" , AddressNo="15", Street="Nawam Mawatha", City="Kandy",JobRole="Systems Engineer"},
                new Author {Id = 3, FullName= "Maneesha Randeniya" , AddressNo="789", Street="Bulls Rd", City="Colombo",JobRole="Developer"},
                new Author {Id = 4, FullName= "Basuru Wickramarachchi" , AddressNo="25", Street="Radan Rd", City="Palastine",JobRole="QA"}
            });
            modelBuilder.Entity<Todo>().HasData(new Todo
            {
                Id = 7,
                Title = "Get books for school - DB",
                Description = "Get some text books for school",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                Status = TodoStatus.New,
                AuthorId = 1
            });
            modelBuilder.Entity<Todo>().HasData(new Todo
            {
                Id = 8,
                Title = "Get a headphone - DB",
                Description = "Buy from Daraz",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(3),
                Status = TodoStatus.Completed,
                AuthorId = 2
            });
            modelBuilder.Entity<Todo>().HasData(new Todo
            {
                Id = 9,
                Title = "Put a cover to the window - DB",
                Description = "To protect from mosquitos",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(4),
                Status = TodoStatus.New,
                AuthorId = 1
            });
        }
    }
}

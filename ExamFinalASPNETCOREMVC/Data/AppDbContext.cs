using ExamFinalASPNETCOREMVC.Models;
using Microsoft.EntityFrameworkCore;
using System.Net.Http.Headers;

namespace ExamFinalASPNETCOREMVC.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().ToTable("Products");
            modelBuilder.Entity<Product>().HasData(
       new Product
       {
           Id = 1,
           Name = "Laptop",
           Description = "Powerful laptop for work and entertainment",
           Price = 999.99
       },
       new Product
       {
           Id = 2,
           Name = "Smartphone",
           Description = "High-end smartphone with advanced features",
           Price = 699.99
       },
       new Product
       {
           Id = 3,
           Name = "Headphones",
           Description = "Noise-canceling headphones for immersive audio experience",
           Price = 149.99
       },
       new Product
       {
           Id = 4,
           Name = "Rocket Backpack",
           Description = "Futuristic backpack equipped with anti-gravity technology",
           Price = 249.99
       },
        new Product
        {
            Id = 5,
            Name = "Invisibility Cloak",
            Description = "Magical cloak that renders the wearer invisible",
            Price = 599.99
        },
        new Product
        {
            Id = 6,
            Name = "Hoverboard",
            Description = "Levitating skateboard for an effortless commute",
            Price = 129.99
        },
        new Product
        {
            Id = 7,
            Name = "Robot Butler",
            Description = "AI-powered robotic butler for personalized assistance",
            Price = 1999.99
        },
        new Product
        {
            Id = 8,
            Name = "Virtual Reality Glasses",
            Description = "Immersive VR glasses for virtual adventures",
            Price = 299.99
        },
        new Product
        {
            Id = 9,
            Name = "Archimedes' Infinite Bath",
            Description = "A self-refilling and infinitely warm bath inspired by Archimedes' principles",
            Price = 129.99
        },
        new Product
        {
            Id = 10,
            Name = "Shakespearean Smart Pen",
            Description = "A pen that translates your thoughts into Shakespearean sonnets as you write",
            Price = 49.99
        },
        new Product
        {
            Id = 11,
            Name = "Time-Traveling Watch",
            Description = "Watch that lets you travel through time and explore different eras",
            Price = 999.99
        }
   );
            base.OnModelCreating(modelBuilder);
        }
    }
}

using Microsoft.EntityFrameworkCore;
using NoteBookApp.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBookApp.Repository.ContextDb
{
    public class NoteBookDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer(@"Data Source=ASUS\SQLEXPRESS;Initial Catalog=TestNotes;Integrated Security=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Note>()
                .HasOne(i => i.User)
                .WithMany(i => i.Notes)
                .IsRequired()
                .OnDelete(DeleteBehavior.ClientCascade);
        }
    }
}

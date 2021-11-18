using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.EntityFrameworkCore;

namespace MiniLibrary.Models
{
    class BookContext : DbContext
    {
        private const string connectionString = "Server=(localdb)\\mssqllocaldb;Database=BooksDB;Trusted_Connection=True;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

        public DbSet<Book> Books { get; set; }

    }
}


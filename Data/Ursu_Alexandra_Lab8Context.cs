using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ursu_Alexandra_Lab8.Models;

namespace Ursu_Alexandra_Lab8.Data
{
    public class Ursu_Alexandra_Lab8Context : DbContext
    {
        public Ursu_Alexandra_Lab8Context (DbContextOptions<Ursu_Alexandra_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Ursu_Alexandra_Lab8.Models.Book> Book { get; set; }

        public DbSet<Ursu_Alexandra_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Ursu_Alexandra_Lab8.Models.BookCategory> BookCategory { get; set; }
    }
}

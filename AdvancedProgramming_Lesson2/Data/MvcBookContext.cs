using AdvancedProgramming_Lesson2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedProgramming_Lesson2.Data
{
    public class MvcBookContext : DbContext
    {
        public MvcBookContext(DbContextOptions<MvcBookContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Book { get; set; }
    }

}

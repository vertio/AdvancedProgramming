using AdvancedProgramming_Lesson2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedProgramming_Lesson2.Data
{
    public class MvcCinemaContext : DbContext
    {
        public MvcCinemaContext(DbContextOptions<MvcCinemaContext> options)
          : base(options)
        {
        }

        public DbSet<Cinema> Cinema { get; set; }
    }
}

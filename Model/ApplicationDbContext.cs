using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCrud.Model
{
    public class ApplicationDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder )
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-EF9DLAS;Database=BlazorCrud;Trusted_Connection=True;MultipleActiveResultSets=true");    


        }
        public DbSet<Student> student { get; set; }

    }
}

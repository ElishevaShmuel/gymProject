
using gym.DataNew.@interface;
using gym.CoreNew.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace gym.DataNew
{
    public class DataContext : DbContext
    {
        public DbSet<cours> Courses { get; set; }
        public DbSet<teacher> teachers { get; set; }
        public DbSet<member> Members { get; set; }

        //public DataContext()
        //{
        //    Courses = new List<cours>();
        //    teachers = new List<teacher>();
        //    Members = new List<member>();   
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=sample_db");
        }
    }
}

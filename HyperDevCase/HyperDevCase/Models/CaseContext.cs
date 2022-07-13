using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using HyperDevCase.Models;

namespace HyperDevCase.Models
{
    public class CaseContext:DbContext
    {
        public CaseContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptions)
        {
            dbContextOptions.UseSqlServer("Data Source=REVISION-PC;Initial Catalog=case;Integrated Security=True");
        }
        public DbSet<Company> Companies { get; set; }
        public DbSet<HyperDevCase.Models.Department> Department { get; set; }

    }
}

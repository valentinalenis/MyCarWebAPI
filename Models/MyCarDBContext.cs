using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyCarWebAPI.Models
{
    public class MyCarDBContext:DbContext
    {
        public MyCarDBContext(DbContextOptions<MyCarDBContext> options) : base(options)
        { 
        }

        public DbSet<Car> Cars { get; set; }
    }
}

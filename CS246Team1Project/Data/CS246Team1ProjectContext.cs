using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CS246Team1Project.Models;

namespace CS246Team1Project.Data
{
    public class CS246Team1ProjectContext : DbContext
    {
        public CS246Team1ProjectContext (DbContextOptions<CS246Team1ProjectContext> options)
            : base(options)
        {
        }

        public DbSet<CS246Team1Project.Models.StudentModel> StudentModel { get; set; } = default!;
    }
}

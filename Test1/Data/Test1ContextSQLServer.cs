using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Test1.Models;

namespace Test1.Data
{
    public class Test1ContextSQLServer : DbContext
    {
        public Test1ContextSQLServer (DbContextOptions<Test1ContextSQLServer> options)
            : base(options)
        {
        }

        public DbSet<Test1.Models.Estudiante> Estudiante { get; set; } = default!;
    }
}

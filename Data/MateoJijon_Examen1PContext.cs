using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MateoJijon_Examen1P.Models;

namespace MateoJijon_Examen1P.Data
{
    public class MateoJijon_Examen1PContext : DbContext
    {
        public MateoJijon_Examen1PContext (DbContextOptions<MateoJijon_Examen1PContext> options)
            : base(options)
        {
        }

        public DbSet<MateoJijon_Examen1P.Models.Paciente> Paciente { get; set; } = default!;
    }
}

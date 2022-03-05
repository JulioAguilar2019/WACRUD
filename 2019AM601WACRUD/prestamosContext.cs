using _2019AM601WACRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace _2019AM601WACRUD
{
    public class prestamosContext : DbContext
    {
        public prestamosContext(DbContextOptions<prestamosContext> options) : base(options)
        {

        }

        public DbSet<equipos> equipos { get; set; }
        public DbSet<marca> marcas { get; set; }
        public DbSet<estados_equipo> estados_equipo { get; set; }
        public DbSet<tipo_equipo> tipo_equipo { get; set; }
    }
}

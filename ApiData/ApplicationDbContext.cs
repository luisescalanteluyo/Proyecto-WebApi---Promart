using ApiEntitty;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiData
{
   public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // El connectionString debe venir de un archivo de configuraciones!
            optionsBuilder.UseSqlServer("Data Source=luis-pc\\sqlexpress; Initial Catalog=BD_PROM; User Id=sa; Password=lindaluana");
               // .EnableSensitiveDataLogging(true);
     //           .UseLoggerFactory(new LoggerFactory().AddProvider( (category, level) => level == LogLevel.Information && category == DbLoggerCategory.Database.Command.Name, true));
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Agregamos una llave compuesta para tabla EstudiantesCursos
            modelBuilder.Entity<employees>().HasKey(x => new { x.id });

            // Filtro por tipo
            //  modelBuilder.Entity<EstudianteCurso>().HasQueryFilter(x => x.Activo == true);

           /* // Table splitting
            modelBuilder.Entity<Estudiante>().HasOne(x => x.Detalles)
                .WithOne(x => x.Estudiante)
                .HasForeignKey<EstudianteDetalle>(x => x.Id);
            modelBuilder.Entity<EstudianteDetalle>().ToTable("Estudiantes");

            // Mapeo Flexible
            modelBuilder.Entity<Estudiante>().Property(x => x.Apellido).HasField("_Apellido");*/
        }
        

        /*
        public override int SaveChanges()
        {
            // Borrado Suave
            foreach (var item in ChangeTracker.Entries()
            .Where(e => e.State == EntityState.Deleted &&
               e.Metadata.GetProperties().Any(x => x.Name == "EstaBorrado")))
            {
                item.State = EntityState.Unchanged;
                item.CurrentValues["EstaBorrado"] = true;
            }

            return base.SaveChanges();
        } */
          
        public DbSet<employees> tb_employees { get; set; }
       

        [DbFunction(Schema = "dbo")]
        public static int Cantidad_De_Cursos_Activos(int EstudianteId)
        {
            throw new Exception();
        }


    }
}

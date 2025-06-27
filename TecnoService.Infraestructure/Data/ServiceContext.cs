using Microsoft.EntityFrameworkCore;
using System.Data;
using TecnoService.Core.Models;

namespace TecnoService.Infraestructure.Data
{
    public class ServiceContext : DbContext
    {
        public ServiceContext(DbContextOptions<ServiceContext> options) : base(options) { }

        
        public DbSet<MarcaModel>Marcas {get;set;}

        public DbSet<DispositivoModel>Dispositivos{get;set;}

        public DbSet<PersonaModel>Personas{get;set;}

        public DbSet<ClienteModel>Clientes{get;set;}

        public DbSet<TrabajadorModel>Trabajadores{get;set;}

        public DbSet<InDisModel>Ingreso{get;set;}

        public DbSet<FacturaModel>Facturas{get;set;}


        protected override void OnModelCreating (ModelBuilder modelB)
        {
            modelB.Entity<ClienteModel>()
                .HasOne(c => c.Persona)
                .WithOne(p => p.Cleinte)
                .HasForeignKey<ClienteModel>(c => c.IDPersona);

            modelB.Entity<TrabajadorModel>()
                .HasOne(t => t.Persona)
                .WithOne(p => p.Trabajador)
                .HasForeignKey<TrabajadorModel>(t => t.IDPersona);

            modelB.Entity<DispositivoModel>()
                .HasOne(d => d.Marca)
                .WithMany(m => m.Dispositivos)
                .HasForeignKey(d => d.IDMarca);

            modelB.Entity<InDisModel>()
                .HasOne(i => i.Cliente)
                .WithMany(c => c.Ingreso)
                .HasForeignKey(i => i.IDDispositivo);

            modelB.Entity<InDisModel>()
                .HasOne(i => i.Dispositivo)
                .WithMany(d => d.Ingreso)
                .HasForeignKey(i => i.IDDispositivo);

            modelB.Entity<FacturaModel>()
                .HasOne(f => f.ingreso)
                .WithOne(i => i.Factura)
                .HasForeignKey<FacturaModel>(f => f.IDInDis);

            modelB.Entity<FacturaModel>()
                .HasOne(f => f.Trabajador)
                .WithMany(t => t.Facturas)
                .HasForeignKey(f => f.IDTrabajador);

            base.OnModelCreating(modelB);
        }

    }
}

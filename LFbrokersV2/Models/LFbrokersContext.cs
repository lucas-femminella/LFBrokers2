using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace LFbrokersV2.Models
{
    public partial class LFbrokersContext : DbContext
    {
        public LFbrokersContext()
        {
        }

        public LFbrokersContext(DbContextOptions<LFbrokersContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Aseguradora> Aseguradora { get; set; }
        public virtual DbSet<CodigoPostal> CodigoPostal { get; set; }
        public virtual DbSet<Especialidad> Especialidad { get; set; }
        public virtual DbSet<EspecialidadCliente> EspecialidadCliente { get; set; }
        public virtual DbSet<EspecialidadesCubiertas> EspecialidadesCubiertas { get; set; }
        public virtual DbSet<EspecialidadPrimaPorSuma> EspecialidadPrimaPorSuma { get; set; }
        public virtual DbSet<LiquidacionAseguradora> LiquidacionAseguradora { get; set; }
        public virtual DbSet<LiquidacionPolizaCuota> LiquidacionPolizaCuota { get; set; }
        public virtual DbSet<Localidad> Localidad { get; set; }
        public virtual DbSet<OpcionesCotizacion> OpcionesCotizacion { get; set; }
        public virtual DbSet<Persona> Persona { get; set; }
        public virtual DbSet<Poliza> Poliza { get; set; }
        public virtual DbSet<Producto> Producto { get; set; }
        public virtual DbSet<ProductoAseguradora> ProductoAseguradora { get; set; }
        public virtual DbSet<Provincia> Provincia { get; set; }
        public virtual DbSet<Ramo> Ramo { get; set; }
        public virtual DbSet<RecargoCuotas> RecargoCuotas { get; set; }
        public virtual DbSet<Zona> Zona { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=lfemminella;Database=LFbrokers;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aseguradora>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<CodigoPostal>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CodigoPostal1)
                    .IsRequired()
                    .HasColumnName("CodigoPostal")
                    .HasMaxLength(10);

                entity.HasOne(d => d.LocalidadNavigation)
                    .WithMany(p => p.CodigoPostal)
                    .HasForeignKey(d => d.Localidad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CodigoPostal_Localidad");

                entity.HasOne(d => d.ZonaNavigation)
                    .WithMany(p => p.CodigoPostal)
                    .HasForeignKey(d => d.Zona)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CodigoPostal_Zona");
            });

            modelBuilder.Entity<Especialidad>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<EspecialidadCliente>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.EspecialidadNavigation)
                    .WithMany(p => p.EspecialidadCliente)
                    .HasForeignKey(d => d.Especialidad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EspecialidadCliente_Especialidad");
            });

            modelBuilder.Entity<EspecialidadesCubiertas>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.EspecialidadNavigation)
                    .WithMany(p => p.EspecialidadesCubiertas)
                    .HasForeignKey(d => d.Especialidad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EspecialidadesCubiertas_Especialidad");

                entity.HasOne(d => d.PolizaNavigation)
                    .WithMany(p => p.EspecialidadesCubiertas)
                    .HasForeignKey(d => d.Poliza)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EspecialidadesCubiertas_Poliza");
            });

            modelBuilder.Entity<EspecialidadPrimaPorSuma>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.EspecialidadCodigoExterno)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.PrimaBase).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PrimaVigenteDesde).HasColumnType("date");

                entity.Property(e => e.SumaAsegurada).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.EspecialidadNavigation)
                    .WithMany(p => p.EspecialidadPrimaPorSuma)
                    .HasForeignKey(d => d.Especialidad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EspecialidadPrimaPorSuma_Especialidad");

                entity.HasOne(d => d.ProductoAseguradoraNavigation)
                    .WithMany(p => p.EspecialidadPrimaPorSuma)
                    .HasForeignKey(d => d.ProductoAseguradora)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EspecialidadPrimaPorSuma_ProductoAseguradora");
            });

            modelBuilder.Entity<LiquidacionAseguradora>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.FechaFin).HasColumnType("date");

                entity.Property(e => e.FechaInicio).HasColumnType("date");

                entity.Property(e => e.Monto).HasColumnType("decimal(16, 2)");

                entity.HasOne(d => d.AseguradoraNavigation)
                    .WithMany(p => p.LiquidacionAseguradora)
                    .HasForeignKey(d => d.Aseguradora)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LiquidacionAseguradora_Aseguradora");
            });

            modelBuilder.Entity<LiquidacionPolizaCuota>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Monto).HasColumnType("decimal(16, 2)");

                entity.HasOne(d => d.LiquidacionAseguradoraNavigation)
                    .WithMany(p => p.LiquidacionPolizaCuota)
                    .HasForeignKey(d => d.LiquidacionAseguradora)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LiquidacionPolizaCuota_LiquidacionAseguradora");

                entity.HasOne(d => d.PolizaNavigation)
                    .WithMany(p => p.LiquidacionPolizaCuota)
                    .HasForeignKey(d => d.Poliza)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LiquidacionPolizaCuota_Poliza");
            });

            modelBuilder.Entity<Localidad>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Localidad1)
                    .IsRequired()
                    .HasColumnName("Localidad")
                    .HasMaxLength(50);

                entity.HasOne(d => d.ProvinciaNavigation)
                    .WithMany(p => p.Localidad)
                    .HasForeignKey(d => d.Provincia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Localidad_Provincia");
            });

            modelBuilder.Entity<OpcionesCotizacion>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ComisionPrima).HasColumnType("decimal(2, 2)");

                entity.Property(e => e.Condicion).HasMaxLength(50);

                entity.Property(e => e.PremioCuota).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PremioTotal).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PrimaBase).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PrimaPoliza).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.RecargoPrima)
                    .HasColumnName("RecargoPrima%")
                    .HasColumnType("decimal(2, 2)");

                entity.Property(e => e.SumaAsegurada).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.PolizaNavigation)
                    .WithMany(p => p.OpcionesCotizacion)
                    .HasForeignKey(d => d.Poliza)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OpcionesCotizacion_Poliza");
            });

            modelBuilder.Entity<Persona>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Apellidos)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Calle)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Celular).HasMaxLength(50);

                entity.Property(e => e.Departamento).HasMaxLength(10);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FechaNacimiento).HasColumnType("date");

                entity.Property(e => e.Nombres)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NroDocumento)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Telefono).HasMaxLength(50);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TipoDocumento)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.CodigoPostalNavigation)
                    .WithMany(p => p.Persona)
                    .HasForeignKey(d => d.CodigoPostal)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Persona_CodigoPostal");
            });

            modelBuilder.Entity<Poliza>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ComisionPrima).HasColumnType("decimal(2, 2)");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Impuestos).HasColumnType("decimal(2, 2)");

                entity.Property(e => e.Matricula).HasMaxLength(50);

                entity.Property(e => e.NumeroPoliza).HasMaxLength(50);

                entity.Property(e => e.PremioCuota).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PremioTotal).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PrimaBase).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PrimaPoliza).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.RecargoPrima)
                    .HasColumnName("RecargoPrima%")
                    .HasColumnType("decimal(2, 2)");

                entity.Property(e => e.RecargosFinancieros).HasColumnType("decimal(2, 2)");

                entity.Property(e => e.SumaAsegurada).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.VigenciaDesde).HasColumnType("date");

                entity.Property(e => e.VigenciaHasta).HasColumnType("date");

                entity.HasOne(d => d.AgenteNavigation)
                    .WithMany(p => p.PolizaAgenteNavigation)
                    .HasForeignKey(d => d.Agente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Poliza_Persona1");

                entity.HasOne(d => d.ClienteNavigation)
                    .WithMany(p => p.PolizaClienteNavigation)
                    .HasForeignKey(d => d.Cliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Poliza_Persona");
            });

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Producto1)
                    .IsRequired()
                    .HasColumnName("Producto")
                    .HasMaxLength(50);

                entity.HasOne(d => d.RamoNavigation)
                    .WithMany(p => p.Producto)
                    .HasForeignKey(d => d.Ramo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Producto_Ramo");
            });

            modelBuilder.Entity<ProductoAseguradora>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ComisionPrimaBase).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.AseguradoraNavigation)
                    .WithMany(p => p.ProductoAseguradora)
                    .HasForeignKey(d => d.Aseguradora)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductoAseguradora_Aseguradora");

                entity.HasOne(d => d.ProductoNavigation)
                    .WithMany(p => p.ProductoAseguradora)
                    .HasForeignKey(d => d.Producto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductoAseguradora_Producto");
            });

            modelBuilder.Entity<Provincia>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Provincia1)
                    .IsRequired()
                    .HasColumnName("Provincia")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Ramo>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Ramo1)
                    .IsRequired()
                    .HasColumnName("Ramo")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<RecargoCuotas>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.RecargoFinanciero).HasColumnType("decimal(16, 2)");

                entity.HasOne(d => d.AseguradoraNavigation)
                    .WithMany(p => p.RecargoCuotas)
                    .HasForeignKey(d => d.Aseguradora)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RecargoCuotas_Aseguradora");
            });

            modelBuilder.Entity<Zona>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Impuesto).HasColumnType("decimal(2, 2)");

                entity.Property(e => e.Zona1)
                    .IsRequired()
                    .HasColumnName("Zona")
                    .HasMaxLength(50);
            });
        }
    }
}

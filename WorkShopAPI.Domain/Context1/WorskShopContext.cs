using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WorkShopAPI.Domain.Context;

public partial class WorskShopContext : DbContext
{
    public WorskShopContext()
    {
    }

    public WorskShopContext(DbContextOptions<WorskShopContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AppSession> AppSessions { get; set; }

    public virtual DbSet<CitaServicio> CitaServicios { get; set; }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Evaluacion> Evaluacions { get; set; }

    public virtual DbSet<Factura> Facturas { get; set; }

    public virtual DbSet<FotografiaVehiculo> FotografiaVehiculos { get; set; }

    public virtual DbSet<Mecanico> Mecanicos { get; set; }

    public virtual DbSet<Repuesto> Repuestos { get; set; }

    public virtual DbSet<RepuestoEvaluacion> RepuestoEvaluacions { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    public virtual DbSet<Vehiculo> Vehiculos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-65KGTR8;Database=WorskShop;Trusted_Connection=True; TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AppSession>(entity =>
        {
            entity.ToTable("AppSession");

            entity.Property(e => e.Session)
                .IsUnicode(false)
                .HasColumnName("session");
        });

        modelBuilder.Entity<CitaServicio>(entity =>
        {
            entity.HasKey(e => e.CitaId);

            entity.ToTable("CitaServicio");

            entity.Property(e => e.CitaId).HasColumnName("CitaID");
            entity.Property(e => e.FechaProgramada).HasColumnType("datetime");
            entity.Property(e => e.FechaSolicitud).HasColumnType("datetime");
            entity.Property(e => e.MecanicoId).HasColumnName("MecanicoID");
            entity.Property(e => e.VehiculoId).HasColumnName("VehiculoID");
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.ToTable("Cliente");

            entity.Property(e => e.ClienteId).HasColumnName("ClienteID");
            entity.Property(e => e.Apellidos)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Celular)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Correo).IsUnicode(false);
            entity.Property(e => e.Documento)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Nombres)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PresupuestoMaximo).IsUnicode(false);
        });

        modelBuilder.Entity<Evaluacion>(entity =>
        {
            entity.ToTable("Evaluacion");

            entity.Property(e => e.EvaluacionId).HasColumnName("EvaluacionID");
            entity.Property(e => e.CitaId).HasColumnName("CitaID");
            entity.Property(e => e.CostoManoObra).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DescripcionDanios).IsUnicode(false);
            entity.Property(e => e.TiempoEstimado).HasColumnType("datetime");
        });

        modelBuilder.Entity<Factura>(entity =>
        {
            entity.ToTable("Factura");

            entity.Property(e => e.FacturaId).HasColumnName("FacturaID");
            entity.Property(e => e.EvaluacionId).HasColumnName("EvaluacionID");
            entity.Property(e => e.FechaEmision).HasColumnType("datetime");
            entity.Property(e => e.Iva)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("IVA");
            entity.Property(e => e.Subtotal).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<FotografiaVehiculo>(entity =>
        {
            entity.HasKey(e => e.FotoId);

            entity.ToTable("FotografiaVehiculo");

            entity.Property(e => e.FotoId).HasColumnName("FotoID");
            entity.Property(e => e.FechaCarga).HasColumnType("datetime");
            entity.Property(e => e.Foto).IsUnicode(false);
            entity.Property(e => e.VehiculoId).HasColumnName("VehiculoID");
        });

        modelBuilder.Entity<Mecanico>(entity =>
        {
            entity.ToTable("Mecanico");

            entity.Property(e => e.MecanicoId).HasColumnName("MecanicoID");
            entity.Property(e => e.Apellidos)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Especialidad)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.VehiculoId).HasColumnName("VehiculoID");
        });

        modelBuilder.Entity<Repuesto>(entity =>
        {
            entity.ToTable("Repuesto");

            entity.Property(e => e.RepuestoId).HasColumnName("RepuestoID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PrecioUnitario).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<RepuestoEvaluacion>(entity =>
        {
            entity.HasKey(e => e.IdRepEval);

            entity.ToTable("RepuestoEvaluacion");

            entity.Property(e => e.EvaluacionId).HasColumnName("EvaluacionID");
            entity.Property(e => e.RepuestoId).HasColumnName("RepuestoID");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario);

            entity.ToTable("Usuario");

            entity.Property(e => e.ClienteId).HasColumnName("ClienteID");
            entity.Property(e => e.Contrasenia).IsUnicode(false);
            entity.Property(e => e.Usuario1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Usuario");
        });

        modelBuilder.Entity<Vehiculo>(entity =>
        {
            entity.ToTable("Vehiculo");

            entity.Property(e => e.VehiculoId).HasColumnName("VehiculoID");
            entity.Property(e => e.Año)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.ClienteId).HasColumnName("ClienteID");
            entity.Property(e => e.Color)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Marca)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Modelo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Placa)
                .HasMaxLength(6)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

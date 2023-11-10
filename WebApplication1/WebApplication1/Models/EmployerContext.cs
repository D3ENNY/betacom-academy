using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models;

public partial class EmployerContext : DbContext
{
    public EmployerContext()
    {
    }

    public EmployerContext(DbContextOptions<EmployerContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AnagraficaGenerale> AnagraficaGenerales { get; set; }

    public virtual DbSet<AttivitaDipendenti> AttivitaDipendentis { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AnagraficaGenerale>(entity =>
        {
            entity.HasKey(e => e.Matricola);

            entity.ToTable("AnagraficaGenerale");

            entity.Property(e => e.Matricola)
                .HasMaxLength(4)
                .IsFixedLength();
            entity.Property(e => e.Cap)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("CAP");
            entity.Property(e => e.Citta)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Indirizzo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nominativo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Provincia)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Reparto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ruolo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Telefono)
                .HasMaxLength(15)
                .IsFixedLength();
        });

        modelBuilder.Entity<AttivitaDipendenti>(entity =>
        {
            entity.ToTable("AttivitaDipendenti");

            entity.Property(e => e.Attivita)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DataAttivita).HasColumnType("datetime");
            entity.Property(e => e.Matricola)
                .HasMaxLength(4)
                .IsFixedLength();
            entity.Property(e => e.Ore).HasColumnType("numeric(10, 2)");

            entity.HasOne(d => d.MatricolaNavigation).WithMany(p => p.AttivitaDipendentis).HasForeignKey(d => d.Matricola);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

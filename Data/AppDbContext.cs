using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using WebGIS.Models;

namespace WebGIS.Data;

public partial class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<Commune> Communes { get; set; }

    public virtual DbSet<Gestionnaire> Gestionnaires { get; set; }

    public virtual DbSet<Population> Populations { get; set; }

    public virtual DbSet<Site> Sites { get; set; }

    public virtual DbSet<Voirie> Voiries { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasPostgresExtension("postgis");

        modelBuilder.Entity<Client>(entity =>
        {
            entity.HasKey(e => e.id).HasName("Client_pkey");
        });

        modelBuilder.Entity<Commune>(entity =>
        {
            entity.HasKey(e => e.id).HasName("Communes_pkey");

            entity.HasIndex(e => e.geom, "sidx_Communes_geom").HasMethod("gist");
        });

        modelBuilder.Entity<Gestionnaire>(entity =>
        {
            entity.HasKey(e => e.id).HasName("Gestionnaire_pkey");
        });

        modelBuilder.Entity<Population>(entity =>
        {
            entity.HasKey(e => e.id).HasName("Population_pkey");

            entity.HasIndex(e => e.geom, "sidx_Population_geom").HasMethod("gist");
        });

        modelBuilder.Entity<Site>(entity =>
        {
            entity.HasKey(e => e.id).HasName("Site_pkey");

            entity.HasIndex(e => e.geom, "sidx_Site_geom").HasMethod("gist");
        });

        modelBuilder.Entity<Voirie>(entity =>
        {
            entity.HasKey(e => e.id).HasName("Voirie_pkey");

            entity.HasIndex(e => e.geom, "sidx_Voirie_geom").HasMethod("gist");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

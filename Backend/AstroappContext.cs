using System;
using System.Collections.Generic;
using AstroApp.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend;

public partial class AstroappContext : DbContext
{
    public AstroappContext()
    {
    }

    public AstroappContext(DbContextOptions<AstroappContext> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("name=BackendDatabase");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    public DbSet<Photo> Photos {get;set;}
    public DbSet<MetaData> MetaData {get; set;}
}

using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Template.CleanArchitecture.Application.Contracts;
using Template.CleanArchitecture.Domain.Entities;

namespace Template.CleanArchitecture.Presistance.Context;

public partial class DatabaseService : DbContext, IDatabaseService
{
    public DatabaseService()
    {
    }

    public DatabaseService(DbContextOptions<DatabaseService> options)
        : base(options)
    {
    }

    public virtual DbSet<PhoneNumberTypes> PhoneNumberTypes { get; set; }

    public virtual DbSet<PhoneNumbers> PhoneNumbers { get; set; }

    public virtual DbSet<Users> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=.;Initial Catalog=SQlDBPhoneBook;Integrated Security=true;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<PhoneNumberTypes>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<PhoneNumbers>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<Users>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

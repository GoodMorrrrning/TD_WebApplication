﻿using KeDalle.Model;
using Microsoft.EntityFrameworkCore;
using System;

namespace KeDalle
{
    public interface IEpsiContext
    {
        DbSet<Etudiant> etudiants { get; set; }
        DbSet<DEVOIRS> devs { get; set; }

        int SaveChanges();
    }

    public class Context : DbContext, IEpsiContext
    {
        public DbSet<Etudiant> etudiants { get; set; }
        public DbSet<DEVOIRS> devs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=tcp:epsi-gury.database.windows.net,1433;Database=Martin;User ID=mathieu;Password=epsi-gury-2020;MultipleActiveResultSets=True;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}

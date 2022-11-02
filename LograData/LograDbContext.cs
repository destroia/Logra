using LograModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LograData
{
    public class LograDbContext :DbContext
    {
       public LograDbContext(DbContextOptions<LograDbContext> options) : base(options)
       {

       }
       protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
       {
            optionsBuilder.UseSqlServer(

             "Server=tcp:lograserver.database.windows.net,1433;Initial Catalog=DB_Logra;Persist Security Info=False;User ID=logra_admin;Password=DavidStivenQwerty#!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            base.OnConfiguring(optionsBuilder);
           //Primer Migracion   Add-Migration InitialCreate
           //Despues de la primera migracion se utiliza  Update-Database
       }

        
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Garden> Gardens { get; set; }
        public DbSet<Instutition> Instutitions { get; set; }
        public DbSet<Mood> Moods { get; set; }
        public DbSet<Prueba> pruebas { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Word> Words { get; set; }
    }
}

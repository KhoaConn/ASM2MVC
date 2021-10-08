using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ASM2MVC.EF
{
    public class SystemContext : DbContext
    {
        public SystemContext() : base("FPTConnection")
        {
        }


        public DbSet<CourseEntity> Courses { get; set; }
        public DbSet<TopicEntity> Topics { get; set; }
        public DbSet<MTrainerEntity> MTrainers { get; set; }
        public DbSet<MTraineeEntity> MTrainees { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CourseEntity>()
                        .ToTable("Courses"); 

            modelBuilder.Entity<CourseEntity>()
                        .HasKey<int>(c => c.Id);  

            
            modelBuilder.Entity<CourseEntity>()
                        .Property(c => c.CourseName)
                        .HasColumnType("varchar")   
                        .HasMaxLength(50);
            modelBuilder.Entity<CourseEntity>()
                        .Property(c => c.CourseCategory)
                        .HasColumnType("varchar")
                        .HasMaxLength(50);
            modelBuilder.Entity<CourseEntity>()
                        .Property(c => c.Description)
                        .HasColumnType("varchar")
                        .HasMaxLength(50);

            //Topic table

            modelBuilder.Entity<TopicEntity>()
                        .ToTable("Topics"); 

            modelBuilder.Entity<TopicEntity>()
                        .HasKey<int>(t => t.Id); 

            
            modelBuilder.Entity<TopicEntity>()
                        .Property(t => t.TopicName)
                        .HasColumnType("varchar")   
                        .HasMaxLength(50);
            modelBuilder.Entity<TopicEntity>()
                        .Property(t => t.Description)
                        .HasColumnType("varchar")   
                        .HasMaxLength(50);

            //MTrainer table

            modelBuilder.Entity<MTrainerEntity>()
                        .ToTable("MTrainers"); 

            modelBuilder.Entity<MTrainerEntity>()
                        .HasKey<int>(s => s.Id);  

           
            modelBuilder.Entity<MTrainerEntity>()
                        .Property(g => g.TrainerName)
                        .HasColumnType("varchar")   
                        .HasMaxLength(50);
            modelBuilder.Entity<MTrainerEntity>()
                        .Property(g => g.WorkingPlace)
                        .HasColumnType("varchar")  
                        .HasMaxLength(50);
            modelBuilder.Entity<MTrainerEntity>()
                        .Property(g => g.Email)
                        .HasColumnType("varchar")   
                        .HasMaxLength(50);

            //MTrainee table

            modelBuilder.Entity<MTraineeEntity>()
                        .ToTable("MTrainees");

            modelBuilder.Entity<MTraineeEntity>()
                        .HasKey<int>(s => s.Id);


            modelBuilder.Entity<MTraineeEntity>()
                        .Property(s => s.TraineeName)
                        .HasColumnType("varchar")
                        .HasMaxLength(50);
            modelBuilder.Entity<MTraineeEntity>()
                        .Property(s => s.UserName)
                        .HasColumnType("varchar")
                        .HasMaxLength(50);
            modelBuilder.Entity<MTraineeEntity>()
                        .Property(s => s.DOB)
                        .HasColumnType("varchar")
                        .HasMaxLength(50);
            modelBuilder.Entity<MTraineeEntity>()
                        .Property(s => s.Mainlanguage)
                        .HasColumnType("varchar")
                        .HasMaxLength(50);
            modelBuilder.Entity<MTraineeEntity>()
                        .Property(s => s.Department)
                        .HasColumnType("varchar")
                        .HasMaxLength(50);
            modelBuilder.Entity<MTraineeEntity>()
                        .Property(s => s.Location)
                        .HasColumnType("varchar")
                        .HasMaxLength(50);


        }
    }
}
    

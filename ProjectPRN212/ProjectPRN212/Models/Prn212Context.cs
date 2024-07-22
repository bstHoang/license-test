using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ProjectPRN212.Models;

public partial class Prn212Context : DbContext
{
    public Prn212Context()
    {
    }

    public Prn212Context(DbContextOptions<Prn212Context> options)
        : base(options)
    {
    }

    public virtual DbSet<ExamHistory> ExamHistories { get; set; }

    public virtual DbSet<ListQuestion> ListQuestions { get; set; }

    public virtual DbSet<Question> Questions { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<TypeOfLicense> TypeOfLicenses { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var builder = new ConfigurationBuilder()
                              .SetBasePath(Directory.GetCurrentDirectory())
                              .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
        IConfigurationRoot configuration = builder.Build();
        optionsBuilder.UseSqlServer(configuration.GetConnectionString("MyCnn"));
    }
   protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ExamHistory>(entity =>
        {
            entity.ToTable("ExamHistory");

            entity.Property(e => e.ExamHistoryId)
                .ValueGeneratedOnAdd()
                .HasColumnName("ExamHistory_Id");
            entity.Property(e => e.ExamTime).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasColumnName("User_id");

            entity.HasOne(d => d.User).WithMany(p => p.ExamHistories)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_ExamHistory_User1");
        });

        modelBuilder.Entity<ListQuestion>(entity =>
        {
            entity.ToTable("ListQuestion"); 

            entity.HasKey(e => e.ListQuestion_Id); 

            entity.Property(e => e.ListQuestion_Id).HasColumnName("ListQuestion_Id").ValueGeneratedOnAdd();

            entity.Property(e => e.ExamHistoryId).HasColumnName("ExamHistory_Id");
            entity.Property(e => e.QuestionId).HasColumnName("Question_Id");
            entity.Property(e => e.YourAnser).HasColumnName("Your_Anser");

            entity.HasOne(d => d.ExamHistory)
                .WithMany()
                .HasForeignKey(d => d.ExamHistoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ListQuestion_ExamHistory");

            entity.HasOne(d => d.Question)
                .WithMany()
                .HasForeignKey(d => d.QuestionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ListQuestion_Question");
        });


        modelBuilder.Entity<Question>(entity =>
        {
            entity.ToTable("Question");

            entity.Property(e => e.QuestionId).HasColumnName("Question_Id");
            entity.Property(e => e.LicenseId).HasColumnName("License_Id");
            entity.Property(e => e.Question1).HasColumnName("Question");

            entity.HasOne(d => d.License).WithMany(p => p.Questions)
                .HasForeignKey(d => d.LicenseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Question_TypeOfLicense");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.ToTable("Role");

            entity.Property(e => e.RoleId).HasColumnName("Role_Id");
            entity.Property(e => e.RoleName).HasColumnName("Role_Name");
        });

        modelBuilder.Entity<TypeOfLicense>(entity =>
        {
            entity.HasKey(e => e.LicenseId);

            entity.ToTable("TypeOfLicense");

            entity.Property(e => e.LicenseId).HasColumnName("License_Id");
            entity.Property(e => e.LicenseName).HasColumnName("License_name");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.ToTable("User");

            entity.Property(e => e.UserId).HasColumnName("User_Id");
            entity.Property(e => e.RoleId).HasColumnName("Role_Id");
            entity.Property(e => e.UserName).HasColumnName("User_name");

            entity.HasOne(d => d.Role).WithMany(p => p.Users)
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("FK_User_Role");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

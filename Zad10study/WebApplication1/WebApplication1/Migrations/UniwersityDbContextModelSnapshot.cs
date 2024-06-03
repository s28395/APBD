﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.Entities;

#nullable disable

namespace WebApplication1.Migrations
{
    [DbContext(typeof(UniwersityDbContext))]
    partial class UniwersityDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebApplication1.Entities.Group", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.HasKey("Id")
                        .HasName("Group_pk");

                    b.ToTable("Group", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "10c"
                        },
                        new
                        {
                            Id = 2,
                            Name = "30c"
                        });
                });

            modelBuilder.Entity("WebApplication1.Entities.Student", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("IndexNumber")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id")
                        .HasName("Student_pk");

                    b.ToTable("Student", (string)null);
                });

            modelBuilder.Entity("WebApplication1.Entities.StudentGroup", b =>
                {
                    b.Property<int>("IdGroup")
                        .HasColumnType("int");

                    b.Property<int>("IdStudent")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETUTCDATE()");

                    b.HasKey("IdGroup", "IdStudent")
                        .HasName("StudentGruop_pk");

                    b.HasIndex("IdStudent");

                    b.ToTable("StudentGroup", (string)null);
                });

            modelBuilder.Entity("WebApplication1.Entities.StudentGroup", b =>
                {
                    b.HasOne("WebApplication1.Entities.Group", "Group")
                        .WithMany("StudentGroups")
                        .HasForeignKey("IdGroup")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("StudentGroup_Group");

                    b.HasOne("WebApplication1.Entities.Student", "Student")
                        .WithMany("StudentGroups")
                        .HasForeignKey("IdStudent")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("StudentGroup_Student");

                    b.Navigation("Group");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("WebApplication1.Entities.Group", b =>
                {
                    b.Navigation("StudentGroups");
                });

            modelBuilder.Entity("WebApplication1.Entities.Student", b =>
                {
                    b.Navigation("StudentGroups");
                });
#pragma warning restore 612, 618
        }
    }
}

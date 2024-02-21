﻿// <auto-generated />
using System;
using HexaopsNewWebAPP.Database.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HexaopsNewWebAPP.Migrations
{
    [DbContext(typeof(SqlServerContext))]
    partial class SqlServerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HexaopsNewWebAPP.Entities.MainService", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MainServices");
                });

            modelBuilder.Entity("HexaopsNewWebAPP.Entities.MainServiceAssoc", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDated")
                        .HasColumnType("datetime2");

                    b.Property<int>("MainServiceId")
                        .HasColumnType("int");

                    b.Property<string>("ServiceDescripton")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ServiceImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ServiceTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MainServiceId");

                    b.ToTable("MainServiceAssocs");
                });

            modelBuilder.Entity("HexaopsNewWebAPP.Entities.MainServiceAssoc", b =>
                {
                    b.HasOne("HexaopsNewWebAPP.Entities.MainService", "MainService")
                        .WithMany("MainServices")
                        .HasForeignKey("MainServiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MainService");
                });

            modelBuilder.Entity("HexaopsNewWebAPP.Entities.MainService", b =>
                {
                    b.Navigation("MainServices");
                });
#pragma warning restore 612, 618
        }
    }
}

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

            modelBuilder.Entity("HexaopsNewWebAPP.Entites.MainPartner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Slogan")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MainPartners");
                });

            modelBuilder.Entity("HexaopsNewWebAPP.Entites.MainSlider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MainSliders");
                });

            modelBuilder.Entity("HexaopsNewWebAPP.Entities.MainCarousel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Carousel1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Carousel2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDated")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("MainCarousels");
                });

            modelBuilder.Entity("HexaopsNewWebAPP.Entities.MainFAQ", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MainFAQ");
                });

            modelBuilder.Entity("HexaopsNewWebAPP.Entities.MainFAQAssoc", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ContactTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDated")
                        .HasColumnType("datetime2");

                    b.Property<int>("MainFAQId")
                        .HasColumnType("int");

                    b.Property<string>("QuestionDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QuestionTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MainFAQId");

                    b.ToTable("MainFAQAssocs");
                });

            modelBuilder.Entity("HexaopsNewWebAPP.Entities.MainFeatureAssoc", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDated")
                        .HasColumnType("datetime2");

                    b.Property<int>("MainFeaturesId")
                        .HasColumnType("int");

                    b.Property<string>("Smalldescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Smalltitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MainFeaturesId");

                    b.ToTable("MainFeatureAssocs");
                });

            modelBuilder.Entity("HexaopsNewWebAPP.Entities.MainFeatures", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Bigdescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Bigtitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDated")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("MainFeatures");
                });

            modelBuilder.Entity("HexaopsNewWebAPP.Entities.MainFooter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AnimationsLogo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ButtonUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyDescripiton1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyDescription2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyDescription3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyDescription4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyDescription5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDated")
                        .HasColumnType("datetime2");

                    b.Property<string>("FooterCompanyLogo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HelpDescription1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HelpDescription2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HelpSmallTitle1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HelpSmallTitle2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HelpTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HelpUrl1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HelpUrl2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logo1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logo2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logo3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Slogan1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Slogan2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Slogan3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Slogan4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Slogan5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TelifYazısı")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MainFooters");
                });

            modelBuilder.Entity("HexaopsNewWebAPP.Entities.MainPartnerAssoc", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDated")
                        .HasColumnType("datetime2");

                    b.Property<int>("MainPartnerId")
                        .HasColumnType("int");

                    b.Property<string>("PartnerImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MainPartnerId");

                    b.ToTable("MainPartnerAssocs");
                });

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

            modelBuilder.Entity("HexaopsNewWebAPP.Entities.MainSolutions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDated")
                        .HasColumnType("datetime2");

                    b.Property<string>("SolutionsButtonUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SolutionsDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SolutionsImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SolutionsTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MainSolutions");
                });

            modelBuilder.Entity("HexaopsNewWebAPP.Entities.SocialAccount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDated")
                        .HasColumnType("datetime2");

                    b.Property<string>("SocialUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SocialAccounts");
                });

            modelBuilder.Entity("HexaopsNewWebAPP.Entities.MainFAQAssoc", b =>
                {
                    b.HasOne("HexaopsNewWebAPP.Entities.MainFAQ", "MainFAQ")
                        .WithMany("MainFAQAssoc")
                        .HasForeignKey("MainFAQId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MainFAQ");
                });

            modelBuilder.Entity("HexaopsNewWebAPP.Entities.MainFeatureAssoc", b =>
                {
                    b.HasOne("HexaopsNewWebAPP.Entities.MainFeatures", "MainFeatures")
                        .WithMany("FeatureAssocs")
                        .HasForeignKey("MainFeaturesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MainFeatures");
                });

            modelBuilder.Entity("HexaopsNewWebAPP.Entities.MainPartnerAssoc", b =>
                {
                    b.HasOne("HexaopsNewWebAPP.Entites.MainPartner", "MainPartner")
                        .WithMany("MainPartnerAssocs")
                        .HasForeignKey("MainPartnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MainPartner");
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

            modelBuilder.Entity("HexaopsNewWebAPP.Entites.MainPartner", b =>
                {
                    b.Navigation("MainPartnerAssocs");
                });

            modelBuilder.Entity("HexaopsNewWebAPP.Entities.MainFAQ", b =>
                {
                    b.Navigation("MainFAQAssoc");
                });

            modelBuilder.Entity("HexaopsNewWebAPP.Entities.MainFeatures", b =>
                {
                    b.Navigation("FeatureAssocs");
                });

            modelBuilder.Entity("HexaopsNewWebAPP.Entities.MainService", b =>
                {
                    b.Navigation("MainServices");
                });
#pragma warning restore 612, 618
        }
    }
}

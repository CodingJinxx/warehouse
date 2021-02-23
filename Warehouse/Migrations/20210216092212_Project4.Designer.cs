﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Warehouse.Models;

namespace Warehouse.Migrations
{
    [DbContext(typeof(WarehouseContext))]
    [Migration("20210216092212_Project4")]
    partial class Project4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("Warehouse.Models.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("PROJECT_ID");

                    b.Property<string>("Description")
                        .HasColumnType("VARCHAR(255)")
                        .HasColumnName("DESCRIPTION");

                    b.Property<string>("LegalFoundation")
                        .IsRequired()
                        .HasColumnType("VARCHAR(4)")
                        .HasColumnName("LEGAL_FOUNDATION");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)")
                        .HasColumnName("TITLE");

                    b.HasKey("Id");

                    b.ToTable("PROJECTS");
                });

            modelBuilder.Entity("Warehouse.Models.Subproject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("SUBPROJECT_ID");

                    b.Property<bool>("AppliedResearch")
                        .HasColumnType("TINYINT(1)")
                        .HasColumnName("APPLIED_RESEARCH");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("VARCHAR(255)")
                        .HasColumnName("DESCRIPTION");

                    b.Property<bool>("FocusResearch")
                        .HasColumnType("TINYINT(1)")
                        .HasColumnName("FOCUS_RESEARCH");

                    b.Property<bool>("TheoreticalResearch")
                        .HasColumnType("TINYINT(1)")
                        .HasColumnName("THEORETICAL_RESEARCH");

                    b.HasKey("Id");

                    b.ToTable("SUBPROJECTS");
                });

            modelBuilder.Entity("Warehouse.Models.RequestFundingProject", b =>
                {
                    b.HasBaseType("Warehouse.Models.Project");

                    b.Property<bool>("IsSmallProject")
                        .HasColumnType("TINYINT(1)")
                        .HasColumnName("IS_SMALL_PROJECT");

                    b.ToTable("REQUEST_FUNDING_PROJECTS");
                });

            modelBuilder.Entity("Warehouse.Models.ResearchFundingProject", b =>
                {
                    b.HasBaseType("Warehouse.Models.Project");

                    b.Property<bool>("IsEUSponsored")
                        .HasColumnType("TINYINT(1)")
                        .HasColumnName("IS_EU_SPONSORED");

                    b.Property<bool>("IsFFGSponsored")
                        .HasColumnType("TINYINT(1)")
                        .HasColumnName("IS_FFG_SPONSORED");

                    b.Property<bool>("IsFWFSponsored")
                        .HasColumnType("TINYINT(1)")
                        .HasColumnName("IS_FWF_SPONSORED");

                    b.ToTable("RESEARCH_FUNDING_PROJECTS");
                });

            modelBuilder.Entity("Warehouse.Models.RequestFundingProject", b =>
                {
                    b.HasOne("Warehouse.Models.Project", null)
                        .WithOne()
                        .HasForeignKey("Warehouse.Models.RequestFundingProject", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Warehouse.Models.ResearchFundingProject", b =>
                {
                    b.HasOne("Warehouse.Models.Project", null)
                        .WithOne()
                        .HasForeignKey("Warehouse.Models.ResearchFundingProject", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

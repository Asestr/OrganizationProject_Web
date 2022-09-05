﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OrganizationAccsessLayer.Concrete;

#nullable disable

namespace OrganizationAccsessLayer.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20220903155218_manytomanyandonetomany")]
    partial class manytomanyandonetomany
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("OrganizationEntityLayer.Event.Category", b =>
                {
                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("CategoryName");

                    b.ToTable("Categorys");
                });

            modelBuilder.Entity("OrganizationEntityLayer.Event.City", b =>
                {
                    b.Property<string>("CityName")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("CityName");

                    b.ToTable("Citys");
                });

            modelBuilder.Entity("OrganizationEntityLayer.Event.Event", b =>
                {
                    b.Property<int>("EventId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EventId"), 1L, 1);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryName1")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CityName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CityName1")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("EventAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EventExplanation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EventName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EventQuota")
                        .HasColumnType("int");

                    b.Property<DateTime>("EventRecourseOverTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EventStartTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("EventTickedOrNotTicked")
                        .HasColumnType("bit");

                    b.HasKey("EventId");

                    b.HasIndex("CategoryName1");

                    b.HasIndex("CityName1");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("OrganizationEntityLayer.Event.SubconEvent", b =>
                {
                    b.Property<int>("EventId")
                        .HasColumnType("int");

                    b.Property<string>("SubcontractorMail")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("EventId", "SubcontractorMail");

                    b.HasIndex("SubcontractorMail");

                    b.ToTable("SubconEvents");
                });

            modelBuilder.Entity("OrganizationEntityLayer.User.Admin", b =>
                {
                    b.Property<string>("AdminId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AdminMail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdminPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AdminId");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("OrganizationEntityLayer.User.CompanyRegistration", b =>
                {
                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CompanyDomain")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyPasswordRepeat")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CompanyName");

                    b.ToTable("CompanyRegistrations");
                });

            modelBuilder.Entity("OrganizationEntityLayer.User.Organizer", b =>
                {
                    b.Property<string>("OrganizerMail")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("OrganizerId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrganizerLastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrganizerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrganizerPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrganizerPasswordRepeat")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OrganizerMail");

                    b.ToTable("Organizers");
                });

            modelBuilder.Entity("OrganizationEntityLayer.User.Subcontractor", b =>
                {
                    b.Property<string>("SubcontractorMail")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("SubcontractorLastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubcontractorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubcontractorPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubcontractorPasswordRepeat")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SubcontractorMail");

                    b.ToTable("Subcontractors");
                });

            modelBuilder.Entity("OrganizationEntityLayer.Event.Event", b =>
                {
                    b.HasOne("OrganizationEntityLayer.Event.Category", "category")
                        .WithMany("Events")
                        .HasForeignKey("CategoryName1");

                    b.HasOne("OrganizationEntityLayer.Event.City", "city")
                        .WithMany("Events")
                        .HasForeignKey("CityName1");

                    b.Navigation("category");

                    b.Navigation("city");
                });

            modelBuilder.Entity("OrganizationEntityLayer.Event.SubconEvent", b =>
                {
                    b.HasOne("OrganizationEntityLayer.Event.Event", "Event")
                        .WithMany("SubconEvents")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OrganizationEntityLayer.User.Subcontractor", "Subcontractor")
                        .WithMany("SubconEvents")
                        .HasForeignKey("SubcontractorMail")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Event");

                    b.Navigation("Subcontractor");
                });

            modelBuilder.Entity("OrganizationEntityLayer.Event.Category", b =>
                {
                    b.Navigation("Events");
                });

            modelBuilder.Entity("OrganizationEntityLayer.Event.City", b =>
                {
                    b.Navigation("Events");
                });

            modelBuilder.Entity("OrganizationEntityLayer.Event.Event", b =>
                {
                    b.Navigation("SubconEvents");
                });

            modelBuilder.Entity("OrganizationEntityLayer.User.Subcontractor", b =>
                {
                    b.Navigation("SubconEvents");
                });
#pragma warning restore 612, 618
        }
    }
}
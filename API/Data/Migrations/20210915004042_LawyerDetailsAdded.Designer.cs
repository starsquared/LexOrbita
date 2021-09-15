﻿// <auto-generated />
using System;
using API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace API.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210915004042_LawyerDetailsAdded")]
    partial class LawyerDetailsAdded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.8");

            modelBuilder.Entity("API.Entities.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AddressLine1")
                        .HasColumnType("TEXT");

                    b.Property<string>("AddressLine2")
                        .HasColumnType("TEXT");

                    b.Property<string>("AppUserType")
                        .HasColumnType("TEXT");

                    b.Property<string>("City")
                        .HasColumnType("TEXT");

                    b.Property<string>("Country")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Introduction")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("LastActive")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("BLOB");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("BLOB");

                    b.Property<string>("Phone")
                        .HasColumnType("TEXT");

                    b.Property<string>("State")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserName")
                        .HasColumnType("TEXT");

                    b.Property<string>("ZipCode")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("API.Entities.Interest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AppUserId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Interest1")
                        .HasColumnType("TEXT");

                    b.Property<string>("Interest10")
                        .HasColumnType("TEXT");

                    b.Property<string>("Interest2")
                        .HasColumnType("TEXT");

                    b.Property<string>("Interest3")
                        .HasColumnType("TEXT");

                    b.Property<string>("Interest4")
                        .HasColumnType("TEXT");

                    b.Property<string>("Interest5")
                        .HasColumnType("TEXT");

                    b.Property<string>("Interest6")
                        .HasColumnType("TEXT");

                    b.Property<string>("Interest7")
                        .HasColumnType("TEXT");

                    b.Property<string>("Interest8")
                        .HasColumnType("TEXT");

                    b.Property<string>("Interest9")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.ToTable("UserInterests");
                });

            modelBuilder.Entity("API.Entities.LawyerDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AppUserId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("BarCouncilRegisteredAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("BarCouncilRegistrationUrl")
                        .HasColumnType("TEXT");

                    b.Property<string>("CorporateExperience")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateLawDegreeObtained")
                        .HasColumnType("TEXT");

                    b.Property<string>("IdentityCardUrl")
                        .HasColumnType("TEXT");

                    b.Property<string>("IndependentPracticeExperience")
                        .HasColumnType("TEXT");

                    b.Property<string>("LawCollegeStudiedIn")
                        .HasColumnType("TEXT");

                    b.Property<string>("LawFirmExperience")
                        .HasColumnType("TEXT");

                    b.Property<string>("PublicId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.ToTable("LawyerDetails");
                });

            modelBuilder.Entity("API.Entities.Photo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AppUserId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsMain")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PublicId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.ToTable("Photos");
                });

            modelBuilder.Entity("API.Entities.Interest", b =>
                {
                    b.HasOne("API.Entities.AppUser", "AppUser")
                        .WithMany("Interests")
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("API.Entities.LawyerDetail", b =>
                {
                    b.HasOne("API.Entities.AppUser", "AppUser")
                        .WithMany("LawyerDetails")
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("API.Entities.Photo", b =>
                {
                    b.HasOne("API.Entities.AppUser", "AppUser")
                        .WithMany("Photos")
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("API.Entities.AppUser", b =>
                {
                    b.Navigation("Interests");

                    b.Navigation("LawyerDetails");

                    b.Navigation("Photos");
                });
#pragma warning restore 612, 618
        }
    }
}
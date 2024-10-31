﻿// <auto-generated />
using CoNaObiadAPI.SqliteContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CoNaObiadAPI.Migrations
{
    [DbContext(typeof(DishesDbContext))]
    [Migration("20241031093153_adding-season-prep-time")]
    partial class addingseasonpreptime
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.10");

            modelBuilder.Entity("CoNaObiadAPI.Entities.Dish", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<int>("PreparationTimeId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SeasonId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("PreparationTimeId");

                    b.HasIndex("SeasonId");

                    b.ToTable("Dishes");
                });

            modelBuilder.Entity("CoNaObiadAPI.Entities.DishTag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("DishesId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TagsId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("DishesId");

                    b.HasIndex("TagsId");

                    b.ToTable("DishTag");
                });

            modelBuilder.Entity("CoNaObiadAPI.Entities.PreparationTime", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Time")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("PreparationTime");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Time = "Fast"
                        },
                        new
                        {
                            Id = 2,
                            Time = "Medium"
                        },
                        new
                        {
                            Id = 3,
                            Time = "Slow"
                        },
                        new
                        {
                            Id = 4,
                            Time = "Extra-slow"
                        });
                });

            modelBuilder.Entity("CoNaObiadAPI.Entities.Season", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Season");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Winter"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Spring"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Summer"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Autumn"
                        });
                });

            modelBuilder.Entity("CoNaObiadAPI.Entities.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("CoNaObiadAPI.Entities.Dish", b =>
                {
                    b.HasOne("CoNaObiadAPI.Entities.PreparationTime", "PreparationTime")
                        .WithMany("Dishes")
                        .HasForeignKey("PreparationTimeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CoNaObiadAPI.Entities.Season", "Season")
                        .WithMany("Dishes")
                        .HasForeignKey("SeasonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PreparationTime");

                    b.Navigation("Season");
                });

            modelBuilder.Entity("CoNaObiadAPI.Entities.DishTag", b =>
                {
                    b.HasOne("CoNaObiadAPI.Entities.Dish", null)
                        .WithMany()
                        .HasForeignKey("DishesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CoNaObiadAPI.Entities.Tag", null)
                        .WithMany()
                        .HasForeignKey("TagsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CoNaObiadAPI.Entities.PreparationTime", b =>
                {
                    b.Navigation("Dishes");
                });

            modelBuilder.Entity("CoNaObiadAPI.Entities.Season", b =>
                {
                    b.Navigation("Dishes");
                });
#pragma warning restore 612, 618
        }
    }
}

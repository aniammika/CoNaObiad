﻿// <auto-generated />
using System;
using CoNaObiadAPI.SqliteContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CoNaObiadAPI.Migrations
{
    [DbContext(typeof(DishesDbContext))]
    partial class DishesDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.10");

            modelBuilder.Entity("CoNaObiadAPI.Entities.Dish", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Dishes");

                    b.HasData(
                        new
                        {
                            Id = new Guid("eacc5169-b2a7-41ad-92c3-dbb1a5e7af06"),
                            Name = "Zapiekanka z kurczaka i brokulow"
                        },
                        new
                        {
                            Id = new Guid("fe462ec7-b30c-4987-8a8e-5f7dbd8e0cfa"),
                            Name = "Makaron penne z cukinią i szparagami"
                        },
                        new
                        {
                            Id = new Guid("b512d7cf-b331-4b54-8dae-d1228d128e8d"),
                            Name = "Zupa pomidorowa"
                        },
                        new
                        {
                            Id = new Guid("fd630a57-2352-4731-b25c-db9cc7601b16"),
                            Name = "Gulasz wieprzowo-wolowy"
                        },
                        new
                        {
                            Id = new Guid("98929bd4-f099-41eb-a994-f1918b724b5a"),
                            Name = "Quesadilla z kurczakiem i warzywami"
                        });
                });

            modelBuilder.Entity("CoNaObiadAPI.Entities.Tag", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Tags");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"),
                            Name = "lato"
                        },
                        new
                        {
                            Id = new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba96"),
                            Name = "wiosna"
                        },
                        new
                        {
                            Id = new Guid("c19099ed-94db-44ba-885b-0ad7205d5e40"),
                            Name = "jesien"
                        },
                        new
                        {
                            Id = new Guid("0c4dc798-b38b-4a1c-905c-a9e76dbef17b"),
                            Name = "caly rok"
                        },
                        new
                        {
                            Id = new Guid("937b1ba1-7969-4324-9ab5-afb0e4d875e6"),
                            Name = "dla dzieci"
                        },
                        new
                        {
                            Id = new Guid("7a2fbc72-bb33-49de-bd23-c78fceb367fc"),
                            Name = "dla gosci"
                        },
                        new
                        {
                            Id = new Guid("b5f336e2-c226-4389-aac3-2499325a3de9"),
                            Name = "makaron"
                        },
                        new
                        {
                            Id = new Guid("c22bec27-a880-4f2a-b380-12dcd99c61fe"),
                            Name = "zapiekanka"
                        },
                        new
                        {
                            Id = new Guid("aab31c70-57ce-4b6d-a66c-9c1b094e915d"),
                            Name = "zdrowo"
                        },
                        new
                        {
                            Id = new Guid("fef8b722-664d-403f-ae3c-05f8ed7d7a1f"),
                            Name = "wege"
                        },
                        new
                        {
                            Id = new Guid("8d5a1b40-6677-4545-b6e8-5ba93efda0a1"),
                            Name = "zupa"
                        },
                        new
                        {
                            Id = new Guid("40563e5b-e538-4084-9587-3df74fae21d4"),
                            Name = "pomidory"
                        },
                        new
                        {
                            Id = new Guid("f350e1a0-38de-42fe-ada5-ae436378ee5b"),
                            Name = "comfort food"
                        });
                });

            modelBuilder.Entity("DishTag", b =>
                {
                    b.Property<Guid>("DishesId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("TagsId")
                        .HasColumnType("TEXT");

                    b.HasKey("DishesId", "TagsId");

                    b.HasIndex("TagsId");

                    b.ToTable("DishTag");

                    b.HasData(
                        new
                        {
                            DishesId = new Guid("eacc5169-b2a7-41ad-92c3-dbb1a5e7af06"),
                            TagsId = new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35")
                        },
                        new
                        {
                            DishesId = new Guid("eacc5169-b2a7-41ad-92c3-dbb1a5e7af06"),
                            TagsId = new Guid("937b1ba1-7969-4324-9ab5-afb0e4d875e6")
                        },
                        new
                        {
                            DishesId = new Guid("eacc5169-b2a7-41ad-92c3-dbb1a5e7af06"),
                            TagsId = new Guid("b5f336e2-c226-4389-aac3-2499325a3de9")
                        },
                        new
                        {
                            DishesId = new Guid("eacc5169-b2a7-41ad-92c3-dbb1a5e7af06"),
                            TagsId = new Guid("c22bec27-a880-4f2a-b380-12dcd99c61fe")
                        },
                        new
                        {
                            DishesId = new Guid("fe462ec7-b30c-4987-8a8e-5f7dbd8e0cfa"),
                            TagsId = new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba96")
                        },
                        new
                        {
                            DishesId = new Guid("fe462ec7-b30c-4987-8a8e-5f7dbd8e0cfa"),
                            TagsId = new Guid("b5f336e2-c226-4389-aac3-2499325a3de9")
                        },
                        new
                        {
                            DishesId = new Guid("fe462ec7-b30c-4987-8a8e-5f7dbd8e0cfa"),
                            TagsId = new Guid("fef8b722-664d-403f-ae3c-05f8ed7d7a1f")
                        },
                        new
                        {
                            DishesId = new Guid("b512d7cf-b331-4b54-8dae-d1228d128e8d"),
                            TagsId = new Guid("0c4dc798-b38b-4a1c-905c-a9e76dbef17b")
                        },
                        new
                        {
                            DishesId = new Guid("b512d7cf-b331-4b54-8dae-d1228d128e8d"),
                            TagsId = new Guid("937b1ba1-7969-4324-9ab5-afb0e4d875e6")
                        },
                        new
                        {
                            DishesId = new Guid("b512d7cf-b331-4b54-8dae-d1228d128e8d"),
                            TagsId = new Guid("8d5a1b40-6677-4545-b6e8-5ba93efda0a1")
                        },
                        new
                        {
                            DishesId = new Guid("b512d7cf-b331-4b54-8dae-d1228d128e8d"),
                            TagsId = new Guid("40563e5b-e538-4084-9587-3df74fae21d4")
                        },
                        new
                        {
                            DishesId = new Guid("98929bd4-f099-41eb-a994-f1918b724b5a"),
                            TagsId = new Guid("0c4dc798-b38b-4a1c-905c-a9e76dbef17b")
                        },
                        new
                        {
                            DishesId = new Guid("98929bd4-f099-41eb-a994-f1918b724b5a"),
                            TagsId = new Guid("7a2fbc72-bb33-49de-bd23-c78fceb367fc")
                        },
                        new
                        {
                            DishesId = new Guid("98929bd4-f099-41eb-a994-f1918b724b5a"),
                            TagsId = new Guid("f350e1a0-38de-42fe-ada5-ae436378ee5b")
                        });
                });

            modelBuilder.Entity("DishTag", b =>
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
#pragma warning restore 612, 618
        }
    }
}

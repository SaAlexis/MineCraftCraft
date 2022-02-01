﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mine2Craft.Test.Persistance;

#nullable disable

namespace Mine2Craft.Test.Persistance.Migrations
{
    [DbContext(typeof(BddContext))]
    partial class BddContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Mine2Craft.Test.Entities.CompleteItemEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Durability")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CompleteItems");
                });

            modelBuilder.Entity("Mine2Craft.Test.Entities.ItemEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("isCombustible")
                        .HasColumnType("tinyint");

                    b.Property<byte>("isCooked")
                        .HasColumnType("tinyint");

                    b.HasKey("Id");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("Mine2Craft.Test.Entities.UserEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pseudo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Mine2Craft.Test.Entities.WorkbenchEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<Guid>("CurrentCompleteItemId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CurrentItemId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Position")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CurrentCompleteItemId");

                    b.HasIndex("CurrentItemId");

                    b.ToTable("Workbenchs");
                });

            modelBuilder.Entity("Mine2Craft.Test.Entities.WorkbenchEntity", b =>
                {
                    b.HasOne("Mine2Craft.Test.Entities.CompleteItemEntity", "CurrentCompleteItem")
                        .WithMany("Workbenches")
                        .HasForeignKey("CurrentCompleteItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Mine2Craft.Test.Entities.ItemEntity", "CurrentItem")
                        .WithMany("Workbenches")
                        .HasForeignKey("CurrentItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CurrentCompleteItem");

                    b.Navigation("CurrentItem");
                });

            modelBuilder.Entity("Mine2Craft.Test.Entities.CompleteItemEntity", b =>
                {
                    b.Navigation("Workbenches");
                });

            modelBuilder.Entity("Mine2Craft.Test.Entities.ItemEntity", b =>
                {
                    b.Navigation("Workbenches");
                });
#pragma warning restore 612, 618
        }
    }
}

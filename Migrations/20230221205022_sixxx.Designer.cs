﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using incerc.Data;

#nullable disable

namespace incerc.Migrations
{
    [DbContext(typeof(incercContext))]
    [Migration("20230221205022_sixxx")]
    partial class sixxx
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("incerc.Models.Book", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("GenreID")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("PublisherID")
                        .HasColumnType("int");

                    b.Property<DateTime>("PublishingDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ShopID")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("GenreID");

                    b.HasIndex("PublisherID");

                    b.HasIndex("ShopID");

                    b.ToTable("Book");
                });

            modelBuilder.Entity("incerc.Models.Genre", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("GenreName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Genre");
                });

            modelBuilder.Entity("incerc.Models.Publisher", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("PublisherName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Publisher");
                });

            modelBuilder.Entity("incerc.Models.Shop", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("ShopName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Shop");
                });

            modelBuilder.Entity("incerc.Models.Book", b =>
                {
                    b.HasOne("incerc.Models.Genre", "Genre")
                        .WithMany("Books")
                        .HasForeignKey("GenreID");

                    b.HasOne("incerc.Models.Publisher", "Publisher")
                        .WithMany("Books")
                        .HasForeignKey("PublisherID");

                    b.HasOne("incerc.Models.Shop", "Shop")
                        .WithMany("Books")
                        .HasForeignKey("ShopID");

                    b.Navigation("Genre");

                    b.Navigation("Publisher");

                    b.Navigation("Shop");
                });

            modelBuilder.Entity("incerc.Models.Genre", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("incerc.Models.Publisher", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("incerc.Models.Shop", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
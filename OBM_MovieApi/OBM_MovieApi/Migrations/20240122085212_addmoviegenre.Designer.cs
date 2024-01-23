﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OBM_MovieApi.Context;

#nullable disable

namespace OBM_MovieApi.Migrations
{
    [DbContext(typeof(MovieContext))]
    [Migration("20240122085212_addmoviegenre")]
    partial class addmoviegenre
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ModelLibrary.Actor", b =>
                {
                    b.Property<int>("ActorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ActorName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("ProfilePath")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("ActorId");

                    b.ToTable("Actors");
                });

            modelBuilder.Entity("ModelLibrary.Casting", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ActorId")
                        .HasColumnType("int");

                    b.Property<int>("BillingOrder")
                        .HasColumnType("int");

                    b.Property<string>("CharacterName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<Guid>("MovieId")
                        .HasColumnType("char(36)");

                    b.HasKey("id");

                    b.HasIndex("ActorId");

                    b.HasIndex("MovieId");

                    b.ToTable("Castings");
                });

            modelBuilder.Entity("ModelLibrary.Genre", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("ModelLibrary.Movie", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Genre")
                        .HasColumnType("longtext");

                    b.Property<int?>("MovieIdInt")
                        .HasColumnType("int");

                    b.Property<string>("Original_Language")
                        .HasColumnType("longtext");

                    b.Property<string>("Overview")
                        .HasColumnType("longtext");

                    b.Property<decimal?>("Popularity")
                        .HasColumnType("decimal(65,30)");

                    b.Property<string>("Poster_Url")
                        .HasColumnType("longtext");

                    b.Property<DateOnly?>("Release_Date")
                        .HasColumnType("date");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<decimal?>("Vote_Average")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int?>("Vote_Count")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("ModelLibrary.MovieGenre", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("GenreId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("MovieId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("GenreId");

                    b.HasIndex("MovieId");

                    b.ToTable("MovieGenres");
                });

            modelBuilder.Entity("ModelLibrary.Casting", b =>
                {
                    b.HasOne("ModelLibrary.Actor", "Actor")
                        .WithMany("Castings")
                        .HasForeignKey("ActorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ModelLibrary.Movie", "Movie")
                        .WithMany("Castings")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Actor");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("ModelLibrary.MovieGenre", b =>
                {
                    b.HasOne("ModelLibrary.Genre", "Genre")
                        .WithMany("MovieGenres")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ModelLibrary.Movie", "Movie")
                        .WithMany("MovieGenres")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genre");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("ModelLibrary.Actor", b =>
                {
                    b.Navigation("Castings");
                });

            modelBuilder.Entity("ModelLibrary.Genre", b =>
                {
                    b.Navigation("MovieGenres");
                });

            modelBuilder.Entity("ModelLibrary.Movie", b =>
                {
                    b.Navigation("Castings");

                    b.Navigation("MovieGenres");
                });
#pragma warning restore 612, 618
        }
    }
}

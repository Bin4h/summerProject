﻿// <auto-generated />
using System;
using Data_Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Data_Base.Migrations
{
    [DbContext(typeof(ProjectDBContext))]
    [Migration("20240703061445_ChangeTextType")]
    partial class ChangeTextType
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Data_Base.Entities.Album", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Date")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .HasMaxLength(3000)
                        .HasColumnType("character varying(3000)");

                    b.Property<int>("SingerId")
                        .HasColumnType("integer");

                    b.Property<string>("Title")
                        .HasMaxLength(300)
                        .HasColumnType("character varying(300)");

                    b.HasKey("Id");

                    b.HasIndex("SingerId");

                    b.ToTable("Albums");
                });

            modelBuilder.Entity("Data_Base.Entities.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Title")
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.HasKey("Id");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("Data_Base.Entities.Singer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .HasMaxLength(3000)
                        .HasColumnType("character varying(3000)");

                    b.Property<string>("Link")
                        .HasMaxLength(400)
                        .HasColumnType("character varying(400)");

                    b.Property<string>("Name")
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.HasKey("Id");

                    b.ToTable("Singers");
                });

            modelBuilder.Entity("Data_Base.Entities.Track", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AlbumId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Duration")
                        .HasColumnType("integer");

                    b.Property<int>("GenreId")
                        .HasColumnType("integer");

                    b.Property<int>("ReleaseYear")
                        .HasColumnType("integer");

                    b.Property<int>("SingerId")
                        .HasColumnType("integer");

                    b.Property<string>("Title")
                        .HasMaxLength(300)
                        .HasColumnType("character varying(300)");

                    b.HasKey("Id");

                    b.HasIndex("AlbumId");

                    b.HasIndex("GenreId");

                    b.HasIndex("SingerId");

                    b.ToTable("Tracks");
                });

            modelBuilder.Entity("Data_Base.Entities.Album", b =>
                {
                    b.HasOne("Data_Base.Entities.Singer", "Singer")
                        .WithMany("Albums")
                        .HasForeignKey("SingerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Singer");
                });

            modelBuilder.Entity("Data_Base.Entities.Track", b =>
                {
                    b.HasOne("Data_Base.Entities.Album", "Album")
                        .WithMany("Tracks")
                        .HasForeignKey("AlbumId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data_Base.Entities.Genre", "Genre")
                        .WithMany()
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data_Base.Entities.Singer", "Singer")
                        .WithMany()
                        .HasForeignKey("SingerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Album");

                    b.Navigation("Genre");

                    b.Navigation("Singer");
                });

            modelBuilder.Entity("Data_Base.Entities.Album", b =>
                {
                    b.Navigation("Tracks");
                });

            modelBuilder.Entity("Data_Base.Entities.Singer", b =>
                {
                    b.Navigation("Albums");
                });
#pragma warning restore 612, 618
        }
    }
}

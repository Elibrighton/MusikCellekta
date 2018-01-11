﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using MusikCellekta.Data;
using System;

namespace MusikCellekta.Migrations
{
    [DbContext(typeof(CellektaContext))]
    [Migration("20180111061513_AddSongGenre")]
    partial class AddSongGenre
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MusikCellekta.Models.Song", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Artist");

                    b.Property<int>("Bpm");

                    b.Property<string>("Disc");

                    b.Property<string>("Genre");

                    b.Property<int>("Intensity");

                    b.Property<string>("Key");

                    b.Property<string>("Title");

                    b.Property<int>("Track");

                    b.Property<int>("Year");

                    b.HasKey("ID");

                    b.ToTable("Song");
                });
#pragma warning restore 612, 618
        }
    }
}

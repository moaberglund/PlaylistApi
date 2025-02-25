﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PlaylistApi.Data;

#nullable disable

namespace PlaylistApi.Migrations
{
    [DbContext(typeof(PlaylistContext))]
    [Migration("20250225152342_StreamsRelationship")]
    partial class StreamsRelationship
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PlaylistApi.Models.Streams", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AmazonMusicStreams")
                        .HasColumnType("int");

                    b.Property<int?>("AppleMusicStreams")
                        .HasColumnType("int");

                    b.Property<int?>("SpotifyStreams")
                        .HasColumnType("int");

                    b.Property<int>("TrackId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TrackId")
                        .IsUnique();

                    b.ToTable("Streams");
                });

            modelBuilder.Entity("PlaylistApi.Models.Track", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Album")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Artist")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Length")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tracks");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Album = "Currents",
                            Artist = "Tame Impala",
                            Category = "Indie",
                            Length = 216,
                            Title = "The Less I Know The Better"
                        },
                        new
                        {
                            Id = 2,
                            Album = "Rumours",
                            Artist = "Fleetwood Mac",
                            Category = "Rock",
                            Length = 256,
                            Title = "Dreams"
                        },
                        new
                        {
                            Id = 3,
                            Album = "Arrival",
                            Artist = "ABBA",
                            Category = "Pop",
                            Length = 227,
                            Title = "Dancing Queen"
                        },
                        new
                        {
                            Id = 4,
                            Album = "A Night at the Opera",
                            Artist = "Queen",
                            Category = "Rock",
                            Length = 354,
                            Title = "Bohemian Rhapsody"
                        });
                });

            modelBuilder.Entity("PlaylistApi.Models.Streams", b =>
                {
                    b.HasOne("PlaylistApi.Models.Track", null)
                        .WithOne("Streams")
                        .HasForeignKey("PlaylistApi.Models.Streams", "TrackId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PlaylistApi.Models.Track", b =>
                {
                    b.Navigation("Streams");
                });
#pragma warning restore 612, 618
        }
    }
}

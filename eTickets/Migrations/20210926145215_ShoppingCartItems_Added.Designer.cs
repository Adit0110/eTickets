﻿using eTickets.Data;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210926145215_ShoppingCartItems_Added")]
    partial class ShoppingCartItems_Added
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("eTickets.Models.Actor", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("Bio")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("FullName")
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnType("nvarchar(50)");

                b.Property<string>("ProfilePictureURL")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.ToTable("Actors");
            });

            modelBuilder.Entity("eTickets.Models.Actor_Movie", b =>
            {
                b.Property<int>("ActorId")
                    .HasColumnType("int");

                b.Property<int>("MovieId")
                    .HasColumnType("int");

                b.HasKey("ActorId", "MovieId");

                b.HasIndex("MovieId");

                b.ToTable("Actors_Movies");
            });

            modelBuilder.Entity("eTickets.Models.Cinema", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("Description")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Logo")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.ToTable("Cinemas");
            });

            modelBuilder.Entity("eTickets.Models.Movie", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<int>("CinemaId")
                    .HasColumnType("int");

                b.Property<string>("Description")
                    .HasColumnType("nvarchar(max)");

                b.Property<DateTime>("EndDate")
                    .HasColumnType("datetime2");

                b.Property<string>("ImageURL")
                    .HasColumnType("nvarchar(max)");

                b.Property<int>("MovieCategory")
                    .HasColumnType("int");

                b.Property<string>("Name")
                    .HasColumnType("nvarchar(max)");

                b.Property<double>("Price")
                    .HasColumnType("float");

                b.Property<int>("ProducerId")
                    .HasColumnType("int");

                b.Property<DateTime>("StartDate")
                    .HasColumnType("datetime2");

                b.HasKey("Id");

                b.HasIndex("CinemaId");

                b.HasIndex("ProducerId");

                b.ToTable("Movies");
            });

            modelBuilder.Entity("eTickets.Models.Order", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("Email")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("UserId")
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.ToTable("Orders");
            });

            modelBuilder.Entity("eTickets.Models.OrderItem", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<int>("Amount")
                    .HasColumnType("int");

                b.Property<int>("MovieId")
                    .HasColumnType("int");

                b.Property<int>("OrderId")
                    .HasColumnType("int");

                b.Property<double>("Price")
                    .HasColumnType("float");

                b.HasKey("Id");

                b.HasIndex("MovieId");

                b.HasIndex("OrderId");

                b.ToTable("OrderItems");
            });

            modelBuilder.Entity("eTickets.Models.Producer", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("Bio")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("FullName")
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnType("nvarchar(50)");

                b.Property<string>("ProfilePictureURL")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.ToTable("Producers");
            });

            modelBuilder.Entity("eTickets.Models.ShoppingCartItem", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<int>("Amount")
                    .HasColumnType("int");

                b.Property<int?>("MovieId")
                    .HasColumnType("int");

                b.Property<string>("ShoppingCartId")
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.HasIndex("MovieId");

                b.ToTable("ShoppingCartItems");
            });

            modelBuilder.Entity("eTickets.Models.Actor_Movie", b =>
            {
                b.HasOne("eTickets.Models.Actor", "Actor")
                    .WithMany("Actors_Movies")
                    .HasForeignKey("ActorId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("eTickets.Models.Movie", "Movie")
                    .WithMany("Actors_Movies")
                    .HasForeignKey("MovieId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Actor");

                b.Navigation("Movie");
            });

            modelBuilder.Entity("eTickets.Models.Movie", b =>
            {
                b.HasOne("eTickets.Models.Cinema", "Cinema")
                    .WithMany("Movies")
                    .HasForeignKey("CinemaId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("eTickets.Models.Producer", "Producer")
                    .WithMany("Movies")
                    .HasForeignKey("ProducerId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Cinema");

                b.Navigation("Producer");
            });

            modelBuilder.Entity("eTickets.Models.OrderItem", b =>
            {
                b.HasOne("eTickets.Models.Movie", "Movie")
                    .WithMany()
                    .HasForeignKey("MovieId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("eTickets.Models.Order", "Order")
                    .WithMany("OrderItems")
                    .HasForeignKey("OrderId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Movie");

                b.Navigation("Order");
            });

            modelBuilder.Entity("eTickets.Models.ShoppingCartItem", b =>
            {
                b.HasOne("eTickets.Models.Movie", "Movie")
                    .WithMany()
                    .HasForeignKey("MovieId");

                b.Navigation("Movie");
            });

            modelBuilder.Entity("eTickets.Models.Actor", b =>
            {
                b.Navigation("Actors_Movies");
            });

            modelBuilder.Entity("eTickets.Models.Cinema", b =>
            {
                b.Navigation("Movies");
            });

            modelBuilder.Entity("eTickets.Models.Movie", b =>
            {
                b.Navigation("Actors_Movies");
            });

            modelBuilder.Entity("eTickets.Models.Order", b =>
            {
                b.Navigation("OrderItems");
            });

            modelBuilder.Entity("eTickets.Models.Producer", b =>
            {
                b.Navigation("Movies");
            });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace HipHopPizzaWangs.Migrations
{
    [DbContext(typeof(HipHopPizzaWangsDbContext))]
    [Migration("20231020224753_addedordertotalwithouttip")]
    partial class addedordertotalwithouttip
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("HipHopPizzaWangs.Modles.Item", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int?>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int?>("OrderId")
                        .HasColumnType("integer");

                    b.Property<int?>("Price")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Items");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "ferrsef",
                            Name = "Carrot",
                            OrderId = 1,
                            Price = 12
                        },
                        new
                        {
                            Id = 2,
                            Description = "ferrsef",
                            Name = "Orange",
                            OrderId = 2,
                            Price = 12
                        },
                        new
                        {
                            Id = 3,
                            Description = "ferrsef",
                            Name = "Lemon",
                            OrderId = 3,
                            Price = 12
                        });
                });

            modelBuilder.Entity("HipHopPizzaWangs.Modles.Order", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int?>("Id"));

                    b.Property<string>("CustomerEmail")
                        .HasColumnType("text");

                    b.Property<string>("CustomerName")
                        .HasColumnType("text");

                    b.Property<string>("CustomerPhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("Feedback")
                        .HasColumnType("boolean");

                    b.Property<bool?>("IsOpen")
                        .HasColumnType("boolean");

                    b.Property<int>("ItemId")
                        .HasColumnType("integer");

                    b.Property<int>("OrderTotal")
                        .HasColumnType("integer");

                    b.Property<int>("OrderTotalWithoutTip")
                        .HasColumnType("integer");

                    b.Property<string>("OrderType")
                        .HasColumnType("text");

                    b.Property<int?>("PaymentId")
                        .HasColumnType("integer");

                    b.Property<string>("PaymentMethod")
                        .HasColumnType("text");

                    b.Property<int?>("PaymentTypeId")
                        .HasColumnType("integer");

                    b.Property<int>("Tip")
                        .HasColumnType("integer");

                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<int?>("UserId1")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("PaymentId");

                    b.HasIndex("UserId1");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CustomerEmail = "demoney@gmail.com",
                            CustomerName = "Dustin",
                            CustomerPhoneNumber = "9312613939",
                            Feedback = false,
                            IsOpen = false,
                            ItemId = 1,
                            OrderTotal = 123,
                            OrderTotalWithoutTip = 25,
                            OrderType = "Call in",
                            PaymentTypeId = 1,
                            Tip = 12,
                            UserId = "1"
                        },
                        new
                        {
                            Id = 2,
                            CustomerEmail = "demoney@gmail.com",
                            CustomerName = "Dustin",
                            CustomerPhoneNumber = "9312613939",
                            Feedback = true,
                            IsOpen = true,
                            ItemId = 2,
                            OrderTotal = 123,
                            OrderTotalWithoutTip = 2,
                            OrderType = "Take Out",
                            PaymentTypeId = 2,
                            Tip = 12,
                            UserId = "2"
                        },
                        new
                        {
                            Id = 3,
                            CustomerEmail = "demoney@gmail.com",
                            CustomerName = "Dustin",
                            CustomerPhoneNumber = "9312613939",
                            Feedback = false,
                            IsOpen = true,
                            ItemId = 3,
                            OrderTotal = 123,
                            OrderTotalWithoutTip = 2,
                            OrderType = "Dine In",
                            PaymentTypeId = 3,
                            Tip = 12,
                            UserId = "3"
                        });
                });

            modelBuilder.Entity("HipHopPizzaWangs.Modles.Payment", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int?>("Id"));

                    b.Property<string>("PaymentType")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Payments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            PaymentType = "Visa"
                        },
                        new
                        {
                            Id = 2,
                            PaymentType = "MasterCard"
                        },
                        new
                        {
                            Id = 3,
                            PaymentType = "Amex"
                        });
                });

            modelBuilder.Entity("HipHopPizzaWangs.Modles.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("CashierEmail")
                        .HasColumnType("text");

                    b.Property<string>("CashierPassword")
                        .HasColumnType("text");

                    b.Property<string>("Uid")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CashierEmail = "demansell2016@gmail.com",
                            CashierPassword = "M@chelle2030",
                            Uid = "1"
                        },
                        new
                        {
                            Id = 2,
                            CashierEmail = "Trex@gmail.com",
                            CashierPassword = "M@chelle2012",
                            Uid = "2"
                        },
                        new
                        {
                            Id = 3,
                            CashierEmail = "Tricertops@gmail.com",
                            CashierPassword = "M@chelle2020",
                            Uid = "3"
                        });
                });

            modelBuilder.Entity("ItemOrder", b =>
                {
                    b.Property<int>("ItemsId")
                        .HasColumnType("integer");

                    b.Property<int>("OrderId")
                        .HasColumnType("integer");

                    b.HasKey("ItemsId", "OrderId");

                    b.HasIndex("OrderId");

                    b.ToTable("ItemOrder");
                });

            modelBuilder.Entity("HipHopPizzaWangs.Modles.Order", b =>
                {
                    b.HasOne("HipHopPizzaWangs.Modles.Payment", "Payment")
                        .WithMany("Order")
                        .HasForeignKey("PaymentId");

                    b.HasOne("HipHopPizzaWangs.Modles.User", "User")
                        .WithMany("Order")
                        .HasForeignKey("UserId1");

                    b.Navigation("Payment");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ItemOrder", b =>
                {
                    b.HasOne("HipHopPizzaWangs.Modles.Item", null)
                        .WithMany()
                        .HasForeignKey("ItemsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HipHopPizzaWangs.Modles.Order", null)
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HipHopPizzaWangs.Modles.Payment", b =>
                {
                    b.Navigation("Order");
                });

            modelBuilder.Entity("HipHopPizzaWangs.Modles.User", b =>
                {
                    b.Navigation("Order");
                });
#pragma warning restore 612, 618
        }
    }
}

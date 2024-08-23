﻿// <auto-generated />
using System;
using Coordinator.Models.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Coordinator.Migrations
{
    [DbContext(typeof(TwoPhaseCommitContext))]
    [Migration("20240819074755_mig_2")]
    partial class mig_2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Coordinator.Models.Node", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Nodes");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f6d4e3ab-1daa-436a-a6bc-e2f36f535818"),
                            Name = "Order.API"
                        },
                        new
                        {
                            Id = new Guid("ec31412f-faf3-40f2-a8f9-b989da108858"),
                            Name = "Stock.API"
                        },
                        new
                        {
                            Id = new Guid("73899f71-6e63-461e-b3b8-6b09cbdd73bf"),
                            Name = "Payment.API"
                        });
                });

            modelBuilder.Entity("Coordinator.Models.NodeState", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("IsReady")
                        .HasColumnType("int");

                    b.Property<Guid>("NodeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TransactionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("TransactionState")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NodeId");

                    b.ToTable("NodeStates");
                });

            modelBuilder.Entity("Coordinator.Models.NodeState", b =>
                {
                    b.HasOne("Coordinator.Models.Node", "Node")
                        .WithMany("NodeStates")
                        .HasForeignKey("NodeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Node");
                });

            modelBuilder.Entity("Coordinator.Models.Node", b =>
                {
                    b.Navigation("NodeStates");
                });
#pragma warning restore 612, 618
        }
    }
}
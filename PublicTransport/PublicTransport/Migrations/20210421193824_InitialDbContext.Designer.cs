// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PublicTransport.Models;

namespace PublicTransport.Migrations
{
    [DbContext(typeof(PublicContext))]
    [Migration("20210421193824_InitialDbContext")]
    partial class InitialDbContext
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PublicTransport.Models.Bus", b =>
                {
                    b.Property<int>("BusID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SubscriptionSubid")
                        .HasColumnType("int");

                    b.HasKey("BusID");

                    b.HasIndex("SubscriptionSubid");

                    b.ToTable("Bus");
                });

            modelBuilder.Entity("PublicTransport.Models.Card", b =>
                {
                    b.Property<int>("CardId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Valabilty")
                        .HasColumnType("datetime2");

                    b.HasKey("CardId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Card");
                });

            modelBuilder.Entity("PublicTransport.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Phone")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("PublicTransport.Models.Route", b =>
                {
                    b.Property<int>("RouteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BusID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Station")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RouteId");

                    b.HasIndex("BusID");

                    b.ToTable("Route");
                });

            modelBuilder.Entity("PublicTransport.Models.Subscription", b =>
                {
                    b.Property<int>("Subid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("Duration")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("Sub_name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Subid");

                    b.HasIndex("CustomerId");

                    b.ToTable("Subscription");
                });

            modelBuilder.Entity("PublicTransport.Models.Ticket", b =>
                {
                    b.Property<int>("Ticid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("Tic_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Travels")
                        .HasColumnType("int");

                    b.HasKey("Ticid");

                    b.HasIndex("CustomerId");

                    b.ToTable("Ticket");
                });

            modelBuilder.Entity("PublicTransport.Models.Transaction_history", b =>
                {
                    b.Property<int>("Transid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("data")
                        .HasColumnType("datetime2");

                    b.HasKey("Transid");

                    b.HasIndex("CustomerId");

                    b.ToTable("Transaction_Histories");
                });

            modelBuilder.Entity("PublicTransport.Models.Bus", b =>
                {
                    b.HasOne("PublicTransport.Models.Subscription", null)
                        .WithMany("Buses")
                        .HasForeignKey("SubscriptionSubid");
                });

            modelBuilder.Entity("PublicTransport.Models.Card", b =>
                {
                    b.HasOne("PublicTransport.Models.Customer", null)
                        .WithMany("Cards")
                        .HasForeignKey("CustomerId");
                });

            modelBuilder.Entity("PublicTransport.Models.Route", b =>
                {
                    b.HasOne("PublicTransport.Models.Bus", "Bus")
                        .WithMany()
                        .HasForeignKey("BusID");
                });

            modelBuilder.Entity("PublicTransport.Models.Subscription", b =>
                {
                    b.HasOne("PublicTransport.Models.Customer", null)
                        .WithMany("Subscriptions")
                        .HasForeignKey("CustomerId");
                });

            modelBuilder.Entity("PublicTransport.Models.Ticket", b =>
                {
                    b.HasOne("PublicTransport.Models.Customer", null)
                        .WithMany("Tickets")
                        .HasForeignKey("CustomerId");
                });

            modelBuilder.Entity("PublicTransport.Models.Transaction_history", b =>
                {
                    b.HasOne("PublicTransport.Models.Customer", null)
                        .WithMany("Transaction_Histories")
                        .HasForeignKey("CustomerId");
                });
#pragma warning restore 612, 618
        }
    }
}

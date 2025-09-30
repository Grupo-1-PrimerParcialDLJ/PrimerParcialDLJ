using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PrimerParcialDLJAPI.Data;

#nullable disable

namespace PrimerParcialDLJAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);
            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            // === Event (tu entidad) ===
            modelBuilder.Entity("PrimerParcialDLJAPI.Models.Event", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");
                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<DateTime?>("EndAt")
                    .HasColumnType("datetime2");

                b.Property<bool>("IsOnline")
                    .HasColumnType("bit");

                b.Property<string>("Location")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Notes")
                    .HasColumnType("nvarchar(max)");

                b.Property<DateTime>("StartAt")
                    .HasColumnType("datetime2");

                b.Property<string>("Title")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");
                b.ToTable("Events");
            });

            // === SupportTicket ===
            modelBuilder.Entity("PrimerParcialDLJAPI.Models.SupportTicket", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");
                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<string>("AssignedTo")
                    .HasColumnType("nvarchar(max)");

                b.Property<DateTime?>("ClosedAt")
                    .HasColumnType("datetime2");

                b.Property<string>("Description")
                    .HasColumnType("nvarchar(max)");

                b.Property<DateTime>("OpenedAt")
                    .HasColumnType("datetime2");

                b.Property<string>("RequesterEmail")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Severity")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Status")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Subject")
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnType("nvarchar(200)");

                b.HasKey("Id");
                b.ToTable("SupportTickets");
            });

            // === Product ===
            modelBuilder.Entity("PrimerParcialDLJAPI.Models.Product", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");
                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<string>("Description")
                    .HasColumnType("nvarchar(max)");

                b.Property<bool>("IsActive")
                    .HasColumnType("bit");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnType("nvarchar(100)");

                b.Property<decimal>("Price")
                    .HasColumnType("decimal(18,2)");

                b.Property<int>("Stock")
                    .HasColumnType("int");

                b.Property<DateTime>("CreatedAt")
                    .HasColumnType("datetime2");

                b.Property<DateTime?>("UpdatedAt")
                    .HasColumnType("datetime2");

                b.HasKey("Id");
                b.ToTable("Products");
            });
#pragma warning restore 612, 618
        }
    }
}
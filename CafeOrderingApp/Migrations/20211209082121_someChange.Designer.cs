﻿// <auto-generated />
using System;
using CafeOrderingApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CafeOrderingApp.Migrations
{
    [DbContext(typeof(CafeContext))]
    [Migration("20211209082121_someChange")]
    partial class someChange
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CafeOrderingApp.Models.Kat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Kod")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Sira")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Katlar");
                });

            modelBuilder.Entity("CafeOrderingApp.Models.Kategori", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Aciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("Fotograf")
                        .HasColumnType("varbinary(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Kategoriler");
                });

            modelBuilder.Entity("CafeOrderingApp.Models.Masa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("KatId")
                        .HasColumnType("int");

                    b.Property<bool>("MasaDurumuDoluMu")
                        .HasColumnType("bit");

                    b.Property<int>("Sira")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("KatId");

                    b.ToTable("Masalar");
                });

            modelBuilder.Entity("CafeOrderingApp.Models.Siparis", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Adet")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Fiyat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("MasaId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UrunId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MasaId");

                    b.HasIndex("UrunId");

                    b.ToTable("Siparisler");
                });

            modelBuilder.Entity("CafeOrderingApp.Models.Urun", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Fiyat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<byte[]>("Fotograf")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("KategoriId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("KategoriId");

                    b.ToTable("Urunler");
                });

            modelBuilder.Entity("CafeOrderingApp.Models.Masa", b =>
                {
                    b.HasOne("CafeOrderingApp.Models.Kat", null)
                        .WithMany("Masalar")
                        .HasForeignKey("KatId");
                });

            modelBuilder.Entity("CafeOrderingApp.Models.Siparis", b =>
                {
                    b.HasOne("CafeOrderingApp.Models.Masa", "Masa")
                        .WithMany()
                        .HasForeignKey("MasaId");

                    b.HasOne("CafeOrderingApp.Models.Urun", "Urun")
                        .WithMany()
                        .HasForeignKey("UrunId");

                    b.Navigation("Masa");

                    b.Navigation("Urun");
                });

            modelBuilder.Entity("CafeOrderingApp.Models.Urun", b =>
                {
                    b.HasOne("CafeOrderingApp.Models.Kategori", "Kategori")
                        .WithMany("Urunler")
                        .HasForeignKey("KategoriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategori");
                });

            modelBuilder.Entity("CafeOrderingApp.Models.Kat", b =>
                {
                    b.Navigation("Masalar");
                });

            modelBuilder.Entity("CafeOrderingApp.Models.Kategori", b =>
                {
                    b.Navigation("Urunler");
                });
#pragma warning restore 612, 618
        }
    }
}

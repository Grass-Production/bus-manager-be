﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QuanLiTuyenXeBusDalat.Data;

#nullable disable

namespace QuanLiTuyenXeBusDalat.Migrations
{
    [DbContext(typeof(MyDBContext))]
    [Migration("20230422035205_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("QuanLiTuyenXeBusDalat.Data.DonViQuanLiXe", b =>
                {
                    b.Property<int>("MaDonVi")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaDonVi"));

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SoDienThoai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenDonVi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaDonVi");

                    b.ToTable("DonViQLXe");
                });

            modelBuilder.Entity("QuanLiTuyenXeBusDalat.Data.RefreshToken", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ExpireAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsRevoked")
                        .HasColumnType("bit");

                    b.Property<DateTime>("IsSuedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsUsed")
                        .HasColumnType("bit");

                    b.Property<string>("JwtId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("RefreshToken");
                });

            modelBuilder.Entity("QuanLiTuyenXeBusDalat.Data.TaiKhoan", b =>
                {
                    b.Property<int>("MaTaiKhoan")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaTaiKhoan"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HoTen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgayThangNamSinh")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("SDT")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("MaTaiKhoan");

                    b.ToTable("TaiKhoan");
                });

            modelBuilder.Entity("QuanLiTuyenXeBusDalat.Data.TaiXe", b =>
                {
                    b.Property<int>("MaTX")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaTX"));

                    b.Property<string>("BangLai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("GioiTinh")
                        .HasColumnType("bit");

                    b.Property<string>("HoVaTen")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<double>("Luong")
                        .HasColumnType("float");

                    b.Property<int>("MaXe")
                        .HasColumnType("int");

                    b.Property<DateTime>("NgayBDHopDong")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgaySinh")
                        .HasColumnType("datetime2");

                    b.Property<string>("QueQuan")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaTX");

                    b.HasIndex("MaXe");

                    b.ToTable("TaiXe");
                });

            modelBuilder.Entity("QuanLiTuyenXeBusDalat.Data.Tuyen", b =>
                {
                    b.Property<int>("MaTuyen")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaTuyen"));

                    b.Property<string>("LoTrinhLuotDi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LoTrinhLuotVe")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LoaiTuyen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MaDonVi")
                        .HasColumnType("int");

                    b.Property<string>("TenTuyen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThoiGianBatDau")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThoiGianGianCach")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThoiGianKetThuc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaTuyen");

                    b.HasIndex("MaDonVi");

                    b.ToTable("Tuyen");
                });

            modelBuilder.Entity("QuanLiTuyenXeBusDalat.Data.Xe", b =>
                {
                    b.Property<int>("MaXe")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaXe"));

                    b.Property<string>("BienSo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ChuKyBaoHanh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("CongSuat")
                        .HasColumnType("real");

                    b.Property<string>("LoaiXe")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MaTuyen")
                        .HasColumnType("int");

                    b.Property<DateTime>("NgaySX")
                        .HasColumnType("datetime2");

                    b.Property<int>("SoGhe")
                        .HasColumnType("int");

                    b.HasKey("MaXe");

                    b.HasIndex("MaTuyen");

                    b.ToTable("Xe");
                });

            modelBuilder.Entity("QuanLiTuyenXeBusDalat.Data.RefreshToken", b =>
                {
                    b.HasOne("QuanLiTuyenXeBusDalat.Data.TaiKhoan", "taiKhoan")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("taiKhoan");
                });

            modelBuilder.Entity("QuanLiTuyenXeBusDalat.Data.TaiXe", b =>
                {
                    b.HasOne("QuanLiTuyenXeBusDalat.Data.Xe", "Xe")
                        .WithMany()
                        .HasForeignKey("MaXe")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Xe");
                });

            modelBuilder.Entity("QuanLiTuyenXeBusDalat.Data.Tuyen", b =>
                {
                    b.HasOne("QuanLiTuyenXeBusDalat.Data.DonViQuanLiXe", "DonViQuanLiXe")
                        .WithMany()
                        .HasForeignKey("MaDonVi");

                    b.Navigation("DonViQuanLiXe");
                });

            modelBuilder.Entity("QuanLiTuyenXeBusDalat.Data.Xe", b =>
                {
                    b.HasOne("QuanLiTuyenXeBusDalat.Data.Tuyen", "Tuyen")
                        .WithMany()
                        .HasForeignKey("MaTuyen")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tuyen");
                });
#pragma warning restore 612, 618
        }
    }
}

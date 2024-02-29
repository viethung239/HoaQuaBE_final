﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Test.Infrastructure.Context;

#nullable disable

namespace Test.Infrastructure.Migrations
{
    [DbContext(typeof(TestDBContext))]
    partial class TestDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Test.Domain.Entities.ChiNhanh", b =>
                {
                    b.Property<Guid>("IdChiNhanh")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("NgayCapNhat")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("NgayTao")
                        .HasColumnType("datetime2");

                    b.Property<string>("TenChiNhanh")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar");

                    b.HasKey("IdChiNhanh");

                    b.ToTable("ChiNhanh", (string)null);
                });

            modelBuilder.Entity("Test.Domain.Entities.DMKho", b =>
                {
                    b.Property<Guid>("IdDMKho")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("KieuLoai")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar");

                    b.Property<string>("MaKho")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar");

                    b.Property<DateTime?>("NgayCapNhat")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("NgayTao")
                        .HasColumnType("datetime2");

                    b.Property<string>("TenKho")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar");

                    b.HasKey("IdDMKho");

                    b.ToTable("DMKho", (string)null);
                });

            modelBuilder.Entity("Test.Domain.Entities.DMNhomSanPham", b =>
                {
                    b.Property<Guid>("IdDMNSanPham")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MoTa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("NgayCapNhat")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("NgayTao")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("SuDung")
                        .HasColumnType("bit");

                    b.Property<string>("TenDMNhomSanPham")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar");

                    b.HasKey("IdDMNSanPham");

                    b.ToTable("DMNhomSanPham", (string)null);
                });

            modelBuilder.Entity("Test.Domain.Entities.DMSanPham", b =>
                {
                    b.Property<Guid>("IdDMSanPham")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdDMNSanPham")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("NgayCapNhat")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("NgayTao")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("SuDung")
                        .HasColumnType("bit");

                    b.Property<string>("TenDanhMucSanPham")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar");

                    b.HasKey("IdDMSanPham");

                    b.HasIndex("IdDMNSanPham");

                    b.ToTable("DMSanPham", (string)null);
                });

            modelBuilder.Entity("Test.Domain.Entities.DonHang", b =>
                {
                    b.Property<Guid>("IdDonHang")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DiaChi")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar");

                    b.Property<string>("GhiChuDonHang")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar");

                    b.Property<int?>("KieuThanhToan")
                        .HasColumnType("int");

                    b.Property<string>("MaDonHang")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar");

                    b.Property<DateTime>("NgayCapNhat")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayTao")
                        .HasColumnType("datetime2");

                    b.Property<string>("SoDienThoaiKhach")
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar");

                    b.Property<string>("TenKhach")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar");

                    b.Property<float>("ThanhTien")
                        .HasColumnType("real");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IdDonHang");

                    b.HasIndex("UserId");

                    b.ToTable("DonHang", (string)null);
                });

            modelBuilder.Entity("Test.Domain.Entities.DonHangChiTiet", b =>
                {
                    b.Property<Guid>("IdDonHangSanPham")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<float?>("Gia")
                        .HasColumnType("real");

                    b.Property<Guid>("IdDonHang")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdSanPham")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("NgayCapNhat")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayTao")
                        .HasColumnType("datetime2");

                    b.Property<int?>("SoLuong")
                        .HasColumnType("int");

                    b.Property<float?>("TongTien")
                        .HasColumnType("real");

                    b.HasKey("IdDonHangSanPham");

                    b.HasIndex("IdDonHang");

                    b.HasIndex("IdSanPham");

                    b.ToTable("DonHangChiTiet", (string)null);
                });

            modelBuilder.Entity("Test.Domain.Entities.Kho", b =>
                {
                    b.Property<Guid>("IdKho")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdChiNhanh")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("NgayCapNhat")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("NgayTao")
                        .HasColumnType("datetime2");

                    b.Property<string>("TenKho")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar");

                    b.HasKey("IdKho");

                    b.HasIndex("IdChiNhanh");

                    b.ToTable("Kho", (string)null);
                });

            modelBuilder.Entity("Test.Domain.Entities.KhoChiTiet", b =>
                {
                    b.Property<Guid>("IdKhoChiTiet")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<float?>("GiaNhapTrungBinh")
                        .HasColumnType("real");

                    b.Property<Guid?>("IdChiNhanh")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdDMKho")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdKho")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdNhaCungCap")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdSanPham")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("NgayCapNhat")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("NgayTao")
                        .HasColumnType("datetime2");

                    b.Property<float?>("SoLuong")
                        .HasColumnType("real");

                    b.HasKey("IdKhoChiTiet");

                    b.HasIndex("IdChiNhanh");

                    b.HasIndex("IdDMKho");

                    b.HasIndex("IdKho");

                    b.HasIndex("IdNhaCungCap");

                    b.HasIndex("IdSanPham");

                    b.ToTable("KhoChiTiet", (string)null);
                });

            modelBuilder.Entity("Test.Domain.Entities.NhaCungCap", b =>
                {
                    b.Property<Guid>("IdNhaCungCap")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DiaChi")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgayCapNhat")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayTao")
                        .HasColumnType("datetime2");

                    b.Property<string>("NguoiLienHe")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar");

                    b.Property<string>("SdtNguoiLienHe")
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar");

                    b.Property<bool>("SuDung")
                        .HasColumnType("bit");

                    b.Property<string>("TenNhaCung")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar");

                    b.HasKey("IdNhaCungCap");

                    b.ToTable("NhaCungCap", (string)null);
                });

            modelBuilder.Entity("Test.Domain.Entities.PhieuChuyenKho", b =>
                {
                    b.Property<Guid>("IdPhieuChuyenKho")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("GhiChu")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar");

                    b.Property<Guid?>("IdDenChiNhanh")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdDenKho")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdTuChiNhanh")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdTuKho")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("NgayCapNhat")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("NgayChuyenKho")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("NgayTao")
                        .HasColumnType("datetime2");

                    b.Property<float?>("TongGiaTri")
                        .HasColumnType("real");

                    b.HasKey("IdPhieuChuyenKho");

                    b.ToTable("PhieuChuyenKho", (string)null);
                });

            modelBuilder.Entity("Test.Domain.Entities.PhieuChuyenKhoSanPham", b =>
                {
                    b.Property<Guid>("IdPhieuChuyenKhoSanPham")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<float?>("Gia")
                        .HasColumnType("real");

                    b.Property<Guid?>("IdDenChiNhanh")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdDenKho")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdPhieuChuyenKho")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdSanPham")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdTuChiNhanh")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdTuKho")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("NgayCapNhat")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("NgayTao")
                        .HasColumnType("datetime2");

                    b.Property<float?>("SoLuong")
                        .HasColumnType("real");

                    b.Property<float?>("SoLuongSauDenKho")
                        .HasColumnType("real");

                    b.Property<float?>("SoLuongSauTuKho")
                        .HasColumnType("real");

                    b.Property<float?>("SoLuongTruocDenKho")
                        .HasColumnType("real");

                    b.Property<float?>("SoLuongTruocTuKho")
                        .HasColumnType("real");

                    b.Property<float?>("TongTien")
                        .HasColumnType("real");

                    b.HasKey("IdPhieuChuyenKhoSanPham");

                    b.HasIndex("IdPhieuChuyenKho");

                    b.HasIndex("IdSanPham");

                    b.ToTable("PhieuChuyenKhoSanPham", (string)null);
                });

            modelBuilder.Entity("Test.Domain.Entities.PhieuNhap", b =>
                {
                    b.Property<Guid>("IdPhieuNhap")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("GhiChu")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar");

                    b.Property<Guid?>("IdChiNhanh")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdKho")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdNhaCungCap")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("NgayCapNhat")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("NgayNhap")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("NgayTao")
                        .HasColumnType("datetime2");

                    b.Property<float?>("TongGiaNhap")
                        .HasColumnType("real");

                    b.HasKey("IdPhieuNhap");

                    b.HasIndex("IdChiNhanh");

                    b.HasIndex("IdKho");

                    b.HasIndex("IdNhaCungCap");

                    b.ToTable("PhieuNhap", (string)null);
                });

            modelBuilder.Entity("Test.Domain.Entities.PhieuNhapSanPham", b =>
                {
                    b.Property<Guid>("IdPhieuNhapSanPham")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("DMNhomSanPhamIdDMNSanPham")
                        .HasColumnType("uniqueidentifier");

                    b.Property<float?>("GiaNhap")
                        .HasColumnType("real");

                    b.Property<Guid?>("IdKhoChiTiet")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdPhieuNhap")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdSanPham")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("NgayCapNhat")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("NgayTao")
                        .HasColumnType("datetime2");

                    b.Property<float?>("SoLuong")
                        .HasColumnType("real");

                    b.Property<float?>("SoLuongSau")
                        .HasColumnType("real");

                    b.Property<float?>("SoLuongTruoc")
                        .HasColumnType("real");

                    b.Property<float?>("TongTien")
                        .HasColumnType("real");

                    b.HasKey("IdPhieuNhapSanPham");

                    b.HasIndex("DMNhomSanPhamIdDMNSanPham");

                    b.HasIndex("IdKhoChiTiet");

                    b.HasIndex("IdPhieuNhap");

                    b.HasIndex("IdSanPham");

                    b.ToTable("PhieuNhapSanPham", (string)null);
                });

            modelBuilder.Entity("Test.Domain.Entities.PhieuXuat", b =>
                {
                    b.Property<Guid>("IdPhieuXuat")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("GhiChu")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar");

                    b.Property<Guid?>("IdChiNhanh")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdDonHang")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdKho")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("NgayCapNhat")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("NgayTao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("NgayXuat")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UserId")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IdPhieuXuat");

                    b.HasIndex("IdChiNhanh");

                    b.HasIndex("IdDonHang");

                    b.HasIndex("IdKho");

                    b.HasIndex("UserId");

                    b.ToTable("PhieuXuat", (string)null);
                });

            modelBuilder.Entity("Test.Domain.Entities.PhieuXuatSanPham", b =>
                {
                    b.Property<Guid>("IdPhieuXuatSanPham")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("DMNhomSanPhamIdDMNSanPham")
                        .HasColumnType("uniqueidentifier");

                    b.Property<float?>("Gia")
                        .HasColumnType("real");

                    b.Property<Guid?>("IdKhoChiTiet")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdPhieuXuat")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdSanPham")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("NgayCapNhat")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("NgayTao")
                        .HasColumnType("datetime2");

                    b.Property<float?>("SoLuong")
                        .HasColumnType("real");

                    b.Property<float?>("SoLuongSau")
                        .HasColumnType("real");

                    b.Property<float?>("SoLuongTruoc")
                        .HasColumnType("real");

                    b.Property<float?>("TongTien")
                        .HasColumnType("real");

                    b.HasKey("IdPhieuXuatSanPham");

                    b.HasIndex("DMNhomSanPhamIdDMNSanPham");

                    b.HasIndex("IdKhoChiTiet");

                    b.HasIndex("IdPhieuXuat");

                    b.HasIndex("IdSanPham");

                    b.ToTable("PhieuXuatSanPham", (string)null);
                });

            modelBuilder.Entity("Test.Domain.Entities.Role", b =>
                {
                    b.Property<Guid>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MoTa")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar");

                    b.Property<DateTime?>("NgayCapNhat")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("NgayTao")
                        .HasColumnType("datetime2");

                    b.Property<string>("TenQuyen")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar");

                    b.HasKey("RoleId");

                    b.ToTable("Role", (string)null);
                });

            modelBuilder.Entity("Test.Domain.Entities.SanPham", b =>
                {
                    b.Property<Guid>("IdSanPham")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<float?>("GiaNhapVao")
                        .HasColumnType("real");

                    b.Property<float?>("GiaSanPham")
                        .HasColumnType("real");

                    b.Property<Guid?>("IdDMSanPham")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("IdImage")
                        .HasMaxLength(4000)
                        .HasColumnType("nvarchar");

                    b.Property<string>("Mota")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar");

                    b.Property<DateTime?>("NgayCapNhat")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("NgayTao")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("SuDung")
                        .HasColumnType("bit");

                    b.Property<string>("TenSanPham")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar");

                    b.HasKey("IdSanPham");

                    b.HasIndex("IdDMSanPham");

                    b.ToTable("SanPham", (string)null);
                });

            modelBuilder.Entity("Test.Domain.Entities.User", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AvartarUrl")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar");

                    b.Property<string>("DiaChi")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar");

                    b.Property<string>("Email")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar");

                    b.Property<int?>("GioiTinh")
                        .HasColumnType("int");

                    b.Property<Guid?>("IdChiNhanh")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("MaNV")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar");

                    b.Property<DateTime?>("NgayCapNhat")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("NgaySinh")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("NgayTao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar");

                    b.Property<Guid?>("RoleId")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("SoDienThoai")
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar");

                    b.Property<string>("TenNV")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar");

                    b.Property<string>("UserName")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar");

                    b.HasKey("UserId");

                    b.HasIndex("IdChiNhanh");

                    b.HasIndex("RoleId");

                    b.ToTable("User", (string)null);
                });

            modelBuilder.Entity("Test.Domain.Entities.DMSanPham", b =>
                {
                    b.HasOne("Test.Domain.Entities.DMNhomSanPham", "DMNhomSanPham")
                        .WithMany("DMSanPhams")
                        .HasForeignKey("IdDMNSanPham");

                    b.Navigation("DMNhomSanPham");
                });

            modelBuilder.Entity("Test.Domain.Entities.DonHang", b =>
                {
                    b.HasOne("Test.Domain.Entities.User", "User")
                        .WithMany("DonHangs")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Test.Domain.Entities.DonHangChiTiet", b =>
                {
                    b.HasOne("Test.Domain.Entities.DonHang", "DonHang")
                        .WithMany("DonHangChiTiets")
                        .HasForeignKey("IdDonHang")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Test.Domain.Entities.SanPham", "SanPham")
                        .WithMany("DonHangChiTiets")
                        .HasForeignKey("IdSanPham")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DonHang");

                    b.Navigation("SanPham");
                });

            modelBuilder.Entity("Test.Domain.Entities.Kho", b =>
                {
                    b.HasOne("Test.Domain.Entities.ChiNhanh", "ChiNhanh")
                        .WithMany("khos")
                        .HasForeignKey("IdChiNhanh");

                    b.Navigation("ChiNhanh");
                });

            modelBuilder.Entity("Test.Domain.Entities.KhoChiTiet", b =>
                {
                    b.HasOne("Test.Domain.Entities.ChiNhanh", "ChiNhanh")
                        .WithMany("KhoChiTiets")
                        .HasForeignKey("IdChiNhanh");

                    b.HasOne("Test.Domain.Entities.DMKho", "DMKho")
                        .WithMany("KhoChiTiets")
                        .HasForeignKey("IdDMKho")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Test.Domain.Entities.Kho", "Kho")
                        .WithMany("KhoChiTiets")
                        .HasForeignKey("IdKho");

                    b.HasOne("Test.Domain.Entities.NhaCungCap", "NhaCungCap")
                        .WithMany("KhoChiTiets")
                        .HasForeignKey("IdNhaCungCap")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Test.Domain.Entities.SanPham", "SanPham")
                        .WithMany("KhoChiTiets")
                        .HasForeignKey("IdSanPham");

                    b.Navigation("ChiNhanh");

                    b.Navigation("DMKho");

                    b.Navigation("Kho");

                    b.Navigation("NhaCungCap");

                    b.Navigation("SanPham");
                });

            modelBuilder.Entity("Test.Domain.Entities.PhieuChuyenKhoSanPham", b =>
                {
                    b.HasOne("Test.Domain.Entities.PhieuChuyenKho", "PhieuChuyenKho")
                        .WithMany("PhieuChuyenKhoSanPhams")
                        .HasForeignKey("IdPhieuChuyenKho");

                    b.HasOne("Test.Domain.Entities.SanPham", "SanPham")
                        .WithMany("PhieuChuyenKhoSanPhams")
                        .HasForeignKey("IdSanPham");

                    b.Navigation("PhieuChuyenKho");

                    b.Navigation("SanPham");
                });

            modelBuilder.Entity("Test.Domain.Entities.PhieuNhap", b =>
                {
                    b.HasOne("Test.Domain.Entities.ChiNhanh", "ChiNhanh")
                        .WithMany("PhieuNhaps")
                        .HasForeignKey("IdChiNhanh");

                    b.HasOne("Test.Domain.Entities.Kho", "Kho")
                        .WithMany("PhieuNhaps")
                        .HasForeignKey("IdKho");

                    b.HasOne("Test.Domain.Entities.NhaCungCap", "NhaCungCap")
                        .WithMany("PhieuNhaps")
                        .HasForeignKey("IdNhaCungCap");

                    b.Navigation("ChiNhanh");

                    b.Navigation("Kho");

                    b.Navigation("NhaCungCap");
                });

            modelBuilder.Entity("Test.Domain.Entities.PhieuNhapSanPham", b =>
                {
                    b.HasOne("Test.Domain.Entities.DMNhomSanPham", null)
                        .WithMany("PhieuNhapSanPhams")
                        .HasForeignKey("DMNhomSanPhamIdDMNSanPham");

                    b.HasOne("Test.Domain.Entities.KhoChiTiet", "KhoChiTiet")
                        .WithMany("PhieuNhapSanPhams")
                        .HasForeignKey("IdKhoChiTiet");

                    b.HasOne("Test.Domain.Entities.PhieuNhap", "PhieuNhap")
                        .WithMany("PhieuNhapSanPhams")
                        .HasForeignKey("IdPhieuNhap");

                    b.HasOne("Test.Domain.Entities.SanPham", "SanPham")
                        .WithMany("PhieuNhapSanPhams")
                        .HasForeignKey("IdSanPham");

                    b.Navigation("KhoChiTiet");

                    b.Navigation("PhieuNhap");

                    b.Navigation("SanPham");
                });

            modelBuilder.Entity("Test.Domain.Entities.PhieuXuat", b =>
                {
                    b.HasOne("Test.Domain.Entities.ChiNhanh", "ChiNhanh")
                        .WithMany("PhieuXuats")
                        .HasForeignKey("IdChiNhanh");

                    b.HasOne("Test.Domain.Entities.DonHang", "DonHang")
                        .WithMany("PhieuXuats")
                        .HasForeignKey("IdDonHang");

                    b.HasOne("Test.Domain.Entities.Kho", "Kho")
                        .WithMany("PhieuXuats")
                        .HasForeignKey("IdKho");

                    b.HasOne("Test.Domain.Entities.User", "User")
                        .WithMany("PhieuXuats")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ChiNhanh");

                    b.Navigation("DonHang");

                    b.Navigation("Kho");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Test.Domain.Entities.PhieuXuatSanPham", b =>
                {
                    b.HasOne("Test.Domain.Entities.DMNhomSanPham", null)
                        .WithMany("PhieuXuatSanPhams")
                        .HasForeignKey("DMNhomSanPhamIdDMNSanPham");

                    b.HasOne("Test.Domain.Entities.KhoChiTiet", "KhoChiTiet")
                        .WithMany("PhieuXuatSanPhams")
                        .HasForeignKey("IdKhoChiTiet");

                    b.HasOne("Test.Domain.Entities.PhieuXuat", "PhieuXuat")
                        .WithMany("PhieuXuatSanPhams")
                        .HasForeignKey("IdPhieuXuat");

                    b.HasOne("Test.Domain.Entities.SanPham", "SanPham")
                        .WithMany("PhieuXuatSanPhams")
                        .HasForeignKey("IdSanPham");

                    b.Navigation("KhoChiTiet");

                    b.Navigation("PhieuXuat");

                    b.Navigation("SanPham");
                });

            modelBuilder.Entity("Test.Domain.Entities.SanPham", b =>
                {
                    b.HasOne("Test.Domain.Entities.DMSanPham", "DMSanPham")
                        .WithMany("SanPham")
                        .HasForeignKey("IdDMSanPham");

                    b.Navigation("DMSanPham");
                });

            modelBuilder.Entity("Test.Domain.Entities.User", b =>
                {
                    b.HasOne("Test.Domain.Entities.ChiNhanh", "ChiNhanh")
                        .WithMany("Users")
                        .HasForeignKey("IdChiNhanh");

                    b.HasOne("Test.Domain.Entities.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ChiNhanh");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Test.Domain.Entities.ChiNhanh", b =>
                {
                    b.Navigation("KhoChiTiets");

                    b.Navigation("PhieuNhaps");

                    b.Navigation("PhieuXuats");

                    b.Navigation("Users");

                    b.Navigation("khos");
                });

            modelBuilder.Entity("Test.Domain.Entities.DMKho", b =>
                {
                    b.Navigation("KhoChiTiets");
                });

            modelBuilder.Entity("Test.Domain.Entities.DMNhomSanPham", b =>
                {
                    b.Navigation("DMSanPhams");

                    b.Navigation("PhieuNhapSanPhams");

                    b.Navigation("PhieuXuatSanPhams");
                });

            modelBuilder.Entity("Test.Domain.Entities.DMSanPham", b =>
                {
                    b.Navigation("SanPham");
                });

            modelBuilder.Entity("Test.Domain.Entities.DonHang", b =>
                {
                    b.Navigation("DonHangChiTiets");

                    b.Navigation("PhieuXuats");
                });

            modelBuilder.Entity("Test.Domain.Entities.Kho", b =>
                {
                    b.Navigation("KhoChiTiets");

                    b.Navigation("PhieuNhaps");

                    b.Navigation("PhieuXuats");
                });

            modelBuilder.Entity("Test.Domain.Entities.KhoChiTiet", b =>
                {
                    b.Navigation("PhieuNhapSanPhams");

                    b.Navigation("PhieuXuatSanPhams");
                });

            modelBuilder.Entity("Test.Domain.Entities.NhaCungCap", b =>
                {
                    b.Navigation("KhoChiTiets");

                    b.Navigation("PhieuNhaps");
                });

            modelBuilder.Entity("Test.Domain.Entities.PhieuChuyenKho", b =>
                {
                    b.Navigation("PhieuChuyenKhoSanPhams");
                });

            modelBuilder.Entity("Test.Domain.Entities.PhieuNhap", b =>
                {
                    b.Navigation("PhieuNhapSanPhams");
                });

            modelBuilder.Entity("Test.Domain.Entities.PhieuXuat", b =>
                {
                    b.Navigation("PhieuXuatSanPhams");
                });

            modelBuilder.Entity("Test.Domain.Entities.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("Test.Domain.Entities.SanPham", b =>
                {
                    b.Navigation("DonHangChiTiets");

                    b.Navigation("KhoChiTiets");

                    b.Navigation("PhieuChuyenKhoSanPhams");

                    b.Navigation("PhieuNhapSanPhams");

                    b.Navigation("PhieuXuatSanPhams");
                });

            modelBuilder.Entity("Test.Domain.Entities.User", b =>
                {
                    b.Navigation("DonHangs");

                    b.Navigation("PhieuXuats");
                });
#pragma warning restore 612, 618
        }
    }
}

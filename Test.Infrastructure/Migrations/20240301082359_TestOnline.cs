﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Test.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class TestOnline : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChiNhanh",
                columns: table => new
                {
                    IdChiNhanh = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenChiNhanh = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NgayCapNhat = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiNhanh", x => x.IdChiNhanh);
                });

            migrationBuilder.CreateTable(
                name: "DMKho",
                columns: table => new
                {
                    IdDMKho = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    KieuLoai = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TenKho = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    MaKho = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NgayCapNhat = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DMKho", x => x.IdDMKho);
                });

            migrationBuilder.CreateTable(
                name: "DMNhomSanPham",
                columns: table => new
                {
                    IdDMNSanPham = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenDMNhomSanPham = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SuDung = table.Column<bool>(type: "bit", nullable: true),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NgayCapNhat = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DMNhomSanPham", x => x.IdDMNSanPham);
                });

            migrationBuilder.CreateTable(
                name: "NhaCungCap",
                columns: table => new
                {
                    IdNhaCungCap = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenNhaCung = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    NguoiLienHe = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SdtNguoiLienHe = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SuDung = table.Column<bool>(type: "bit", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayCapNhat = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhaCungCap", x => x.IdNhaCungCap);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenQuyen = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    MoTa = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NgayCapNhat = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.RoleId);
                });

            migrationBuilder.CreateTable(
                name: "Kho",
                columns: table => new
                {
                    IdKho = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdChiNhanh = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TenKho = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NgayCapNhat = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kho", x => x.IdKho);
                    table.ForeignKey(
                        name: "FK_Kho_ChiNhanh_IdChiNhanh",
                        column: x => x.IdChiNhanh,
                        principalTable: "ChiNhanh",
                        principalColumn: "IdChiNhanh");
                });

            migrationBuilder.CreateTable(
                name: "DMSanPham",
                columns: table => new
                {
                    IdDMSanPham = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdDMNSanPham = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TenDanhMucSanPham = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SuDung = table.Column<bool>(type: "bit", nullable: true),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NgayCapNhat = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DMSanPham", x => x.IdDMSanPham);
                    table.ForeignKey(
                        name: "FK_DMSanPham_DMNhomSanPham_IdDMNSanPham",
                        column: x => x.IdDMNSanPham,
                        principalTable: "DMNhomSanPham",
                        principalColumn: "IdDMNSanPham");
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdChiNhanh = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Password = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    AvartarUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    MaNV = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    TenNV = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SoDienThoai = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GioiTinh = table.Column<int>(type: "int", nullable: true),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NgayCapNhat = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_User_ChiNhanh_IdChiNhanh",
                        column: x => x.IdChiNhanh,
                        principalTable: "ChiNhanh",
                        principalColumn: "IdChiNhanh");
                    table.ForeignKey(
                        name: "FK_User_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SanPham",
                columns: table => new
                {
                    IdSanPham = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdDMSanPham = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TenSanPham = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    GiaSanPham = table.Column<float>(type: "real", nullable: true),
                    Mota = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    IdImage = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    SuDung = table.Column<bool>(type: "bit", nullable: true),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NgayCapNhat = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPham", x => x.IdSanPham);
                    table.ForeignKey(
                        name: "FK_SanPham_DMSanPham_IdDMSanPham",
                        column: x => x.IdDMSanPham,
                        principalTable: "DMSanPham",
                        principalColumn: "IdDMSanPham");
                });

            migrationBuilder.CreateTable(
                name: "DonHang",
                columns: table => new
                {
                    IdDonHang = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ThanhTien = table.Column<float>(type: "real", nullable: false),
                    MaDonHang = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    KieuThanhToan = table.Column<int>(type: "int", nullable: true),
                    TenKhach = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SoDienThoaiKhach = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    GhiChuDonHang = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayCapNhat = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DonHang", x => x.IdDonHang);
                    table.ForeignKey(
                        name: "FK_DonHang_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KhoChiTiet",
                columns: table => new
                {
                    IdKhoChiTiet = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdKho = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdDMKho = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdChiNhanh = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdSanPham = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdNhaCungCap = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SoLuong = table.Column<float>(type: "real", nullable: true),
                    GiaNhapTrungBinh = table.Column<float>(type: "real", nullable: true),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NgayCapNhat = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhoChiTiet", x => x.IdKhoChiTiet);
                    table.ForeignKey(
                        name: "FK_KhoChiTiet_ChiNhanh_IdChiNhanh",
                        column: x => x.IdChiNhanh,
                        principalTable: "ChiNhanh",
                        principalColumn: "IdChiNhanh");
                    table.ForeignKey(
                        name: "FK_KhoChiTiet_DMKho_IdDMKho",
                        column: x => x.IdDMKho,
                        principalTable: "DMKho",
                        principalColumn: "IdDMKho",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KhoChiTiet_Kho_IdKho",
                        column: x => x.IdKho,
                        principalTable: "Kho",
                        principalColumn: "IdKho");
                    table.ForeignKey(
                        name: "FK_KhoChiTiet_NhaCungCap_IdNhaCungCap",
                        column: x => x.IdNhaCungCap,
                        principalTable: "NhaCungCap",
                        principalColumn: "IdNhaCungCap",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KhoChiTiet_SanPham_IdSanPham",
                        column: x => x.IdSanPham,
                        principalTable: "SanPham",
                        principalColumn: "IdSanPham");
                });

            migrationBuilder.CreateTable(
                name: "DonHangChiTiet",
                columns: table => new
                {
                    IdDonHangSanPham = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdDonHang = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdSanPham = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: true),
                    Gia = table.Column<float>(type: "real", nullable: true),
                    TongTien = table.Column<float>(type: "real", nullable: true),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayCapNhat = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DonHangChiTiet", x => x.IdDonHangSanPham);
                    table.ForeignKey(
                        name: "FK_DonHangChiTiet_DonHang_IdDonHang",
                        column: x => x.IdDonHang,
                        principalTable: "DonHang",
                        principalColumn: "IdDonHang",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DonHangChiTiet_SanPham_IdSanPham",
                        column: x => x.IdSanPham,
                        principalTable: "SanPham",
                        principalColumn: "IdSanPham",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DMSanPham_IdDMNSanPham",
                table: "DMSanPham",
                column: "IdDMNSanPham");

            migrationBuilder.CreateIndex(
                name: "IX_DonHang_UserId",
                table: "DonHang",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_DonHangChiTiet_IdDonHang",
                table: "DonHangChiTiet",
                column: "IdDonHang");

            migrationBuilder.CreateIndex(
                name: "IX_DonHangChiTiet_IdSanPham",
                table: "DonHangChiTiet",
                column: "IdSanPham");

            migrationBuilder.CreateIndex(
                name: "IX_Kho_IdChiNhanh",
                table: "Kho",
                column: "IdChiNhanh");

            migrationBuilder.CreateIndex(
                name: "IX_KhoChiTiet_IdChiNhanh",
                table: "KhoChiTiet",
                column: "IdChiNhanh");

            migrationBuilder.CreateIndex(
                name: "IX_KhoChiTiet_IdDMKho",
                table: "KhoChiTiet",
                column: "IdDMKho");

            migrationBuilder.CreateIndex(
                name: "IX_KhoChiTiet_IdKho",
                table: "KhoChiTiet",
                column: "IdKho");

            migrationBuilder.CreateIndex(
                name: "IX_KhoChiTiet_IdNhaCungCap",
                table: "KhoChiTiet",
                column: "IdNhaCungCap");

            migrationBuilder.CreateIndex(
                name: "IX_KhoChiTiet_IdSanPham",
                table: "KhoChiTiet",
                column: "IdSanPham");

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_IdDMSanPham",
                table: "SanPham",
                column: "IdDMSanPham");

            migrationBuilder.CreateIndex(
                name: "IX_User_IdChiNhanh",
                table: "User",
                column: "IdChiNhanh");

            migrationBuilder.CreateIndex(
                name: "IX_User_RoleId",
                table: "User",
                column: "RoleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DonHangChiTiet");

            migrationBuilder.DropTable(
                name: "KhoChiTiet");

            migrationBuilder.DropTable(
                name: "DonHang");

            migrationBuilder.DropTable(
                name: "DMKho");

            migrationBuilder.DropTable(
                name: "Kho");

            migrationBuilder.DropTable(
                name: "NhaCungCap");

            migrationBuilder.DropTable(
                name: "SanPham");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "DMSanPham");

            migrationBuilder.DropTable(
                name: "ChiNhanh");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "DMNhomSanPham");
        }
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Test.Domain.Entities;

namespace Test.Infrastructure.Context
{
    public class TestDBContext : DbContext
    {
        public TestDBContext()
        {

        }

        public TestDBContext(DbContextOptions<TestDBContext> options) : base(options)
        {

        }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<SanPham> SanPham { get; set; }
        public virtual DbSet<ChiNhanh> ChiNhanhs { get; set; }
        public virtual DbSet<DMSanPham> DMSanPhams { get; set; }
        public virtual DbSet<DMNhomSanPham> DMNhomSanPhams { get; set; }
        public virtual DbSet<DMKho> DMKhos { get; set; }
        public virtual DbSet<KhoChiTiet> KhoChiTiets { get; set; }
        public virtual DbSet<Kho> Khos { get; set; }

        public virtual DbSet<DonHang>  DonHangs {get ; set;}
        public virtual DbSet<DonHangChiTiet> DonHangChiTiets { get; set; }

     
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>(e =>
            {
                e.ToTable("User");//đặt tên bảng
                e.HasKey(e => e.UserId);//cài khóa chính

                e.Property(e => e.UserId)
                .IsRequired();          //trường này ko được rỗng         

                e.Property(e => e.UserName)
                .HasMaxLength(250).HasColumnType("nvarchar");

                e.Property(e => e.Password)
                .HasMaxLength(500).HasColumnType("nvarchar");

                e.Property(e => e.Email)
                .HasMaxLength(300).HasColumnType("nvarchar");

                e.Property(e => e.AvartarUrl)
                .HasMaxLength(500).HasColumnType("nvarchar");

                e.Property(e => e.MaNV)
                .HasMaxLength(20).HasColumnType("nvarchar");

                e.Property(e => e.TenNV)
                .HasMaxLength(50).HasColumnType("nvarchar");

                e.Property(e => e.SoDienThoai)
                .HasMaxLength(12).HasColumnType("nvarchar");

                

                e.Property(e => e.DiaChi)
                .HasMaxLength(255).HasColumnType("nvarchar");

                e.Property(e => e.NgaySinh);

                e.Property(e => e.GioiTinh);

             
                e.Property(e => e.NgayTao);
                e.Property(e => e.NgayCapNhat);
             
                e.Property(e => e.IsActive);

            });
          
            modelBuilder.Entity<Role>(e =>
            {
                e.ToTable("Role");//đặt tên bảng
                e.HasKey(e => e.RoleId);//cài khóa chính

                e.Property(e => e.RoleId)
                .IsRequired();          //trường này ko được rỗng


                e.Property(e => e.TenQuyen)
                .HasMaxLength(100).HasColumnType("nvarchar");
                e.Property(e => e.MoTa)
                .HasMaxLength(255).HasColumnType("nvarchar");           
                e.Property(e => e.NgayTao);
                e.Property(e => e.NgayCapNhat);
            });
            modelBuilder.Entity<ChiNhanh>(e => {
                e.ToTable("ChiNhanh");//đặt tên bảng
                e.HasKey(e => e.IdChiNhanh);//cài khóa chính

                e.Property(e => e.IdChiNhanh)
                .IsRequired();          //trường này ko được rỗng

                e.Property(e => e.TenChiNhanh)
                .HasMaxLength(100).HasColumnType("nvarchar");
                e.Property(e => e.NgayTao);
                e.Property(e => e.NgayCapNhat);              
            });
            modelBuilder.Entity<SanPham>(e => {
                e.ToTable("SanPham");//đặt tên bảng
                e.HasKey(e => e.IdSanPham);//cài khóa chính
                e.Property(e => e.IdSanPham)
                .IsRequired();          //trường này ko được rỗng
                e.Property(e => e.TenSanPham)
                .HasMaxLength(100).HasColumnType("nvarchar");
                e.Property(e => e.GiaSanPham);
              
                e.Property(e => e.Mota)
                .HasMaxLength(500).HasColumnType("nvarchar");
                e.Property(e => e.IdImage)
                .HasMaxLength(4000).HasColumnType("nvarchar");
                e.Property(e => e.SuDung);        
                e.Property(e => e.NgayTao);
                e.Property(e => e.NgayCapNhat);
            });
            modelBuilder.Entity<DMSanPham>(e => {
                e.ToTable("DMSanPham");//đặt tên bảng
                e.HasKey(e => e.IdDMSanPham);//cài khóa chính

                e.Property(e => e.IdDMSanPham)
                .IsRequired();          //trường này ko được rỗng


                e.Property(e => e.TenDanhMucSanPham)
                .HasMaxLength(100).HasColumnType("nvarchar");

                e.Property(e => e.SuDung);
                e.Property(e => e.NgayTao);
                e.Property(e => e.NgayCapNhat);
            });
            modelBuilder.Entity<DMNhomSanPham>(e => {
                e.ToTable("DMNhomSanPham");//đặt tên bảng
                e.HasKey(e => e.IdDMNSanPham);//cài khóa chính
                e.Property(e => e.IdDMNSanPham)
                .IsRequired();          //trường này ko được rỗng
                e.Property(e => e.TenDMNhomSanPham)
                .HasMaxLength(100).HasColumnType("nvarchar");
                e.Property(e => e.MoTa);
                e.Property(e => e.SuDung);            
                e.Property(e => e.NgayTao);
                e.Property(e => e.NgayCapNhat);
            });
            modelBuilder.Entity<Kho>(e => {
                e.ToTable("Kho");//đặt tên bảng
                e.HasKey(e => e.IdKho);//cài khóa chính

                e.Property(e => e.IdKho)
                .IsRequired();          //trường này ko được rỗng

                e.Property(e => e.TenKho)
                .HasMaxLength(100).HasColumnType("nvarchar");
              
                e.Property(e => e.NgayTao);
                e.Property(e => e.NgayCapNhat);
             
            });
            modelBuilder.Entity<KhoChiTiet>(e => {
                e.ToTable("KhoChiTiet");//đặt tên bảng
                e.HasKey(e => e.IdKhoChiTiet);//cài khóa chính

                e.Property(e => e.IdKhoChiTiet)
                .IsRequired();          //trường này ko được rỗng


                e.Property(e => e.SoLuong);
                e.Property(e => e.GiaNhapTrungBinh);               
                e.Property(e => e.NgayTao);
                e.Property(e => e.NgayCapNhat);              


            });
            modelBuilder.Entity<DMSanPham>(e => {
                e.ToTable("DMSanPham");//đặt tên bảng
                e.HasKey(e => e.IdDMSanPham);//cài khóa chính

                e.Property(e => e.IdDMSanPham)
                .IsRequired();          //trường này ko được rỗng


                e.Property(e => e.TenDanhMucSanPham)
                .HasMaxLength(100).HasColumnType("nvarchar");

                e.Property(e => e.SuDung);
              
                e.Property(e => e.NgayTao);
                e.Property(e => e.NgayCapNhat);
             


            });
            modelBuilder.Entity<DMNhomSanPham>(e => {
                e.ToTable("DMNhomSanPham");//đặt tên bảng
                e.HasKey(e => e.IdDMNSanPham);//cài khóa chính

                e.Property(e => e.IdDMNSanPham)
                .IsRequired();          //trường này ko được rỗng


                e.Property(e => e.TenDMNhomSanPham)
                .HasMaxLength(100).HasColumnType("nvarchar");

                e.Property(e => e.MoTa);

                e.Property(e => e.SuDung);
               
                
                e.Property(e => e.NgayTao);
                e.Property(e => e.NgayCapNhat);
               


            });
            modelBuilder.Entity<DMKho>(e => {
                e.ToTable("DMKho");//đặt tên bảng
                e.HasKey(e => e.IdDMKho);//cài khóa chính
                e.Property(e => e.IdDMKho)
                .IsRequired();          //trường này ko được rỗng
                e.Property(e => e.KieuLoai)
                .HasMaxLength(100).HasColumnType("nvarchar");
                e.Property(e => e.TenKho)
                .HasMaxLength(255).HasColumnType("nvarchar");
                e.Property(e => e.MaKho)
               .HasMaxLength(15).HasColumnType("nvarchar");
                e.Property(e => e.IsActive);                                     
                e.Property(e => e.NgayTao);
                e.Property(e => e.NgayCapNhat);
              


            });
            modelBuilder.Entity<NhaCungCap>(e => {
                e.ToTable("NhaCungCap");//đặt tên bảng
                e.HasKey(e => e.IdNhaCungCap);//cài khóa chính

                e.Property(e => e.IdNhaCungCap)
                .IsRequired();          //trường này ko được rỗng


                e.Property(e => e.TenNhaCung)
                .HasMaxLength(100).HasColumnType("nvarchar");


                e.Property(e => e.NguoiLienHe)
                .HasMaxLength(100).HasColumnType("nvarchar");

                e.Property(e => e.SdtNguoiLienHe)
                 .HasMaxLength(12).HasColumnType("nvarchar");

                e.Property(e => e.DiaChi)
                .HasMaxLength(255).HasColumnType("nvarchar");

                e.Property(e => e.SuDung);

               
                e.Property(e => e.NgayTao);
                e.Property(e => e.NgayCapNhat);
            });
            modelBuilder.Entity<DonHang>(e => {
                e.ToTable("DonHang");
                e.HasKey(e => e.IdDonHang);

                e.Property(e => e.IdDonHang)
                .IsRequired();          

                e.Property(e => e.MaDonHang)
               .HasMaxLength(50).HasColumnType("nvarchar");
                e.Property(e => e.KieuThanhToan);

                e.Property(e => e.ThanhTien);

               

                e.Property(e => e.TenKhach)
                .HasMaxLength(50).HasColumnType("nvarchar");

                e.Property(e => e.SoDienThoaiKhach)
                .HasMaxLength(12).HasColumnType("nvarchar");
                e.Property(e => e.DiaChi)
                .HasMaxLength(250).HasColumnType("nvarchar");


                e.Property(e => e.GhiChuDonHang)
                .HasMaxLength(500).HasColumnType("nvarchar");
          
                e.Property(e => e.NgayTao);
                e.Property(e => e.NgayCapNhat);
              


            });
            modelBuilder.Entity<DonHangChiTiet>(e => {
                e.ToTable("DonHangChiTiet");//đặt tên bảng
                e.HasKey(e => e.IdDonHangSanPham);//cài khóa chính
                e.Property(e => e.IdDonHangSanPham)
                .IsRequired();          //trường này ko được rỗng
                e.Property(e => e.SoLuong);
                e.Property(e => e.Gia);
                e.Property(e => e.TongTien);
                e.Property(e => e.NgayTao);
                e.Property(e => e.NgayCapNhat);
            });
           
        }
        }
    
}

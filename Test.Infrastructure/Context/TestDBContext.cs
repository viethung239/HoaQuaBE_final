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

        public virtual DbSet<PhieuNhap> PhieuNhaps { get; set; }

        public virtual DbSet<PhieuXuat> PhieuXuats { get; set; }
        public virtual DbSet<PhieuNhapSanPham> PhieuNhapSanPhams { get; set; }
        public virtual DbSet<PhieuXuatSanPham> PhieuXuatSanPhams { get; set; }
        public virtual DbSet<PhieuChuyenKho> PhieuChuyenKhos { get; set; }
        public virtual DbSet<PhieuChuyenKhoSanPham> PhieuChuyenKhoSanPhams { get; set; }
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
                e.Property(e => e.GiaNhapVao);
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
            modelBuilder.Entity<PhieuNhap>(e => {
                e.ToTable("PhieuNhap");//đặt tên bảng
                e.HasKey(e => e.IdPhieuNhap);//cài khóa chính

                e.Property(e => e.IdPhieuNhap)
                .IsRequired();          //trường này ko được rỗng
                e.Property(e => e.NgayNhap);

                e.Property(e => e.GhiChu)
                 .HasMaxLength(500).HasColumnType("nvarchar");
                e.Property(e => e.TongGiaNhap);          
                e.Property(e => e.NgayTao);
                e.Property(e => e.NgayCapNhat);
            });
            modelBuilder.Entity<PhieuXuat>(e => {
                e.ToTable("PhieuXuat");//đặt tên bảng
                e.HasKey(e => e.IdPhieuXuat);//cài khóa chính

                e.Property(e => e.IdPhieuXuat)
                .IsRequired();          //trường này ko được rỗng

                e.Property(e => e.NgayXuat);

                e.Property(e => e.GhiChu)
                 .HasMaxLength(500).HasColumnType("nvarchar");          
                e.Property(e => e.NgayTao);
                e.Property(e => e.NgayCapNhat);
 
            });
            modelBuilder.Entity<PhieuNhapSanPham>(e => {
                e.ToTable("PhieuNhapSanPham");//đặt tên bảng
                e.HasKey(e => e.IdPhieuNhapSanPham);//cài khóa chính

                e.Property(e => e.IdPhieuNhapSanPham)
                .IsRequired();          //trường này ko được rỗng

                e.Property(e => e.GiaNhap);
                e.Property(e => e.SoLuong);
                e.Property(e => e.TongTien);

                e.Property(e => e.SoLuongTruoc);

                e.Property(e => e.SoLuongSau);







               
                e.Property(e => e.NgayTao);
                e.Property(e => e.NgayCapNhat);
             


            });
            modelBuilder.Entity<PhieuXuatSanPham>(e => {
                e.ToTable("PhieuXuatSanPham");//đặt tên bảng
                e.HasKey(e => e.IdPhieuXuatSanPham);//cài khóa chính

                e.Property(e => e.IdPhieuXuatSanPham)
                .IsRequired();          //trường này ko được rỗng


                e.Property(e => e.SoLuong);

                e.Property(e => e.SoLuongTruoc);
                e.Property(e => e.SoLuongSau);
                e.Property(e => e.Gia);


                e.Property(e => e.TongTien);



               
                e.Property(e => e.NgayTao);
                e.Property(e => e.NgayCapNhat);
              


            });
            modelBuilder.Entity<PhieuChuyenKhoSanPham>(e => {
                e.ToTable("PhieuChuyenKhoSanPham");//đặt tên bảng
                e.HasKey(e => e.IdPhieuChuyenKhoSanPham);//cài khóa chính

                e.Property(e => e.IdPhieuChuyenKhoSanPham)
                .IsRequired();          //trường này ko được rỗng


                e.Property(e => e.SoLuong);


                e.Property(e => e.Gia);

                e.Property(e => e.TongTien);
                e.Property(e => e.IdTuKho);
                e.Property(e => e.IdDenKho);
                e.Property(e => e.IdTuChiNhanh);
                e.Property(e => e.IdDenChiNhanh);
                e.Property(e => e.SoLuongTruocTuKho);

                e.Property(e => e.SoLuongSauTuKho);

                e.Property(e => e.SoLuongTruocDenKho);
                e.Property(e => e.SoLuongSauDenKho);

              

               
                e.Property(e => e.NgayTao);
                e.Property(e => e.NgayCapNhat);
               

            });
            modelBuilder.Entity<PhieuChuyenKho>(e => {
                e.ToTable("PhieuChuyenKho");//đặt tên bảng
                e.HasKey(e => e.IdPhieuChuyenKho);//cài khóa chính

                e.Property(e => e.IdPhieuChuyenKho)
                .IsRequired();          //trường này ko được rỗng


               

                e.Property(e => e.NgayChuyenKho);

                e.Property(e => e.GhiChu)
                 .HasMaxLength(500).HasColumnType("nvarchar");

                e.Property(e => e.TongGiaTri);

                e.Property(e => e.IdTuKho);
                e.Property(e => e.IdDenKho);
                e.Property(e => e.IdTuChiNhanh);
                e.Property(e => e.IdDenChiNhanh);


                e.Property(e => e.NgayTao);
                e.Property(e => e.NgayCapNhat);
              


            });
        }
        }
    
}

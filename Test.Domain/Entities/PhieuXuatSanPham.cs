using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Domain.Entities
{
    public class PhieuXuatSanPham
    {
        public Guid IdPhieuXuatSanPham { get; set; }
        public Guid? IdPhieuXuat { get; set; }
        public Guid? IdSanPham { get; set; }
        public float? SoLuong { get; set; }
        public Guid? IdChiNhanh { get; set; }
        public Guid? IdDMNSanPham { get; set; }

        public Guid? IdKho { get; set; }
        public float? SoLuongTruoc { get; set; }
        public float? SoLuongSau { get; set; }
        public float? Gia { get; set; }
        public float? GiaNhap { get; set; }
        public DateTime? NgayTao { get; set; }
        public DateTime? NgayCapNhat { get; set; }


        //
        [ForeignKey("IdPhieuXuat")]
        public PhieuXuat PhieuXuat { get; set; }
        [ForeignKey("IdSanPham")]
        public SanPham SanPham { get; set; }
        [ForeignKey("IdChiNhanh")]
        public ChiNhanh ChiNhanh { get; set; }
        [ForeignKey("IdDMNSanPham")]
        public DMNhomSanPham DMNSanPham { get; set; }
        [ForeignKey("IdKho")]
        public Kho Kho { get; set; }
    }
}

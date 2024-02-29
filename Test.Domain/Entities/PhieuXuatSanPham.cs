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
   

        public Guid? IdKhoChiTiet { get; set; }
        public float? SoLuongTruoc { get; set; }
        public float? SoLuongSau { get; set; }
        public float? Gia { get; set; }
        public float? TongTien { get; set; }
        public DateTime? NgayTao { get; set; }
        public DateTime? NgayCapNhat { get; set; }


        //
        [ForeignKey("IdPhieuXuat")]
        public PhieuXuat PhieuXuat { get; set; }
        [ForeignKey("IdSanPham")]
        public SanPham SanPham { get; set; }
        
        

        [ForeignKey("IdKhoChiTiet")]
        public KhoChiTiet KhoChiTiet { get; set; }
    }
}

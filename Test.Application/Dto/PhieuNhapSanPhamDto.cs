using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Application.Dto
{
    public class PhieuNhapSanPhamDto
    {
        public Guid IdPhieuNhapSanPham { get; set; }
        public Guid? IdPhieuNhap { get; set; }
        public Guid? IdSanPham { get; set; }
        public float? GiaNhap { get; set; }
        public float? SoLuong { get; set; }
        public float? TongTien { get; set; }

        public Guid? IdKhoChiTiet { get; set; }

        public float? SoLuongTruoc { get; set; }
        public float? SoLuongSau { get; set; }

        public DateTime? NgayTao { get; set; }
        public DateTime? NgayCapNhat { get; set; }
    }
}

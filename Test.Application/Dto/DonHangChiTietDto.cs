using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Application.Dto
{
    public class DonHangChiTietDto
    {
        public Guid IdDonHangSanPham { get; set; }
        public Guid IdDonHang { get; set; }
        public Guid IdSanPham { get; set; }
        public int? SoLuong { get; set; }

        public float? Gia { get; set; }
        public float? TongTien { get; set; }

        public DateTime NgayTao { get; set; }
        public DateTime NgayCapNhat { get; set; }
    }
}

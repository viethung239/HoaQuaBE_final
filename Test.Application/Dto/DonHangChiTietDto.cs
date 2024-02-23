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
        public float DonGia { get; set; }
        public float ThanhTien { get; set; }
        public Guid IdChiNhanh { get; set; }
        public DateTime NgayTao { get; set; }
        public DateTime NgayCapNhat { get; set; }
    }
}

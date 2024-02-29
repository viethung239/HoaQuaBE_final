using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Application.Dto
{
    public class DonHangDto
    {
        public Guid IdDonHang { get; set; }
        public Guid UserId { get; set; }
        public float ThanhTien { get; set; }
        public string? MaDonHang { get; set; }

        public int? KieuThanhToan { get; set; }
        public string? TenKhach { get; set; }
        public string? SoDienThoaiKhach { get; set; }
        public string? DiaChi { get; set; }
        public string? GhiChuDonHang { get; set; }
        public DateTime NgayTao { get; set; }
        public DateTime NgayCapNhat { get; set; }

    }
}

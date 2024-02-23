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
        public Guid IdChiNhanh { get; set; }
        public Guid UserId { get; set; }
        public float ThanhTien { get; set; }
        public DateTime NgayThanhToan { get; set; }
        public string? TenKhach { get; set; }
        public string? SoDienThoaiKhach { get; set; }
        public string? GhiChuDonHang { get; set; }
        public DateTime NgayTao { get; set; }
        public DateTime NgayCapNhat { get; set; }
    }
}

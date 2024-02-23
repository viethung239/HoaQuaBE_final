using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Application.Dto
{
    public class PhieuXuatDto
    {
        public Guid IdPhieuXuat { get; set; }
        public Guid? UserId { get; set; }
        public Guid? IdKho { get; set; }
        public DateTime? NgayXuat { get; set; }
        public string? GhiChu { get; set; }
        public Guid? IdChiNhanh { get; set; }
        public Guid? IdDonHang { get; set; }
        public DateTime? NgayTao { get; set; }
        public DateTime? NgayCapNhat { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Application.Dto
{
    public class PhieuNhapDto
    {
        public Guid IdPhieuNhap { get; set; }
        public Guid? IdNhaCungCap { get; set; }
        public Guid? IdKho { get; set; }
        public Guid? IdChiNhanh { get; set; }
        public DateTime? NgayNhap { get; set; }
        public string? GhiChu { get; set; }
        public float? TongGiaNhap { get; set; }

        public DateTime? NgayTao { get; set; }
        public DateTime? NgayCapNhat { get; set; }
    }
}

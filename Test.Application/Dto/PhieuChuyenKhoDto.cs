using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Application.Dto
{
    public class PhieuChuyenKhoDto
    {
        public Guid IdPhieuChuyenKho { get; set; }
        public DateTime? NgayChuyenKho { get; set; }

        public Guid? IdTuKho { get; set; }
        public Guid? IdDenKho { get; set; }

        public string? GhiChu { get; set; }
        public float? TongGiaTri { get; set; }
        public Guid? IdTuChiNhanh { get; set; }
        public Guid? IdDenChiNhanh { get; set; }

        public DateTime? NgayTao { get; set; }
        public DateTime? NgayCapNhat { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Application.Dto
{
    public class KhoChiTietDto
    {
        public Guid IdKhoChiTiet { get; set; }
        public Guid? IdKho { get; set; }
        public Guid IdDMKho { get; set; }
        public Guid? IdChiNhanh { get; set; }
        public Guid? IdSanPham { get; set; }
        public Guid IdNhaCungCap { get; set; }
        public float? SoLuong { get; set; }
        public float? GiaNhapTrungBinh { get; set; }
        public DateTime? NgayTao { get; set; }
        public DateTime? NgayCapNhat { get; set; }
    }
}

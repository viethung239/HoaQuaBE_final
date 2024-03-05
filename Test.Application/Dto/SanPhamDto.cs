using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Application.Dto
{
    public class SanPhamDto
    {
        public Guid IdSanPham { get; set; }

        public Guid? IdDMSanPham { get; set; }
        public string? TenSanPham { get; set; }
        public float? GiaSanPham { get; set; }
   
        public string? Mota { get; set; }
        public string? IdImage { get; set; }
        public bool? SuDung { get; set; }
        public DateTime? NgayTao { get; set; }
        public DateTime? NgayCapNhat { get; set; }
    }
}

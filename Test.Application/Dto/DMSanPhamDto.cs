using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Application.Dto
{
    public class DMSanPhamDto
    {
        public Guid IdDMSanPham { get; set; }
        public Guid? IdDMNSanPham { get; set; }
        public string? TenDanhMucSanPham { get; set; }
        public bool? SuDung { get; set; }

        public DateTime? NgayTao { get; set; }
        public DateTime? NgayCapNhat { get; set; }

    }
}

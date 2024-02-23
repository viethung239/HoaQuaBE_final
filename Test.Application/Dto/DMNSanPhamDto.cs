using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Application.Dto
{
    public class DMNSanPhamDto
    {
        public Guid IdDMNSanPham { get; set; }

        public string? TenDMNhomSanPham { get; set; }

        public string? MoTa { get; set; }


        public bool? SuDung { get; set; }

        public DateTime? NgayTao { get; set; }
        public DateTime? NgayCapNhat { get; set; }
    }
}

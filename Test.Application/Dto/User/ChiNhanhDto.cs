using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Application.Dto.User
{
    public class ChiNhanhDto
    {
        public Guid IdChiNhanh { get; set; }
        public string? TenChiNhanh { get; set; }
        public DateTime? NgayTao { get; set; }
        public DateTime? NgayCapNhat { get; set; }
    }
}

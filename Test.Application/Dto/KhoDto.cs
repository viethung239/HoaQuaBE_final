using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Application.Dto
{
    public class KhoDto
    {
        public Guid IdKho { get; set; }
        public Guid? IdChiNhanh { get; set; }
        public string? TenKho { get; set; }
        public DateTime? NgayTao { get; set; }
        public DateTime? NgayCapNhat { get; set; }
    }
}

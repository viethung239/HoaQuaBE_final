using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Domain.Entities
{
    public class DMKho
    {
        public Guid IdDMKho { get; set; }
        public string? KieuLoai { get; set; }
        public string? TenKho { get; set; }
        public string? MaKho { get; set; }

        public bool? IsActive { get; set; }
       
        public DateTime? NgayTao { get; set; }
        public DateTime? NgayCapNhat { get; set; }

        //
        public ICollection<KhoChiTiet> KhoChiTiets { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Domain.Entities
{
    public class DMNhomSanPham
    {
        public Guid IdDMNSanPham { get; set; }

        public string? TenDMNhomSanPham { get; set; }

        public string? MoTa { get; set; }


        public bool? SuDung { get; set; }
      
        public DateTime? NgayTao { get; set; }
        public DateTime? NgayCapNhat { get; set; }
     
      
    
        public ICollection<DMSanPham> DMSanPhams { get; set; }
        public ICollection<PhieuNhapSanPham> PhieuNhapSanPhams { get; set; }
        public ICollection<PhieuXuatSanPham> PhieuXuatSanPhams { get; set; }
    }
}

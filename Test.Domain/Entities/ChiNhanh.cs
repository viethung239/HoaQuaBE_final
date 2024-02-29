using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Domain.Entities
{
    public class ChiNhanh
    {
        public Guid IdChiNhanh { get; set; }
        public string? TenChiNhanh { get; set; }
        public DateTime? NgayTao { get; set; }
        public DateTime? NgayCapNhat { get; set; }

        //


        //
        public ICollection<User>? Users { get; set; }
        public ICollection<KhoChiTiet> KhoChiTiets { get; set; }
      
        public ICollection<Kho> khos { get; set; }
     
        public ICollection<PhieuNhap> PhieuNhaps { get; set; }
        public ICollection<PhieuXuat> PhieuXuats { get; set; }
       
        
    }
}

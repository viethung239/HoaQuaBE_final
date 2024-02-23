using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Domain.Entities
{
    public class DMSanPham
    {
        public Guid IdDMSanPham { get; set; }
        public Guid? IdDMNSanPham { get; set; }
        public string? TenDanhMucSanPham { get; set; }
        public bool? SuDung { get; set; }
     
        public DateTime? NgayTao { get; set; }
        public DateTime? NgayCapNhat { get; set; }

        //

        [ForeignKey("IdDMNSanPham")]
        public DMNhomSanPham DMNhomSanPham { get; set; }
        //
        public ICollection<SanPham> SanPham { get; set; }
    }
}

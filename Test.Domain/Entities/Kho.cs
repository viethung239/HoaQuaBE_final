using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Domain.Entities
{
    public class Kho
    {
        public Guid IdKho { get; set; }
        public Guid? IdChiNhanh { get; set; }
        public string? TenKho { get; set; }
        public DateTime? NgayTao { get; set; }
        public DateTime? NgayCapNhat { get; set; }

        //
        [ForeignKey("IdChiNhanh")]
        public ChiNhanh ChiNhanh { get; set; }

        //

        public ICollection<KhoChiTiet> KhoChiTiets { get; set; }
      
     

        
    }
}

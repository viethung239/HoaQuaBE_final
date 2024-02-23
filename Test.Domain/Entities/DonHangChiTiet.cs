using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Domain.Entities
{
    public class DonHangChiTiet
    {
        public Guid IdDonHangSanPham { get; set; }
        public Guid IdDonHang { get; set; }
        public Guid IdSanPham { get; set; }
        public float DonGia { get; set; }
        public float ThanhTien { get; set; }
    
        public DateTime NgayTao { get; set; }
        public DateTime NgayCapNhat { get; set; }
        //
        [ForeignKey("IdDonHang")]
        public DonHang DonHang { get; set; }

        [ForeignKey("IdSanPham")]
        public SanPham SanPham { get; set; }
        
    }
}

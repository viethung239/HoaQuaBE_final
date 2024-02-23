using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Domain.Entities
{
    public class PhieuXuat
    {
        public Guid IdPhieuXuat { get; set; }    
        public Guid? UserId { get; set; }
        public Guid? IdKho { get; set; }
        public DateTime? NgayXuat { get; set; }
        public string? GhiChu { get; set; }
        public Guid? IdChiNhanh { get; set; }
        public Guid? IdDonHang { get; set; }
        public DateTime? NgayTao { get; set; }
        public DateTime? NgayCapNhat { get; set; }

        //
        [ForeignKey("UserId")]
        public User User { get; set; }

        [ForeignKey("IdKho")]
        public Kho Kho { get; set; }
        [ForeignKey("IdChiNhanh")]
        public ChiNhanh ChiNhanh { get; set; }

        [ForeignKey("IdDonHang")]
        public DonHang DonHang { get; set; }
        //

        public ICollection<PhieuXuatSanPham> PhieuXuatSanPhams { get; set; }
    }
}

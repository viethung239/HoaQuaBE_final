using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Domain.Entities
{
    public class PhieuNhap
    {
        public Guid IdPhieuNhap { get; set; }
        public Guid? IdNhaCungCap { get; set; }
        public Guid? IdKho { get; set; }
        public Guid? IdChiNhanh { get; set; }
        public DateTime? NgayNhap { get; set; }
        public string? GhiChu { get; set; }
        public float? TongGiaNhap { get; set; }

        public DateTime? NgayTao { get; set; }
        public DateTime? NgayCapNhat { get; set; }

        //

        [ForeignKey("IdNhaCungCap")]
        public NhaCungCap NhaCungCap { get; set; }

        [ForeignKey("IdKho")]
        public Kho Kho { get; set; }

        [ForeignKey("IdChiNhanh")]
        public ChiNhanh ChiNhanh { get; set; }

        //
        public ICollection<PhieuNhapSanPham> PhieuNhapSanPhams { get; set; }

    }
}

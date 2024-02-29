using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Domain.Entities
{
    public class KhoChiTiet
    {
        public Guid IdKhoChiTiet { get; set; }
        public Guid? IdKho { get; set; }
        public Guid IdDMKho { get; set; }
        public Guid? IdChiNhanh { get; set; }
        public Guid? IdSanPham { get; set; }
        public Guid IdNhaCungCap { get; set; }
        public float? SoLuong { get; set; }
        public float? GiaNhapTrungBinh { get; set; }
        public DateTime? NgayTao { get; set; }
        public DateTime? NgayCapNhat { get; set; }

        //
        [ForeignKey("IdKho")]
        public Kho Kho { get; set; }

        [ForeignKey("IdChiNhanh")]
        public ChiNhanh ChiNhanh { get; set; }

        [ForeignKey("IdSanPham")]
        public SanPham SanPham { get; set; }

        [ForeignKey("IdNhaCungCap")]
        public NhaCungCap NhaCungCap { get; set; }

        [ForeignKey("IdDMKho")]
        public DMKho DMKho{ get; set; }
        //
        public ICollection<PhieuNhapSanPham> PhieuNhapSanPhams { get; set; }
        public ICollection<PhieuXuatSanPham> PhieuXuatSanPhams { get; set; }
    }
}

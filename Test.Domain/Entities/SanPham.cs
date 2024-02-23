using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Domain.Entities
{
    public class SanPham
    {
        public Guid IdSanPham { get; set; }
     
        public Guid? IdDMSanPham { get; set; }
        public string? TenSanPham { get; set; }
        public float? GiaSanPham { get; set; }
        public float? GiaNhapVao { get; set; }
        public string? Mota { get; set; }
        public string? IdImage { get; set; }
        public bool? SuDung { get; set; } 
        public DateTime? NgayTao { get; set; }
        public DateTime? NgayCapNhat { get; set; }

        //

        [ForeignKey("IdDMSanPham")]
        public DMSanPham DMSanPham { get; set; }
        //
        public ICollection<KhoChiTiet> KhoChiTiets { get; set; }
        public ICollection<DonHangChiTiet> DonHangChiTiets { get; set; }

        public ICollection<PhieuNhapSanPham> PhieuNhapSanPhams { get; set; }
        public ICollection<PhieuXuatSanPham> PhieuXuatSanPhams { get; set; }
        public ICollection<PhieuChuyenKhoSanPham> PhieuChuyenKhoSanPhams { get; set; }
    }
}

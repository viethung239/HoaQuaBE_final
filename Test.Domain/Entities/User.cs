using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Domain.Entities
{
    public class User
    {
        public Guid UserId { get; set; }
        public Guid? IdChiNhanh { get; set; }
        public Guid? RoleId { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
        public string? AvartarUrl { get; set; }
        public string? MaNV { get; set; }
        public string? TenNV { get; set; }
        public string? SoDienThoai { get; set; }
        public string? DiaChi { get; set; }
        public DateTime? NgaySinh { get; set; }
        public int? GioiTinh { get; set; }
        public DateTime? NgayTao { get; set; }
        public DateTime? NgayCapNhat { get; set; }
        public bool? IsActive { get; set; }

        //

        [ForeignKey("RoleId")]
        public Role Role { get; set; }

        [ForeignKey("IdChiNhanh")]
        public ChiNhanh ChiNhanh { get; set;}
        //
        public ICollection<DonHang> DonHangs { get; set; }

      
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Domain.Entities;

namespace Test.Application.Dto.User
{
    public class UserDto
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
        public int GioiTinh { get; set; }
        public DateTime? NgayTao { get; set; }
        public DateTime? NgayCapNhat { get; set; }
        public bool? IsActive { get; set; }

       


    }
}

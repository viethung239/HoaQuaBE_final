﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Application.Dto
{
    public class NhaCungCapDto
    {
        public Guid IdNhaCungCap { get; set; }
        public string? TenNhaCung { get; set; }
        public string? NguoiLienHe { get; set; }
        public string? SdtNguoiLienHe { get; set; }
        public string? DiaChi { get; set; }
        public string? Email { get; set; }
        public bool SuDung { get; set; }
        public DateTime NgayTao { get; set; }
        public DateTime NgayCapNhat { get; set; }
    }
}

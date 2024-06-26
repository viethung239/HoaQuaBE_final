﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Application.Dto
{
    public class PhieuChuyenKhoSanPhamDto
    {
        public Guid IdPhieuChuyenKhoSanPham { get; set; }
        public Guid? IdPhieuChuyenKho { get; set; }
        public Guid? IdSanPham { get; set; }
        public float? SoLuong { get; set; }
        public float? Gia { get; set; }
        public float? TongTien { get; set; }
        public Guid? IdTuChiNhanh { get; set; }

        public Guid? IdDenChiNhanh { get; set; }

        public Guid? IdTuKho { get; set; }

        public Guid? IdDenKho { get; set; }

        public float? SoLuongTruocTuKho { get; set; }
        public float? SoLuongSauTuKho { get; set; }
        public float? SoLuongTruocDenKho { get; set; }
        public float? SoLuongSauDenKho { get; set; }

        public DateTime? NgayTao { get; set; }
        public DateTime? NgayCapNhat { get; set; }
    }
}

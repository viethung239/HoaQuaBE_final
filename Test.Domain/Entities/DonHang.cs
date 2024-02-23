﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Domain.Entities
{
    public class DonHang
    {
        public Guid IdDonHang { get; set; }
        public Guid IdChiNhanh { get; set; }
        public Guid UserId { get; set; }
        public float ThanhTien { get; set; }    
        public DateTime NgayThanhToan { get; set; }
        public string? TenKhach { get; set; }
        public string? SoDienThoaiKhach { get; set; }
        public string? GhiChuDonHang { get; set; }
        public DateTime NgayTao { get; set; }
        public DateTime NgayCapNhat { get; set; }

        [ForeignKey("IdChiNhanh")]
        public ChiNhanh ChiNhanh { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }

        //
        public ICollection<DonHangChiTiet> DonHangChiTiets { get; set; }
        public ICollection<PhieuXuat> PhieuXuats { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Domain.Entities
{
    public class Role
    {
        public Guid RoleId { get; set; }
        public string? TenQuyen { get; set; }
        public string? MoTa { get; set; }   
        public DateTime? NgayTao { get; set; }
        public DateTime? NgayCapNhat { get; set; }   
        

        //

        //
        public ICollection<User>? Users { get; set; }
    }
}

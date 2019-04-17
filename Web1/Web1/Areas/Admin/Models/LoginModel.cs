using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Web1.Areas.Admin.Models
{
    public class LoginModel
    {
        [Required]
        public string Taikhoan { get; set; }

        public string Matkhau { get; set; }

        public bool Luu { get; set; }
    }
}
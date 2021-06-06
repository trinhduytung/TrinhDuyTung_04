using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrinhDuyTung_04.Models
{
    public class NhanVien
    {
        [Key]
        public string MaNhanVien { get; set; }
        public string TenNhanVien { get; set; }
        public string TenTinhThanh { get; set; }
    }
}
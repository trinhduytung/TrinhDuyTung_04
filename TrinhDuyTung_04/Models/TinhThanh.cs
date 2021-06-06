using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrinhDuyTung_04.Models
{
    public class TinhThanh
    {
        [Key]
        public string MaTinhThanh{ get; set; }
        public string TenTinhThanh { get; set; }
    }
}
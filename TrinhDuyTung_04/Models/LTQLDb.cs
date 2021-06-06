namespace TrinhDuyTung_04.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class LTQLDb : DbContext
    {
        public virtual DbSet<TinhThanh> MaTinhThanhs { get; set; }
        public virtual DbSet<NhanVien> MaNhanViens { get; set; }
        public LTQLDb()
            : base("name=LTQLDb1")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}

namespace TrinhDuyTung_04.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addtable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NhanViens",
                c => new
                    {
                        MaNhanVien = c.String(nullable: false, maxLength: 128),
                        TenNhanVien = c.String(),
                        TenTinhThanh = c.String(),
                    })
                .PrimaryKey(t => t.MaNhanVien);
            
            CreateTable(
                "dbo.TinhThanhs",
                c => new
                    {
                        MaTinhThanh = c.String(nullable: false, maxLength: 128),
                        TenTinhThanh = c.String(),
                    })
                .PrimaryKey(t => t.MaTinhThanh);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TinhThanhs");
            DropTable("dbo.NhanViens");
        }
    }
}

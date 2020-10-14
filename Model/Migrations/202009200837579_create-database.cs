namespace Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class createdatabase : DbMigration
    {
        public override void Up()
        {
            //CreateTable(
            //    "dbo.AdminAccount",
            //    c => new
            //    {
            //        id = c.Int(nullable: false, identity: true),
            //        userName = c.String(nullable: false, maxLength: 50, unicode: false),
            //        password = c.String(nullable: false, maxLength: 100, unicode: false),
            //        status = c.Boolean(),
            //        name = c.String(maxLength: 100),
            //        phoneNumber = c.String(maxLength: 10, fixedLength: true, unicode: false),
            //        email = c.String(maxLength: 100, unicode: false),
            //    })
            //    .PrimaryKey(t => t.id);

            //CreateTable(
            //    "dbo.CategoryNew",
            //    c => new
            //    {
            //        id = c.Int(nullable: false, identity: true),
            //        name = c.String(nullable: false, maxLength: 150),
            //    })
            //    .PrimaryKey(t => t.id);

            //CreateTable(
            //    "dbo.New",
            //    c => new
            //    {
            //        id = c.Int(nullable: false, identity: true),
            //        name = c.String(nullable: false, maxLength: 250),
            //        title = c.String(nullable: false, maxLength: 200),
            //        metaTitle = c.String(nullable: false, maxLength: 150),
            //        content = c.String(nullable: false, storeType: "ntext"),
            //        images = c.String(maxLength: 150, unicode: false),
            //        attachFile = c.String(maxLength: 150),
            //        createdDate = c.DateTime(),
            //        createdBy = c.String(maxLength: 100, unicode: false),
            //        modifyDate = c.DateTime(),
            //        modifyBy = c.String(maxLength: 100, unicode: false),
            //        newView = c.Int(),
            //        categoryId = c.Int(),
            //    })
            //    .PrimaryKey(t => t.id)
            //    .ForeignKey("dbo.CategoryNew", t => t.categoryId)
            //    .Index(t => t.categoryId);

            //CreateTable(
            //    "dbo.Notice",
            //    c => new
            //    {
            //        id = c.Int(nullable: false, identity: true),
            //        name = c.String(nullable: false, maxLength: 250),
            //        title = c.String(nullable: false, maxLength: 200),
            //        metaTitle = c.String(nullable: false, maxLength: 150),
            //        description = c.String(nullable: false, maxLength: 500),
            //        content = c.String(nullable: false, storeType: "ntext"),
            //        images = c.String(maxLength: 150, unicode: false),
            //        attachFile = c.String(maxLength: 150),
            //        createdDate = c.DateTime(),
            //        createdBy = c.String(maxLength: 100, unicode: false),
            //        modifyDate = c.DateTime(),
            //        modifyBy = c.String(maxLength: 100, unicode: false),
            //        newView = c.Int(),
            //        categoryId = c.Int(),
            //    })
            //    .PrimaryKey(t => t.id)
            //    .ForeignKey("dbo.CategoryNew", t => t.categoryId)
            //    .Index(t => t.categoryId);
            //DropTable("dbo.Menu");
            //CreateTable(
            //    "dbo.Menu",
            //    c => new
            //    {
            //        id = c.Int(nullable: false, identity: true),
            //        text = c.String(nullable: false, maxLength: 150),
            //        link = c.String(nullable: false, maxLength: 100, unicode: false),
            //        displayOrder = c.String(maxLength: 100),
            //        typeMenu = c.Int(nullable: false),
            //    })
            //    .PrimaryKey(t => t.id);

            //CreateTable(
            //    "dbo.SubMenu",
            //    c => new
            //    {
            //        id = c.Int(nullable: false, identity: true),
            //        text = c.String(nullable: false, maxLength: 150),
            //        link = c.String(nullable: false, maxLength: 100, unicode: false),
            //        displayOrder = c.String(maxLength: 100),
            //        typeMenu = c.Int(),
            //    })
            //    .PrimaryKey(t => t.id)
            //    .ForeignKey("dbo.Menu", t => t.typeMenu)
            //    .Index(t => t.typeMenu);
            AddColumn("dbo.CategoryNew", "metaTitle", c => c.String());
        }

        public override void Down()
        {
            DropForeignKey("dbo.Notice", "categoryId", "dbo.CategoryNew");
            DropForeignKey("dbo.New", "categoryId", "dbo.CategoryNew");
            DropIndex("dbo.Notice", new[] { "categoryId" });
            DropIndex("dbo.New", new[] { "categoryId" });
            DropTable("dbo.Menu");
            DropTable("dbo.Notice");
            DropTable("dbo.New");
            DropTable("dbo.CategoryNew");
            DropTable("dbo.AdminAccount");
        }
    }
}

namespace EgzaminBook.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        AuthorsId = c.Int(nullable: false),
                        NameProdactionId = c.Int(nullable: false),
                        NumberOfPages = c.Int(nullable: false),
                        GenreId = c.Int(nullable: false),
                        YearOfPublishing = c.Int(nullable: false),
                        Cost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PriceOfSale = c.Decimal(nullable: false, precision: 18, scale: 2),
                        WhetherTheBookIsASequel = c.String(nullable: false, maxLength: 3),
                        ReservationId = c.Int(nullable: false),
                        Novetly = c.String(nullable: false, maxLength: 3),
                        SaleId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Authors", t => t.AuthorsId, cascadeDelete: true)
                .ForeignKey("dbo.Genres", t => t.GenreId, cascadeDelete: true)
                .ForeignKey("dbo.NameProdactions", t => t.NameProdactionId, cascadeDelete: true)
                .ForeignKey("dbo.Reservations", t => t.ReservationId, cascadeDelete: true)
                .ForeignKey("dbo.Sales", t => t.SaleId)
                .Index(t => t.AuthorsId)
                .Index(t => t.NameProdactionId)
                .Index(t => t.GenreId)
                .Index(t => t.ReservationId)
                .Index(t => t.SaleId);
            
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.NameProdactions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerId = c.Int(nullable: false),
                        BookId = c.Int(nullable: false),
                        CountBook = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.CustomerId);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                        Phone = c.String(),
                        TotalSum = c.Int(nullable: false),
                        NumberRegister = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.RegisterClients", t => t.NumberRegister)
                .Index(t => t.NumberRegister);
            
            CreateTable(
                "dbo.RegisterClients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Login = c.String(),
                        Password = c.String(),
                        DiscountId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Discounts", t => t.DiscountId, cascadeDelete: true)
                .Index(t => t.DiscountId);
            
            CreateTable(
                "dbo.Discounts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        PrecentDiscount = c.Int(nullable: false),
                        TotalSum = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Sales",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        DiscountSale = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerId = c.Int(nullable: false),
                        BookId = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Books", t => t.BookId, cascadeDelete: true)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: false)
                .Index(t => t.CustomerId)
                .Index(t => t.BookId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Orders", "BookId", "dbo.Books");
            DropForeignKey("dbo.Books", "SaleId", "dbo.Sales");
            DropForeignKey("dbo.Books", "ReservationId", "dbo.Reservations");
            DropForeignKey("dbo.Reservations", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Customers", "NumberRegister", "dbo.RegisterClients");
            DropForeignKey("dbo.RegisterClients", "DiscountId", "dbo.Discounts");
            DropForeignKey("dbo.Books", "NameProdactionId", "dbo.NameProdactions");
            DropForeignKey("dbo.Books", "GenreId", "dbo.Genres");
            DropForeignKey("dbo.Books", "AuthorsId", "dbo.Authors");
            DropIndex("dbo.Orders", new[] { "BookId" });
            DropIndex("dbo.Orders", new[] { "CustomerId" });
            DropIndex("dbo.RegisterClients", new[] { "DiscountId" });
            DropIndex("dbo.Customers", new[] { "NumberRegister" });
            DropIndex("dbo.Reservations", new[] { "CustomerId" });
            DropIndex("dbo.Books", new[] { "SaleId" });
            DropIndex("dbo.Books", new[] { "ReservationId" });
            DropIndex("dbo.Books", new[] { "GenreId" });
            DropIndex("dbo.Books", new[] { "NameProdactionId" });
            DropIndex("dbo.Books", new[] { "AuthorsId" });
            DropTable("dbo.Orders");
            DropTable("dbo.Sales");
            DropTable("dbo.Discounts");
            DropTable("dbo.RegisterClients");
            DropTable("dbo.Customers");
            DropTable("dbo.Reservations");
            DropTable("dbo.NameProdactions");
            DropTable("dbo.Genres");
            DropTable("dbo.Books");
            DropTable("dbo.Authors");
        }
    }
}

namespace EgzaminBook.Migrations
{
    using EgzaminBook.Data.Entities;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EgzaminBook.Data.AppContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EgzaminBook.Data.AppContext context)
        {
            IList<Discount> discounts = new List<Discount>()
            {
                new Discount { Id = 1, Name = "1", PrecentDiscount = 5, TotalSum = 100 },
                new Discount { Id = 2, Name = "2", PrecentDiscount = 10, TotalSum = 200 },
                new Discount { Id = 3, Name = "3", PrecentDiscount = 20, TotalSum = 400 }
            };
            context.discounts.AddRange(discounts);
            IList<Genre> genres = new List<Genre>()
            {
                new Genre { Id=1, Name="Fantasy"},
                new Genre { Id=2, Name="Documental"},
                new Genre { Id=3, Name="Sience"}
            };
            context.genres.AddRange(genres);
            IList<NameProdaction> nameProdactions = new List<NameProdaction>()
            {
                new NameProdaction { Id=1, Name="OOO"},
                new NameProdaction { Id=2, Name="AAA"},
                new NameProdaction { Id=3, Name="Sp z o o"}
            };
            context.nameProdactions.AddRange(nameProdactions);
            IList<Sale> sales = new List<Sale>()
            {
                new Sale { Id=1, Name="-5%", DiscountSale=5},
                new Sale { Id=1, Name="-10%", DiscountSale=10},
                new Sale { Id=1, Name="-15%", DiscountSale=15}
            };
            context.sales.AddRange(sales);
            //context.books.Add(newBook);
            context.SaveChanges();
        }
    }
}

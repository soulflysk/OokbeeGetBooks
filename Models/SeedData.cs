using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SampleMVCApps.Models;
using System;
using System.Linq;

namespace SampleMVCApps.Models
{
    public static class SeedData
    {
        public static void GetBooks(IServiceProvider serviceProvider)
        {
            using (var books = new OokbeeEntities(
               serviceProvider.GetRequiredService<
                   DbContextOptions<OokbeeEntities>>()))

            {
                if (books.Books.Any())
                {
                    return;   // DB has been seeded
                }
                books.Books.AddRange(
                    new Book
                    { Title = "ขอโทษที พอดีไม่ใช่นางเอก", PublishedDateUtc = DateTime.Parse("2020-01-01") },
                    new Book
                    { Title = "ปิ๊งรักน้องชายหน้าหวาน", PublishedDateUtc = DateTime.Parse("2020-02-02") }
                    );
                books.Books.OrderByDescending(x => x.PublishedDateUtc).Take(50);

                books.SaveChanges();
            }
        }
    }
}
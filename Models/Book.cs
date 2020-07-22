using System;
using Microsoft.EntityFrameworkCore;

namespace SampleMVCApps.Models
{
    public class OokbeeEntities : DbContext
    {
        public OokbeeEntities (DbContextOptions<OokbeeEntities> options)
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
    }

    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime PublishedDateUtc { get; set; }
    }
}
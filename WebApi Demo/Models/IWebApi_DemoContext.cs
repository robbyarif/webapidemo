using System;
using System.Data.Entity;

namespace WebApi_Demo.Models
{
    public interface IWebApi_DemoContext : IDisposable
    {
        DbSet<Product> Products { get; }
        int SaveChanges();
        void MarkAsModified(Product item);
    }
}

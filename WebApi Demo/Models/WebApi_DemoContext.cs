using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApi_Demo.Models
{
    public class WebApi_DemoContext : DbContext, IWebApi_DemoContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public WebApi_DemoContext() : base("name=WebApi_DemoContext")
        {
        }

        public System.Data.Entity.DbSet<WebApi_Demo.Models.Product> Products { get; set; }
        public void MarkAsModified(Product item)
        {
            Entry(item).State = EntityState.Modified;
        }
    }
}

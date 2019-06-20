using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStore.Models
{
    public class SampleData
    {
        public static void Initialize(StoreContext context)
        {
            if(!context.Users.Any())
            {
                context.Users.AddRange(
                    new User("admin", "admin", 11)
                    );
                context.SaveChanges();
            }

            if (!context.Categories.Any())
            {
                context.Categories.AddRange(
                    new Category("gaiki")
                    );
                context.SaveChanges();
            }

            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product("gaika", "big gaika", "image", true, true, 11)
                    );
                context.SaveChanges();
            }
        }
    }
}

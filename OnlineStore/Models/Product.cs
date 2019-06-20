using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStore.Models
{
    public class Product
    {
        public Product(string title, string description, string mainImage, bool isDiscount, bool isMain, int categoryId)
        {
            Title = title;
            Description = description;
            MainImage = mainImage;
            IsDiscount = isDiscount;
            IsMain = isMain;
            CategoryId = categoryId;
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string MainImage { get; set; }
        public bool IsDiscount { get; set; }
        public bool IsMain { get; set; }
        public int CategoryId { get; set; }
    }
}

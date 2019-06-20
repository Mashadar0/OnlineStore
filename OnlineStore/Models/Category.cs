using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStore.Models
{
    public class Category
    {
        public Category(string title)
        {
            Title = title;
        }

        public int Id { get; set; }
        public string Title { get; set; }
    }
}

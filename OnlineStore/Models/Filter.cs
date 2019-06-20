using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStore.Models
{
    public class Filter
    {
        public Filter(string title, int categoryId)
        {
            Title = title;
            CategoryId = categoryId;
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public int CategoryId { get; set; }
    }
}

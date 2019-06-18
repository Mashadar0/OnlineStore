using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStore.Models
{
    public class FilterAddition
    {
        public FilterAddition(string title, int filterId)
        {
            title = Title;
            filterId = FilterId;
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public int FilterId { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStore.Models
{
    public class Value
    {
        public Value(int fileAddId, int productId)
        {
            fileAddId = FileAddId;
            productId = ProductId;
        }

        public int Id { get; set; }
        public int FileAddId { get; set; }
        public int ProductId { get; set; }
    }
}

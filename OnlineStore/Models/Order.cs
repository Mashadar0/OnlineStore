using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStore.Models
{
    public class Order
    {
        public Order(string title, string comment, string name, string email, string phone, DateTime dateTime, int clientId)
        {
            title = Title;
            comment = Comment;
            name = Name;
            email = Email;
            phone = Phone;
            dateTime = DateTime;
            clientId = ClientId;
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Comment { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime DateTime { get; set; }
        public int ClientId { get; set; }
    }
}

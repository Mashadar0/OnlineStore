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
            Title = title;
            Comment = comment;
            Name = name;
            Email = email;
            Phone = phone;
            DateTime = dateTime;
            ClientId = clientId;
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

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogInDemo.DTO
{
    public class Food
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        private string id;
        private string name;
        private int price;
        private int quantity;

        public Food(string id, string name, string description, int price, int quantity) {
            Id = id;
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public Food(DataRow row)
        {
            Id = row["FID"].ToString();
            Name = row["Name"].ToString();
            Price = Convert.ToInt32(row["Price"]);
            Quantity = Convert.ToInt32(row["Quantity"]);
        }
    }
}

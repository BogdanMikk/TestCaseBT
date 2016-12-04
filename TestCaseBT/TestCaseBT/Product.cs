using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCaseBT
{
    public class Product
    {
        private long id;

        public long Id
        {
            get { return id; }
            set { id = value; }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private double count;

        public double Count
        {
            get { return count; }
            set { count = value; }
        }
        private double price;

        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        private string category;

        public string Category
        {
            get { return category; }
            set { category = value; }
        }

        public Product(long id, string name, double count, double price, string category)
        {
            this.id = id;
            this.name = name;
            this.count = count;
            this.price = price;
            this.category = category;
        }
    }
}

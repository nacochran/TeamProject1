using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamProject1
{
    internal class Product
    {
        // fields
        private string productId;
        private string name;
        private string description;
        private decimal price;
        private int onHand;
        private int unitSold;
        private bool isInOrder;
        // properties
        public string ProductId
        {
            get { return productId; }
            set { productId = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }
        public int OnHand
        {
            get { return onHand; }
            set { onHand = value; }
        }
        public int UnitSold
        {
            get { return unitSold; }
            set { unitSold = value; }
        }
        public bool IsInOrder
        {
            get { return isInOrder; }
            set { isInOrder = value; }
        }
        // overloaded constructors
        public Product(string productId, string name, string description, 
                        decimal price, int onHand)
        {
            ProductId = productId;
            Name = name;
            Description = description;
            Price = price;
            OnHand = onHand;
        }
        public Product(string productId, int unitSold)
        {
            ProductId = productId;
            UnitSold = unitSold;
        }
        // methods
        public decimal CalculateProductCost()
        {
            decimal cost;
            cost = Price * UnitSold;
            return cost;
        }
        public void Sold()
        {
            OnHand -= UnitSold;
        }
        // ToString
        public override string ToString()
        {
            string str;
            str = $"{productId}\n{Name}\n{Description}\n{Price}\n{OnHand}";
            return str;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TeamProject1
{
    internal class Order
    {
        // fields
        public const decimal TAX_RATE = 0.09M;
        private List<Product> productInOrder;
        // property
        public List<Product> ProductInOrder
        {
            get { return productInOrder; }
            set { productInOrder = value; }
        }
        // constructor
        public Order(List<Product> productInOrder)
        {
            ProductInOrder = productInOrder;
        }
        // methods
        public decimal CalculateSubTotal()
        {
            decimal subTotal = 0;
            foreach (Product p in productInOrder)
            {
                subTotal += p.CalculateProductCost();
            }
            return subTotal;
        }
        public decimal CalculateTax()
        {
            decimal taxAmount;
            taxAmount = CalculateSubTotal() * TAX_RATE;
            return taxAmount;
        }
        public decimal CalculateTotal()
        {
            decimal total;
            total = CalculateSubTotal() + CalculateTax();
            return total;
        }
        // ToString
        public override string ToString()
        {
            string str;
            str = $"    Dragon Phoenix Toy\n";
            str += $"        123 Toy St.\n";
            str += $"    Argentina OK 48451\n";
            str += $"    " + DateTime.Now.ToString() + "\n";

            foreach (Product p in productInOrder)
            {
                str += $"{p.Name,-15}{p.UnitSold,-2}{p.CalculateProductCost(),10:n2}\n";

            }
            str += $"{"Sub total:", 15}{CalculateSubTotal(), 10:n2}\n";
            str += $"{"Tax:", 15}{CalculateTax(), 10:n2}\n";
            str += $"{"Total:", 15}{CalculateTotal(),10:n2}";
            return str;
        }
    }
}

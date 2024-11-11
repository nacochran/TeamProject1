using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamProject1
{
    public partial class DisplayProductForm : Form
    {
        List<Product> products = new List<Product>();

        public DisplayProductForm()
        {
            InitializeComponent();
        }

        private void DisplayProductForm_Load(object sender, EventArgs e)
        {
            if (File.Exists("product.txt"))
            {
                using StreamReader sr = new StreamReader("product.txt");
                string productId;
                while ((productId = sr.ReadLine()) != null)
                {
                    string name = sr.ReadLine();
                    string description = sr.ReadLine();
                    decimal price = decimal.Parse(sr.ReadLine());
                    int onHand = int.Parse(sr.ReadLine());
                    Product product = new Product(productId,
                        name, description, price, onHand);
                    products.Add(product);
                    string str = $"Product ID: {product.ProductId}" +
                        $" Name: {product.Name}" +
                        $" Description: {product.Description}" +
                        $" Price: {product.Price:C}" +
                        $" On Hand: {product.OnHand}";
                    inventoryListBox.Items.Add(str);
                }
            }
            else
            {
                MessageBox.Show("Missing product.txt file.");
            }
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            // TODO
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // TODO
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

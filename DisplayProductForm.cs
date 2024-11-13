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
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Inventory",
                new Font("Courier New", 24, FontStyle.Bold),
                Brushes.Black, 350, 100);
            e.Graphics.DrawString(DateTime.Now.ToString(),
                new Font("Courier New", 12, FontStyle.Italic),
                Brushes.Black, 330, 150);
            int x = 100, y = 200;
            foreach (var product in products)
            {
                e.Graphics.DrawString($"Product ID: {product.ProductId}" +
                       $" Product Name: {product.Name}",
                       new Font("Courier New", 12, FontStyle.Regular),
                       Brushes.Black, x, y);
                y += 16;
                e.Graphics.DrawString($"Description: {product.Description}",
                    new Font("Courier New", 12, FontStyle.Regular),
                    Brushes.Black, x, y);
                y += 16;
                e.Graphics.DrawString($"Price: {product.Price}" +
                    $" Quantity: {product.OnHand}",
                    new Font("Courier New", 12, FontStyle.Regular),
                    product.OnHand < 3 ? Brushes.Red : Brushes.Black, x, y);
                y += 16;
                e.Graphics.DrawString($"",
                        new Font("Courier New", 12, FontStyle.Regular),
                        Brushes.Black, x, y);
                y += 16;
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

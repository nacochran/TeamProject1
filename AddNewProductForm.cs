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
    public partial class AddNewProductForm : Form
    {
        List<Product> products = new List<Product>();

        public AddNewProductForm()
        {
            InitializeComponent();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            idTextBox.Clear();
            nameTextBox.Clear();
            descriptionTextBox.Clear();
            priceTextBox.Clear();
            quantityTextBox.Clear();
            idTextBox.Focus();
        }

        private void AddNewProductForm_Load(object sender, EventArgs e)
        {
            if (File.Exists("product.txt"))
            {
                using StreamReader sr = new StreamReader("product.txt");
                string id;
                while ((id = sr.ReadLine()) != null)
                {
                    Product p = new Product(id, sr.ReadLine(), sr.ReadLine(),
                        decimal.Parse(sr.ReadLine()), int.Parse(sr.ReadLine()));
                    products.Add(p);
                }
            }
            else
            {
                MessageBox.Show("Missing product.txt file.");
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            using StreamWriter sw = File.AppendText("product.txt");
            decimal price;
            int onHand = 0;
            if (string.IsNullOrEmpty(idTextBox.Text) || (products.Find(x => x.ProductId == idTextBox.Text) != null))
            {
                MessageBox.Show("ID is already used.");
                idTextBox.Focus();
                idTextBox.SelectAll();
            }
            else if (string.IsNullOrEmpty(nameTextBox.Text))
            {
                MessageBox.Show("Product name cannot be empty");
                nameTextBox.Focus();
            }
            else if (string.IsNullOrEmpty(descriptionTextBox.Text))
            {
                MessageBox.Show("Description cannot be empty");
                descriptionTextBox.Focus();
            }
            else if (!decimal.TryParse(priceTextBox.Text, out price) || price < 0)
            {
                MessageBox.Show("Price is required & must be number.");
                priceTextBox.Focus();
                priceTextBox.SelectAll();
            }
            else if (!string.IsNullOrEmpty(quantityTextBox.Text) && 
                !int.TryParse(quantityTextBox.Text, out onHand) || onHand < 0)
            {
                MessageBox.Show("Quantity must be a number or empty");
                quantityTextBox.Focus();
                quantityTextBox.SelectAll();
            }
            else
            {
                Product product = new Product(idTextBox.Text,
                    nameTextBox.Text, descriptionTextBox.Text,
                    price, onHand);
                sw.WriteLine(product);
                MessageBox.Show("Record saved.");
                clearButton.PerformClick();
            }
        }
    }
}

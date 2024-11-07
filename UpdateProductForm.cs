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
    public partial class UpdateProductForm : Form
    {
        List<Product> products = new List<Product>();
        public UpdateProductForm()
        {
            InitializeComponent();
        }

        private void UpdateProductForm_Load(object sender, EventArgs e)
        {
            if (File.Exists("product.txt"))
            {
                using StreamReader sr = new StreamReader("product.txt");
                string id;
                while ((id = sr.ReadLine()) != null)
                {
                    Product p = new Product(id, sr.ReadLine(), sr.ReadLine(), decimal.Parse(sr.ReadLine()), int.Parse(sr.ReadLine()));
                    products.Add(p);
                }
                updateButton.Enabled = false;
            }
            else
            {
                MessageBox.Show("Missing product.txt file.");
                Close();
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            idTextBox.Clear();
            nameTextBox.Clear();
            descriptionTextBox.Clear();
            priceTextBox.Clear();
            quantityTextBox.Clear();
            newQuantityTextBox.Clear();
            idTextBox.ReadOnly = false;
            idTextBox.Focus();
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            Product product = products.Find(p => p.ProductId == idTextBox.Text);
            if (product != null)
            {
                idTextBox.Text = product.ProductId;
                idTextBox.ReadOnly = true;
                nameTextBox.Text = product.Name;
                descriptionTextBox.Text = product.Description;
                priceTextBox.Text = product.Price.ToString();
                quantityTextBox.Text = product.OnHand.ToString();
                updateButton.Enabled = true;
            }
            else
            {
                MessageBox.Show("No product with that ID found.");
                idTextBox.Focus();
                idTextBox.SelectAll();
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            int index = products.FindIndex(x => x.ProductId == idTextBox.Text);
            using StreamWriter sw = File.AppendText("product.txt");
            decimal price;
            int onHand = 0;
            int newArrival = 0;
            if (string.IsNullOrEmpty(nameTextBox.Text))
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
                MessageBox.Show("Price is required and must be a number.");
                priceTextBox.Focus();
                priceTextBox.SelectAll();
            }
            else if (!string.IsNullOrEmpty(newQuantityTextBox.Text) &&
                !int.TryParse(newQuantityTextBox.Text, out newArrival) ||
                newArrival < 0)
            {
                MessageBox.Show("New quantity must be a number or empty");
                newQuantityTextBox.Focus();
                newQuantityTextBox.SelectAll();
            }
            else
            {
                products[index].Name = nameTextBox.Text;
                products[index].Description = descriptionTextBox.Text;
                products[index].Price = price;
                products[index].OnHand += newArrival;
                MessageBox.Show("Product updated.");
                clearButton.PerformClick();
                idTextBox.ReadOnly = false;
            }
        }

        private void saveAndCloseButton_Click(object sender, EventArgs e)
        {
            using StreamWriter sr = File.CreateText("product.txt");
            foreach (Product product in products)
            {
                sr.WriteLine(product);
            }
            Close();
        }
    }
}

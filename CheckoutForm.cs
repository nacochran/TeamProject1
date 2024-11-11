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
    public partial class CheckoutForm : Form
    {
        public CheckoutForm()
        {
            InitializeComponent();
        }

        Order order;
        List<Product> products = new List<Product>();
        List<Product> productsInOrder = new List<Product>();

        private void CheckoutForm_Load(object sender, EventArgs e)
        {
            // TODO
        }

        private void addToOrderButton_Click(object sender, EventArgs e)
        {
            // TODO
        }

        private void readyToPayButton_Click(object sender, EventArgs e)
        {
            // TODO
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            // TODO
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // TODO
        }

        private void saveAndCloseButton_Click(object sender, EventArgs e)
        {
            // TODO
        }
    }
}

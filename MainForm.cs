namespace TeamProject1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void addNewProductButton_Click(object sender, EventArgs e)
        {
            AddNewProductForm addNewProductForm = new AddNewProductForm();
            addNewProductForm.ShowDialog();
        }

        private void updateInventoryButton_Click(object sender, EventArgs e)
        {
            UpdateProductForm updateProductForm = new UpdateProductForm();
            updateProductForm.ShowDialog();
        }

        private void displayInventoryButton_Click(object sender, EventArgs e)
        {
            DisplayProductForm displayProductForm = new DisplayProductForm();
            displayProductForm.ShowDialog();
        }

        private void cashierCheckoutButton_Click(object sender, EventArgs e)
        {
            CheckoutForm checkoutForm = new CheckoutForm();
            checkoutForm.ShowDialog();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
            // test
        }
    }
}

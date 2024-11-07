namespace TeamProject1
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            addNewProductButton = new Button();
            updateInventoryButton = new Button();
            displayInventoryButton = new Button();
            cashierCheckoutButton = new Button();
            exitButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(225, 77);
            label1.Name = "label1";
            label1.Size = new Size(623, 35);
            label1.TabIndex = 0;
            label1.Text = "Dragon Phoenix Toy Inventory System";
            // 
            // addNewProductButton
            // 
            addNewProductButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addNewProductButton.Location = new Point(105, 175);
            addNewProductButton.Name = "addNewProductButton";
            addNewProductButton.Size = new Size(144, 68);
            addNewProductButton.TabIndex = 1;
            addNewProductButton.Text = "&Add New Product";
            addNewProductButton.UseVisualStyleBackColor = true;
            // 
            // updateInventoryButton
            // 
            updateInventoryButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            updateInventoryButton.Location = new Point(338, 175);
            updateInventoryButton.Name = "updateInventoryButton";
            updateInventoryButton.Size = new Size(144, 68);
            updateInventoryButton.TabIndex = 2;
            updateInventoryButton.Text = "&Update Inventory";
            updateInventoryButton.UseVisualStyleBackColor = true;
            // 
            // displayInventoryButton
            // 
            displayInventoryButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            displayInventoryButton.Location = new Point(578, 175);
            displayInventoryButton.Name = "displayInventoryButton";
            displayInventoryButton.Size = new Size(144, 68);
            displayInventoryButton.TabIndex = 3;
            displayInventoryButton.Text = "&Display Inventory";
            displayInventoryButton.UseVisualStyleBackColor = true;
            // 
            // cashierCheckoutButton
            // 
            cashierCheckoutButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cashierCheckoutButton.Location = new Point(826, 175);
            cashierCheckoutButton.Name = "cashierCheckoutButton";
            cashierCheckoutButton.Size = new Size(144, 68);
            cashierCheckoutButton.TabIndex = 4;
            cashierCheckoutButton.Text = "Cashier Checkout";
            cashierCheckoutButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            exitButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exitButton.Location = new Point(105, 302);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(865, 59);
            exitButton.TabIndex = 5;
            exitButton.Text = "E&xit";
            exitButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1080, 431);
            Controls.Add(exitButton);
            Controls.Add(cashierCheckoutButton);
            Controls.Add(displayInventoryButton);
            Controls.Add(updateInventoryButton);
            Controls.Add(addNewProductButton);
            Controls.Add(label1);
            Name = "MainForm";
            Text = "Main Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button addNewProductButton;
        private Button updateInventoryButton;
        private Button displayInventoryButton;
        private Button cashierCheckoutButton;
        private Button exitButton;
    }
}

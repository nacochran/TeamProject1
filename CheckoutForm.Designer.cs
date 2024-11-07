namespace TeamProject1
{
    partial class CheckoutForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            idTextBox = new TextBox();
            unitsTextBox = new TextBox();
            addToOrderButton = new Button();
            readyToPayButton = new Button();
            printButton = new Button();
            saveAndCloseButton = new Button();
            label4 = new Label();
            orderListBox = new ListBox();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.2F);
            label1.Location = new Point(51, 39);
            label1.Name = "label1";
            label1.Size = new Size(259, 20);
            label1.TabIndex = 1;
            label1.Text = "Scan barcode or enter product id:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.2F);
            label2.Location = new Point(86, 83);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 2;
            label2.Text = "Product ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.2F);
            label3.Location = new Point(89, 132);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 3;
            label3.Text = "Units Sold:";
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(202, 76);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(271, 27);
            idTextBox.TabIndex = 4;
            // 
            // unitsTextBox
            // 
            unitsTextBox.Location = new Point(202, 132);
            unitsTextBox.Name = "unitsTextBox";
            unitsTextBox.Size = new Size(135, 27);
            unitsTextBox.TabIndex = 5;
            // 
            // addToOrderButton
            // 
            addToOrderButton.Location = new Point(51, 205);
            addToOrderButton.Name = "addToOrderButton";
            addToOrderButton.Size = new Size(109, 56);
            addToOrderButton.TabIndex = 6;
            addToOrderButton.Text = "&Add to Order";
            addToOrderButton.UseVisualStyleBackColor = true;
            addToOrderButton.Click += addToOrderButton_Click;
            // 
            // readyToPayButton
            // 
            readyToPayButton.Location = new Point(190, 205);
            readyToPayButton.Name = "readyToPayButton";
            readyToPayButton.Size = new Size(109, 56);
            readyToPayButton.TabIndex = 7;
            readyToPayButton.Text = "&Ready to Pay";
            readyToPayButton.UseVisualStyleBackColor = true;
            readyToPayButton.Click += readyToPayButton_Click;
            // 
            // printButton
            // 
            printButton.Location = new Point(328, 205);
            printButton.Name = "printButton";
            printButton.Size = new Size(109, 56);
            printButton.TabIndex = 8;
            printButton.Text = "&Print Receipt";
            printButton.UseVisualStyleBackColor = true;
            printButton.Click += printButton_Click;
            // 
            // saveAndCloseButton
            // 
            saveAndCloseButton.Location = new Point(464, 205);
            saveAndCloseButton.Name = "saveAndCloseButton";
            saveAndCloseButton.Size = new Size(109, 56);
            saveAndCloseButton.TabIndex = 9;
            saveAndCloseButton.Text = "&Save && Close";
            saveAndCloseButton.UseVisualStyleBackColor = true;
            saveAndCloseButton.Click += saveAndCloseButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.2F);
            label4.Location = new Point(45, 309);
            label4.Name = "label4";
            label4.Size = new Size(115, 20);
            label4.TabIndex = 10;
            label4.Text = "Order Details:";
            // 
            // orderListBox
            // 
            orderListBox.FormattingEnabled = true;
            orderListBox.Location = new Point(51, 345);
            orderListBox.Name = "orderListBox";
            orderListBox.Size = new Size(522, 164);
            orderListBox.TabIndex = 11;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // CheckoutForm
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(638, 550);
            Controls.Add(orderListBox);
            Controls.Add(label4);
            Controls.Add(saveAndCloseButton);
            Controls.Add(printButton);
            Controls.Add(readyToPayButton);
            Controls.Add(addToOrderButton);
            Controls.Add(unitsTextBox);
            Controls.Add(idTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 10.2F);
            Name = "CheckoutForm";
            Text = "CheckoutForm";
            Load += CheckoutForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox idTextBox;
        private TextBox unitsTextBox;
        private Button addToOrderButton;
        private Button readyToPayButton;
        private Button printButton;
        private Button saveAndCloseButton;
        private Label label4;
        private ListBox orderListBox;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}
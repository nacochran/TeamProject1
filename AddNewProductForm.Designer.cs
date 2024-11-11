namespace TeamProject1
{
    partial class AddNewProductForm
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
            groupBox1 = new GroupBox();
            descriptionTextBox = new RichTextBox();
            quantityTextBox = new TextBox();
            priceTextBox = new TextBox();
            nameTextBox = new TextBox();
            idTextBox = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            saveButton = new Button();
            clearButton = new Button();
            closeButton = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(descriptionTextBox);
            groupBox1.Controls.Add(quantityTextBox);
            groupBox1.Controls.Add(priceTextBox);
            groupBox1.Controls.Add(nameTextBox);
            groupBox1.Controls.Add(idTextBox);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(34, 29);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(506, 380);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "New Product Data";
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(217, 159);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(256, 73);
            descriptionTextBox.TabIndex = 10;
            descriptionTextBox.Text = "";
            // 
            // quantityTextBox
            // 
            quantityTextBox.Location = new Point(217, 317);
            quantityTextBox.Name = "quantityTextBox";
            quantityTextBox.Size = new Size(256, 30);
            quantityTextBox.TabIndex = 9;
            // 
            // priceTextBox
            // 
            priceTextBox.Location = new Point(217, 261);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(256, 30);
            priceTextBox.TabIndex = 8;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(217, 103);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(256, 30);
            nameTextBox.TabIndex = 6;
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(217, 51);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(256, 30);
            idTextBox.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(39, 317);
            label5.Name = "label5";
            label5.Size = new Size(151, 23);
            label5.TabIndex = 4;
            label5.Text = "Quantity on Hand:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(39, 261);
            label4.Name = "label4";
            label4.Size = new Size(116, 23);
            label4.TabIndex = 3;
            label4.Text = "Product Price:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(39, 153);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 2;
            label3.Text = "Description:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(39, 103);
            label2.Name = "label2";
            label2.Size = new Size(125, 23);
            label2.TabIndex = 1;
            label2.Text = "Product Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(39, 51);
            label1.Name = "label1";
            label1.Size = new Size(96, 23);
            label1.TabIndex = 0;
            label1.Text = "Product ID:";
            // 
            // saveButton
            // 
            saveButton.Location = new Point(34, 446);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(106, 49);
            saveButton.TabIndex = 1;
            saveButton.Text = "&Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(234, 446);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(106, 49);
            clearButton.TabIndex = 2;
            clearButton.Text = "&Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(434, 446);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(106, 49);
            closeButton.TabIndex = 3;
            closeButton.Text = "Cl&ose";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // AddNewProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(580, 526);
            Controls.Add(closeButton);
            Controls.Add(clearButton);
            Controls.Add(saveButton);
            Controls.Add(groupBox1);
            Name = "AddNewProductForm";
            Text = "Add New Product Form";
            Load += AddNewProductForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox priceTextBox;
        private TextBox nameTextBox;
        private TextBox idTextBox;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox quantityTextBox;
        private RichTextBox descriptionTextBox;
        private Button saveButton;
        private Button clearButton;
        private Button closeButton;
    }
}
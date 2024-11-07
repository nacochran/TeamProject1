namespace TeamProject1
{
    partial class UpdateProductForm
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
            saveAndCloseButton = new Button();
            clearButton = new Button();
            updateButton = new Button();
            groupBox1 = new GroupBox();
            findButton = new Button();
            newQuantityTextBox = new TextBox();
            label6 = new Label();
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
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // saveAndCloseButton
            // 
            saveAndCloseButton.Location = new Point(416, 504);
            saveAndCloseButton.Name = "saveAndCloseButton";
            saveAndCloseButton.Size = new Size(120, 49);
            saveAndCloseButton.TabIndex = 7;
            saveAndCloseButton.Text = "&Save && Close";
            saveAndCloseButton.UseVisualStyleBackColor = true;
            saveAndCloseButton.Click += saveAndCloseButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(222, 504);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(112, 49);
            clearButton.TabIndex = 6;
            clearButton.Text = "&Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // updateButton
            // 
            updateButton.Location = new Point(30, 504);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(110, 49);
            updateButton.TabIndex = 5;
            updateButton.Text = "&Update";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(findButton);
            groupBox1.Controls.Add(newQuantityTextBox);
            groupBox1.Controls.Add(label6);
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
            groupBox1.Location = new Point(30, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(506, 439);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Update Product";
            // 
            // findButton
            // 
            findButton.Location = new Point(396, 51);
            findButton.Name = "findButton";
            findButton.Size = new Size(77, 30);
            findButton.TabIndex = 8;
            findButton.Text = "&Find";
            findButton.UseVisualStyleBackColor = true;
            findButton.Click += findButton_Click;
            // 
            // newQuantityTextBox
            // 
            newQuantityTextBox.Location = new Point(217, 377);
            newQuantityTextBox.Name = "newQuantityTextBox";
            newQuantityTextBox.Size = new Size(256, 30);
            newQuantityTextBox.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(68, 377);
            label6.Name = "label6";
            label6.Size = new Size(119, 23);
            label6.TabIndex = 11;
            label6.Text = "New Quantity:";
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
            idTextBox.Size = new Size(168, 30);
            idTextBox.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(36, 317);
            label5.Name = "label5";
            label5.Size = new Size(151, 23);
            label5.TabIndex = 4;
            label5.Text = "Quantity on Hand:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(71, 264);
            label4.Name = "label4";
            label4.Size = new Size(116, 23);
            label4.TabIndex = 3;
            label4.Text = "Product Price:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(87, 162);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 2;
            label3.Text = "Description:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(62, 103);
            label2.Name = "label2";
            label2.Size = new Size(125, 23);
            label2.TabIndex = 1;
            label2.Text = "Product Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(91, 54);
            label1.Name = "label1";
            label1.Size = new Size(96, 23);
            label1.TabIndex = 0;
            label1.Text = "Product ID:";
            // 
            // UpdateProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(568, 590);
            Controls.Add(saveAndCloseButton);
            Controls.Add(clearButton);
            Controls.Add(updateButton);
            Controls.Add(groupBox1);
            Name = "UpdateProductForm";
            Text = "UpdateProductForm";
            Load += UpdateProductForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button saveAndCloseButton;
        private Button clearButton;
        private Button updateButton;
        private GroupBox groupBox1;
        private RichTextBox descriptionTextBox;
        private TextBox quantityTextBox;
        private TextBox priceTextBox;
        private TextBox nameTextBox;
        private TextBox idTextBox;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox newQuantityTextBox;
        private Label label6;
        private Button findButton;
    }
}
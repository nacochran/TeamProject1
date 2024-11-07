namespace TeamProject1
{
    partial class DisplayProductForm
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
            inventoryListBox = new ListBox();
            closeButton = new Button();
            printButton = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(38, 31);
            label1.Name = "label1";
            label1.Size = new Size(201, 23);
            label1.TabIndex = 0;
            label1.Text = "All Products in Inventory:";
            // 
            // inventoryListBox
            // 
            inventoryListBox.FormattingEnabled = true;
            inventoryListBox.Location = new Point(38, 73);
            inventoryListBox.Name = "inventoryListBox";
            inventoryListBox.Size = new Size(546, 244);
            inventoryListBox.TabIndex = 1;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(94, 364);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(157, 49);
            closeButton.TabIndex = 6;
            closeButton.Text = "Cl&ose";
            closeButton.UseVisualStyleBackColor = true;
            // 
            // printButton
            // 
            printButton.Location = new Point(363, 364);
            printButton.Name = "printButton";
            printButton.Size = new Size(157, 49);
            printButton.TabIndex = 7;
            printButton.Text = "&Print";
            printButton.UseVisualStyleBackColor = true;
            printButton.Click += printButton_Click;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // DisplayProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(625, 450);
            Controls.Add(printButton);
            Controls.Add(closeButton);
            Controls.Add(inventoryListBox);
            Controls.Add(label1);
            Name = "DisplayProductForm";
            Text = "DisplayProductForm";
            Load += DisplayProductForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox inventoryListBox;
        private Button closeButton;
        private Button printButton;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}
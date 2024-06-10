namespace SingleResponsibility
{
    partial class Form1
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
            textBoxName = new TextBox();
            textBoxPrice = new TextBox();
            buttonCreate = new Button();
            buttonBackColor = new Button();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(58, 76);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(100, 23);
            textBoxName.TabIndex = 0;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(58, 105);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(100, 23);
            textBoxPrice.TabIndex = 1;
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new Point(100, 134);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(115, 23);
            buttonCreate.TabIndex = 2;
            buttonCreate.Text = "Ürün Oluştur";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // buttonBackColor
            // 
            buttonBackColor.Location = new Point(298, 277);
            buttonBackColor.Name = "buttonBackColor";
            buttonBackColor.Size = new Size(123, 23);
            buttonBackColor.TabIndex = 3;
            buttonBackColor.Text = "Rengi değiştir";
            buttonBackColor.UseVisualStyleBackColor = true;
            buttonBackColor.Click += buttonBackColor_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(433, 312);
            Controls.Add(buttonBackColor);
            Controls.Add(buttonCreate);
            Controls.Add(textBoxPrice);
            Controls.Add(textBoxName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxName;
        private TextBox textBoxPrice;
        private Button buttonCreate;
        private Button buttonBackColor;
    }
}

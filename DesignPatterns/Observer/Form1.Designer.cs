namespace Observer
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
            buttonNew = new Button();
            buttonColor = new Button();
            SuspendLayout();
            // 
            // buttonNew
            // 
            buttonNew.Location = new Point(137, 118);
            buttonNew.Name = "buttonNew";
            buttonNew.Size = new Size(75, 23);
            buttonNew.TabIndex = 0;
            buttonNew.Text = "Yeni Form";
            buttonNew.UseVisualStyleBackColor = true;
            buttonNew.Click += buttonNew_Click;
            // 
            // buttonColor
            // 
            buttonColor.Location = new Point(108, 147);
            buttonColor.Name = "buttonColor";
            buttonColor.Size = new Size(127, 23);
            buttonColor.TabIndex = 1;
            buttonColor.Text = "Renk Değiştir";
            buttonColor.UseVisualStyleBackColor = true;
            buttonColor.Click += buttonColor_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(356, 345);
            Controls.Add(buttonColor);
            Controls.Add(buttonNew);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonNew;
        private Button buttonColor;
    }
}

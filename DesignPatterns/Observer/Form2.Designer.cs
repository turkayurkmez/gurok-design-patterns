namespace Observer
{
    partial class Form2
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
            buttonSubscribe = new Button();
            buttonUnsubscribe = new Button();
            SuspendLayout();
            // 
            // buttonSubscribe
            // 
            buttonSubscribe.Location = new Point(138, 76);
            buttonSubscribe.Name = "buttonSubscribe";
            buttonSubscribe.Size = new Size(128, 35);
            buttonSubscribe.TabIndex = 0;
            buttonSubscribe.Text = "Abone ol";
            buttonSubscribe.UseVisualStyleBackColor = true;
            buttonSubscribe.Click += buttonSubscribe_Click;
            // 
            // buttonUnsubscribe
            // 
            buttonUnsubscribe.Location = new Point(138, 137);
            buttonUnsubscribe.Name = "buttonUnsubscribe";
            buttonUnsubscribe.Size = new Size(128, 35);
            buttonUnsubscribe.TabIndex = 1;
            buttonUnsubscribe.Text = "Abobelikten çık";
            buttonUnsubscribe.UseVisualStyleBackColor = true;
            buttonUnsubscribe.Click += buttonUnsubscribe_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 331);
            Controls.Add(buttonUnsubscribe);
            Controls.Add(buttonSubscribe);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonSubscribe;
        private Button buttonUnsubscribe;
    }
}
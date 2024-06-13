namespace Composite
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
            TreeNode treeNode1 = new TreeNode("Bilgisayar");
            TreeNode treeNode2 = new TreeNode("Ses sistemi");
            TreeNode treeNode3 = new TreeNode("Elektronik", new TreeNode[] { treeNode1, treeNode2 });
            TreeNode treeNode4 = new TreeNode("Kozmetik");
            TreeNode treeNode5 = new TreeNode("Kategoriler", new TreeNode[] { treeNode3, treeNode4 });
            treeView1 = new TreeView();
            treeView2 = new TreeView();
            buttonGet = new Button();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.Location = new Point(146, 123);
            treeView1.Name = "treeView1";
            treeNode1.Name = "Node3";
            treeNode1.Text = "Bilgisayar";
            treeNode2.Name = "Node4";
            treeNode2.Text = "Ses sistemi";
            treeNode3.Name = "Node1";
            treeNode3.Text = "Elektronik";
            treeNode4.Name = "Node2";
            treeNode4.Text = "Kozmetik";
            treeNode5.Name = "Node0";
            treeNode5.Text = "Kategoriler";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode5 });
            treeView1.Size = new Size(209, 252);
            treeView1.TabIndex = 0;
            // 
            // treeView2
            // 
            treeView2.Location = new Point(426, 134);
            treeView2.Name = "treeView2";
            treeView2.Size = new Size(329, 173);
            treeView2.TabIndex = 1;
            // 
            // buttonGet
            // 
            buttonGet.Location = new Point(669, 322);
            buttonGet.Name = "buttonGet";
            buttonGet.Size = new Size(75, 23);
            buttonGet.TabIndex = 2;
            buttonGet.Text = "Kategoriler";
            buttonGet.UseVisualStyleBackColor = true;
            buttonGet.Click += buttonGet_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonGet);
            Controls.Add(treeView2);
            Controls.Add(treeView1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private TreeView treeView1;
        private TreeView treeView2;
        private Button buttonGet;
    }
}

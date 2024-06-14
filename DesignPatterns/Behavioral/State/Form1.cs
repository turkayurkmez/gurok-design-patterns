using System;
using System.Windows.Forms;

namespace State
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Product product = new Product();
        private void Form1_Load(object sender, EventArgs e)
        {
            /*
             * PROBLEM:
             * Bir nesne belirli bir duruma göre bir davranış segileyeceksa aralarındaki geçişi nasıl organıze ederiz? 
             */

            //var product = new Product();

            //product.RemoveStock(300);
            //product.RemoveStock(470);

            label1.Text = product.State.ToString();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            product.AddStock(500);
            label1.Text = product.State.ToString();
            label1.ForeColor = product.State.Color;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            product.RemoveStock(300);
            label1.Text = product.State.ToString();
            label1.ForeColor = product.State.Color;
        }
    }
}

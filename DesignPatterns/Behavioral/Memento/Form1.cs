namespace Memento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MementoModel mementoModel = new MementoModel();
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(mementoModel);
            form2.Show();

        }
    }
}
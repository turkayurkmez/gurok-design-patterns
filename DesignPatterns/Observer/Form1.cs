namespace Observer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ColorObservable colorObservable = new ColorObservable();
        private void buttonNew_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(colorObservable);
            form2.Show();
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                colorObservable.Color = colorDialog.Color;
            }
        }
    }
}

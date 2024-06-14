namespace Memento
{
    public partial class Form2 : Form
    {

        private MementoModel mementoModel;
        public Form2(MementoModel memento)
        {
            InitializeComponent();
            mementoModel = memento;

            if (mementoModel.Memento != null)
            {
                mementoModel.FormSettings.Restore(mementoModel.Memento);
                Width = mementoModel.FormSettings.Width;
                Height = mementoModel.FormSettings.Height;
                Location = mementoModel.FormSettings.Position;
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            mementoModel.FormSettings.Width = Width;
            mementoModel.FormSettings.Height = Height;
            mementoModel.FormSettings.Position = new Point(Location.X, Location.Y);

            mementoModel.Memento = mementoModel.FormSettings.Save();

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }

    public class MementoModel
    {
        public Memento Memento { get; set; }
        public FormSettings FormSettings { get; set; } = new FormSettings();
    }
}

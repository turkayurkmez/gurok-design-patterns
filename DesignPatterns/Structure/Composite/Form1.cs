namespace Composite
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGet_Click(object sender, EventArgs e)
        {
            var categories = new CompositeType<Category>() { Node = new Category { Name = "Kategoriler" } };

            var electronic = categories.Add(new Category { Name = "Elektronik" });
            var computer = electronic.Add(new Category { Name = "Bilgisayar" });
            var laptop = computer.Add(new Category { Name = "Laptop" });
            var pc = computer.Add(new Category { Name = "PC" });
            var coldSystem = electronic.Add(new Category { Name = "Air conditioner" });

            CompositeType<Category>.Show(categories, treeView2);
        }
    }
}

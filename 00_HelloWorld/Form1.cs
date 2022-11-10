namespace _00_HelloWorld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;
        }

        private void myButton_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Hello World");
            MessageBox.Show($"Hello {myTextBox.Text}");
        }
    }
}
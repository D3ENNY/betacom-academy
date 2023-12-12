namespace StartWindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Submit(object sender, EventArgs e)
        {
            string name = inputName.Text;
            if(showName.Checked)
                MessageBox.Show($"ciao {name}");
            else
                MessageBox.Show("ciao");
        }
    }
}
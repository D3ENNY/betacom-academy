using WformApp1.Models;

namespace WformApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            SubmitBtn.FlatStyle = FlatStyle.Flat;
            SubmitBtn.FlatAppearance.BorderSize = 0;
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            User user = LoginUser();
            if (user != null)
            {
                FrmData frmData = new(user, this);
                frmData.ShowDialog(this);
            }
        }

        private User LoginUser()
        {
            if (!string.IsNullOrEmpty(Name.Text) && !string.IsNullOrEmpty(Surname.Text))
            {
                return new User
                {
                    Name = Name.Text,
                    Surname = Surname.Text
                };

            }
            return null;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
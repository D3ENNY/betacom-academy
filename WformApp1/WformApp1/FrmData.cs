using Newtonsoft.Json;

using WformApp1.Models;

namespace WformApp1
{
    public partial class FrmData : Form
    {

        private WFormContext _context;
        private User _user;

        public FrmData(User user, Login login)
        {
            InitializeComponent();
            login.Hide();
            this._user = user;

            welcomeLabel.Text += $" {user.Name} {user.Surname}";

            sendApiBtn.FlatStyle = FlatStyle.Flat;
            sendApiBtn.FlatAppearance.BorderSize = 0;
            getEmployeeBtn.FlatStyle = FlatStyle.Flat;
            getEmployeeBtn.FlatAppearance.BorderSize = 0;

        }

        private void sendApiBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ApiLinkText.Text))
                MessageBox.Show("Indirizzo Http obbligatorio!.");
            else
            {
                HttpClient client = new HttpClient();
                var res = client.GetAsync(ApiLinkText.Text).Result;

                if (res != null)
                    if (res.IsSuccessStatusCode)
                    {
                        var jsObj = res.Content.ReadAsStringAsync().Result;
                        var data = JsonConvert.DeserializeObject<List<Weather>>(jsObj);

                        if (checkClearLst.Checked)
                            lstWeather.Items.Clear();

                        loadWeatherList(data);
                    }
            }
        }

        private void loadWeatherList(List<Weather> weatherList)
        {
            foreach (var weather in weatherList)
            {
                lstWeather.Items.Add($"{weather.Date.ToShortDateString()} | " +
                    $"{weather.TemperatureC,5} | {weather.TemperatureF,-5} | {weather.Summary}");
            }
        }

        private void getEmployeeBtn_Click(object sender, EventArgs e)
        {

            BindingSource bs = new();

            List<AnagraficaGenerale> dipendenti = _context.AnagraficaGenerale.ToList();

            bs.DataSource = dipendenti;
            dataGridEmployee.DataSource = bs;

            DataGridViewTextBoxColumn employeeColumn = new()
            {
                DataPropertyName = "Nominativo",
                HeaderText = "Nome Impiegato"
            };

        }

        private void FrmData_Load(object sender, EventArgs e)
        {
            this._context = new();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            GroupBox gb = new()
            {
                Name = "grpDynamic",
                Location = new Point(1050, 200),
                Text = "Group Box Dinamico",
                Size = new Size(400, 200),
            };

            TextBox tb = new()
            {
                Text = "Box Dinamico",
                Location = new Point(30, 30),

            };

            gb.Controls.Add(tb);
            this.Controls.Add(gb);
        }

        private void apiBtn_Click(object sender, EventArgs e)
        {
            _ = new Api(_user, this).ShowDialog(this);
        }
    }
}

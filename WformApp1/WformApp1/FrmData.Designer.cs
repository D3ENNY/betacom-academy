namespace WformApp1
{
    partial class FrmData
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            welcomeLabel = new Label();
            sendApiBtn = new Button();
            ApiLinkText = new TextBox();
            tempLabel = new Label();
            checkClearLst = new CheckBox();
            lstWeather = new ListBox();
            groupBox1 = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            getEmployeeBtn = new Button();
            dataGridEmployee = new DataGridView();
            panel1 = new Panel();
            button1 = new Button();
            apiBtn = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridEmployee).BeginInit();
            SuspendLayout();
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            welcomeLabel.ForeColor = Color.FromArgb(224, 224, 224);
            welcomeLabel.Location = new Point(30, 33);
            welcomeLabel.Margin = new Padding(4, 0, 4, 0);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(160, 41);
            welcomeLabel.TabIndex = 0;
            welcomeLabel.Text = "Benvenuto";
            // 
            // sendApiBtn
            // 
            sendApiBtn.BackColor = Color.FromArgb(26, 27, 38);
            sendApiBtn.ForeColor = Color.FromArgb(224, 224, 224);
            sendApiBtn.Location = new Point(30, 103);
            sendApiBtn.Margin = new Padding(4, 5, 4, 5);
            sendApiBtn.Name = "sendApiBtn";
            sendApiBtn.Size = new Size(107, 38);
            sendApiBtn.TabIndex = 1;
            sendApiBtn.Text = "Get Temp";
            sendApiBtn.UseVisualStyleBackColor = false;
            sendApiBtn.Click += sendApiBtn_Click;
            // 
            // ApiLinkText
            // 
            ApiLinkText.Location = new Point(177, 103);
            ApiLinkText.Margin = new Padding(4, 5, 4, 5);
            ApiLinkText.Name = "ApiLinkText";
            ApiLinkText.Size = new Size(793, 31);
            ApiLinkText.TabIndex = 2;
            ApiLinkText.Text = "https://localhost:7061/WeatherForecast";
            // 
            // tempLabel
            // 
            tempLabel.AutoSize = true;
            tempLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tempLabel.ForeColor = Color.Lime;
            tempLabel.Location = new Point(30, 167);
            tempLabel.Margin = new Padding(4, 0, 4, 0);
            tempLabel.Name = "tempLabel";
            tempLabel.Size = new Size(279, 32);
            tempLabel.TabIndex = 3;
            tempLabel.Text = "Temperature nel Mondo:";
            // 
            // checkClearLst
            // 
            checkClearLst.AutoSize = true;
            checkClearLst.ForeColor = Color.FromArgb(224, 224, 224);
            checkClearLst.Location = new Point(33, 228);
            checkClearLst.Margin = new Padding(4, 5, 4, 5);
            checkClearLst.Name = "checkClearLst";
            checkClearLst.Size = new Size(245, 29);
            checkClearLst.TabIndex = 4;
            checkClearLst.Text = "Azzera lista al caricamento";
            checkClearLst.UseVisualStyleBackColor = true;
            // 
            // lstWeather
            // 
            lstWeather.FormattingEnabled = true;
            lstWeather.ItemHeight = 25;
            lstWeather.Location = new Point(177, 288);
            lstWeather.Margin = new Padding(4, 5, 4, 5);
            lstWeather.Name = "lstWeather";
            lstWeather.Size = new Size(375, 154);
            lstWeather.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.ForeColor = Color.FromArgb(224, 224, 224);
            groupBox1.Location = new Point(637, 288);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(333, 157);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "VISUALIZZO DETTAGLIO";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(24, 62);
            dateTimePicker1.Margin = new Padding(4, 5, 4, 5);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(284, 31);
            dateTimePicker1.TabIndex = 0;
            // 
            // getEmployeeBtn
            // 
            getEmployeeBtn.BackColor = Color.FromArgb(26, 27, 38);
            getEmployeeBtn.ForeColor = Color.FromArgb(224, 224, 224);
            getEmployeeBtn.Location = new Point(30, 495);
            getEmployeeBtn.Margin = new Padding(4, 5, 4, 5);
            getEmployeeBtn.Name = "getEmployeeBtn";
            getEmployeeBtn.Size = new Size(183, 38);
            getEmployeeBtn.TabIndex = 7;
            getEmployeeBtn.Text = "Ottieni dipendenti";
            getEmployeeBtn.UseVisualStyleBackColor = false;
            getEmployeeBtn.Click += getEmployeeBtn_Click;
            // 
            // dataGridEmployee
            // 
            dataGridEmployee.BackgroundColor = Color.FromArgb(26, 27, 28);
            dataGridEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridEmployee.Location = new Point(30, 562);
            dataGridEmployee.Margin = new Padding(4, 5, 4, 5);
            dataGridEmployee.Name = "dataGridEmployee";
            dataGridEmployee.RowHeadersWidth = 62;
            dataGridEmployee.RowTemplate.Height = 25;
            dataGridEmployee.Size = new Size(940, 187);
            dataGridEmployee.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(997, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 817);
            panel1.TabIndex = 10;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(26, 27, 38);
            button1.ForeColor = Color.FromArgb(224, 224, 224);
            button1.Location = new Point(1170, 99);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(212, 38);
            button1.TabIndex = 11;
            button1.Text = "Generate Components";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // apiBtn
            // 
            apiBtn.BackColor = Color.FromArgb(26, 27, 38);
            apiBtn.ForeColor = Color.FromArgb(224, 224, 224);
            apiBtn.Location = new Point(1170, 633);
            apiBtn.Margin = new Padding(4, 5, 4, 5);
            apiBtn.Name = "apiBtn";
            apiBtn.Size = new Size(212, 38);
            apiBtn.TabIndex = 12;
            apiBtn.Text = "API test";
            apiBtn.UseVisualStyleBackColor = false;
            apiBtn.Click += apiBtn_Click;
            // 
            // FrmData
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(52, 54, 72);
            ClientSize = new Size(1508, 812);
            Controls.Add(apiBtn);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(dataGridEmployee);
            Controls.Add(getEmployeeBtn);
            Controls.Add(groupBox1);
            Controls.Add(lstWeather);
            Controls.Add(checkClearLst);
            Controls.Add(tempLabel);
            Controls.Add(ApiLinkText);
            Controls.Add(sendApiBtn);
            Controls.Add(welcomeLabel);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmData";
            Text = "FrmData";
            Load += FrmData_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridEmployee).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label welcomeLabel;
        private Button sendApiBtn;
        private TextBox ApiLinkText;
        private Label tempLabel;
        private CheckBox checkClearLst;
        private ListBox lstWeather;
        private GroupBox groupBox1;
        private DateTimePicker dateTimePicker1;
        private Button getEmployeeBtn;
        private DataGridView dataGridEmployee;
        private Panel panel1;
        private Button button1;
        private Button apiBtn;
    }
}
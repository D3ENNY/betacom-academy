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
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridEmployee).BeginInit();
            SuspendLayout();
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            welcomeLabel.ForeColor = Color.FromArgb(224, 224, 224);
            welcomeLabel.Location = new Point(21, 20);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(105, 28);
            welcomeLabel.TabIndex = 0;
            welcomeLabel.Text = "Benvenuto";
            // 
            // sendApiBtn
            // 
            sendApiBtn.BackColor = Color.FromArgb(26, 27, 38);
            sendApiBtn.ForeColor = Color.FromArgb(224, 224, 224);
            sendApiBtn.Location = new Point(21, 62);
            sendApiBtn.Name = "sendApiBtn";
            sendApiBtn.Size = new Size(75, 23);
            sendApiBtn.TabIndex = 1;
            sendApiBtn.Text = "Get Temp";
            sendApiBtn.UseVisualStyleBackColor = false;
            sendApiBtn.Click += sendApiBtn_Click;
            // 
            // ApiLinkText
            // 
            ApiLinkText.Location = new Point(124, 62);
            ApiLinkText.Name = "ApiLinkText";
            ApiLinkText.Size = new Size(557, 23);
            ApiLinkText.TabIndex = 2;
            ApiLinkText.Text = "https://localhost:7061/WeatherForecast";
            // 
            // tempLabel
            // 
            tempLabel.AutoSize = true;
            tempLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tempLabel.ForeColor = Color.Lime;
            tempLabel.Location = new Point(21, 100);
            tempLabel.Name = "tempLabel";
            tempLabel.Size = new Size(179, 21);
            tempLabel.TabIndex = 3;
            tempLabel.Text = "Temperature nel Mondo:";
            // 
            // checkClearLst
            // 
            checkClearLst.AutoSize = true;
            checkClearLst.ForeColor = Color.FromArgb(224, 224, 224);
            checkClearLst.Location = new Point(23, 137);
            checkClearLst.Name = "checkClearLst";
            checkClearLst.Size = new Size(165, 19);
            checkClearLst.TabIndex = 4;
            checkClearLst.Text = "Azzera lista al caricamento";
            checkClearLst.UseVisualStyleBackColor = true;
            // 
            // lstWeather
            // 
            lstWeather.FormattingEnabled = true;
            lstWeather.ItemHeight = 15;
            lstWeather.Location = new Point(124, 173);
            lstWeather.Name = "lstWeather";
            lstWeather.Size = new Size(264, 94);
            lstWeather.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.ForeColor = Color.FromArgb(224, 224, 224);
            groupBox1.Location = new Point(448, 173);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(233, 94);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "VISUALIZZO DETTAGLIO";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(17, 37);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 0;
            // 
            // getEmployeeBtn
            // 
            getEmployeeBtn.BackColor = Color.FromArgb(26, 27, 38);
            getEmployeeBtn.ForeColor = Color.FromArgb(224, 224, 224);
            getEmployeeBtn.Location = new Point(21, 297);
            getEmployeeBtn.Name = "getEmployeeBtn";
            getEmployeeBtn.Size = new Size(128, 23);
            getEmployeeBtn.TabIndex = 7;
            getEmployeeBtn.Text = "Ottieni dipendenti";
            getEmployeeBtn.UseVisualStyleBackColor = false;
            getEmployeeBtn.Click += getEmployeeBtn_Click;
            // 
            // dataGridEmployee
            // 
            dataGridEmployee.BackgroundColor = Color.FromArgb(26, 27, 28);
            dataGridEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridEmployee.Location = new Point(21, 337);
            dataGridEmployee.Name = "dataGridEmployee";
            dataGridEmployee.RowTemplate.Height = 25;
            dataGridEmployee.Size = new Size(658, 112);
            dataGridEmployee.TabIndex = 8;
            // 
            // FrmData
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(52, 54, 72);
            ClientSize = new Size(800, 472);
            Controls.Add(dataGridEmployee);
            Controls.Add(getEmployeeBtn);
            Controls.Add(groupBox1);
            Controls.Add(lstWeather);
            Controls.Add(checkClearLst);
            Controls.Add(tempLabel);
            Controls.Add(ApiLinkText);
            Controls.Add(sendApiBtn);
            Controls.Add(welcomeLabel);
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
    }
}
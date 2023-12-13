namespace WformApp1
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            groupBox1 = new GroupBox();
            SubmitBtn = new Button();
            Surname = new TextBox();
            Name = new TextBox();
            label2 = new Label();
            label3 = new Label();
            CancelBtn = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(224, 224, 224);
            label1.Location = new Point(156, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(213, 54);
            label1.TabIndex = 0;
            label1.Text = "login page";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(CancelBtn);
            groupBox1.Controls.Add(SubmitBtn);
            groupBox1.Controls.Add(Surname);
            groupBox1.Controls.Add(Name);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.ForeColor = Color.FromArgb(224, 224, 224);
            groupBox1.Location = new Point(120, 82);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(291, 344);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Insert data";
            // 
            // SubmitBtn
            // 
            SubmitBtn.BackColor = Color.FromArgb(26, 27, 38);
            SubmitBtn.Cursor = Cursors.Hand;
            SubmitBtn.ForeColor = Color.FromArgb(224, 224, 224);
            SubmitBtn.Location = new Point(26, 224);
            SubmitBtn.Margin = new Padding(4, 5, 4, 5);
            SubmitBtn.Name = "SubmitBtn";
            SubmitBtn.Padding = new Padding(3);
            SubmitBtn.Size = new Size(241, 48);
            SubmitBtn.TabIndex = 4;
            SubmitBtn.Text = "Submit";
            SubmitBtn.UseVisualStyleBackColor = false;
            SubmitBtn.Click += SubmitBtn_Click;
            // 
            // Surname
            // 
            Surname.Location = new Point(26, 170);
            Surname.Margin = new Padding(4, 5, 4, 5);
            Surname.Name = "Surname";
            Surname.Size = new Size(241, 31);
            Surname.TabIndex = 3;
            Surname.Text = "Raimondi";
            // 
            // Name
            // 
            Name.Location = new Point(26, 82);
            Name.Margin = new Padding(4, 5, 4, 5);
            Name.Name = "Name";
            Name.Size = new Size(241, 31);
            Name.TabIndex = 2;
            Name.Text = "Denys";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 140);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(95, 25);
            label2.TabIndex = 1;
            label2.Text = "Cognome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 52);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(65, 25);
            label3.TabIndex = 0;
            label3.Text = "Nome:";
            // 
            // CancelBtn
            // 
            CancelBtn.BackColor = Color.FromArgb(26, 27, 38);
            CancelBtn.Cursor = Cursors.Hand;
            CancelBtn.ForeColor = Color.FromArgb(224, 224, 224);
            CancelBtn.Location = new Point(26, 282);
            CancelBtn.Margin = new Padding(4, 5, 4, 5);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Padding = new Padding(3);
            CancelBtn.Size = new Size(241, 48);
            CancelBtn.TabIndex = 5;
            CancelBtn.Text = "Cancel";
            CancelBtn.UseVisualStyleBackColor = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(52, 54, 76);
            ClientSize = new Size(544, 462);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Button SubmitBtn;
        private TextBox Surname;
        private TextBox Name;
        private Button CancelBtn;
    }
}
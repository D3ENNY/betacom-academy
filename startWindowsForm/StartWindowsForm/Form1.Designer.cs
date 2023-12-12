namespace StartWindowsForm
{
    partial class Form1
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
            nameLabel = new Label();
            inputName = new TextBox();
            button1 = new Button();
            showName = new CheckBox();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(115, 43);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(84, 15);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Inserire Nome:";
            // 
            // inputName
            // 
            inputName.Location = new Point(85, 72);
            inputName.Name = "inputName";
            inputName.Size = new Size(143, 23);
            inputName.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(85, 133);
            button1.Name = "button1";
            button1.Size = new Size(143, 23);
            button1.TabIndex = 2;
            button1.Text = "Premimi";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Submit;
            // 
            // showName
            // 
            showName.AutoSize = true;
            showName.Location = new Point(85, 101);
            showName.Name = "showName";
            showName.Size = new Size(97, 19);
            showName.TabIndex = 3;
            showName.Text = "mostra nome";
            showName.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(294, 318);
            Controls.Add(showName);
            Controls.Add(button1);
            Controls.Add(inputName);
            Controls.Add(nameLabel);
            Name = "Form1";
            Text = "StartWindowsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLabel;
        private TextBox inputName;
        private Button button1;
        private CheckBox showName;
    }
}
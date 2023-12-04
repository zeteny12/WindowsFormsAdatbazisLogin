namespace WindowsFormsAdatbazisLogin
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Nev = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Jelszo = new System.Windows.Forms.TextBox();
            this.button_Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(67, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Felhasználónév:";
            // 
            // textBox_Nev
            // 
            this.textBox_Nev.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBox_Nev.Location = new System.Drawing.Point(260, 57);
            this.textBox_Nev.Name = "textBox_Nev";
            this.textBox_Nev.Size = new System.Drawing.Size(238, 34);
            this.textBox_Nev.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(166, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Jelszó:";
            // 
            // textBox_Jelszo
            // 
            this.textBox_Jelszo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBox_Jelszo.Location = new System.Drawing.Point(260, 125);
            this.textBox_Jelszo.Name = "textBox_Jelszo";
            this.textBox_Jelszo.Size = new System.Drawing.Size(238, 34);
            this.textBox_Jelszo.TabIndex = 1;
            // 
            // button_Login
            // 
            this.button_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button_Login.Location = new System.Drawing.Point(72, 238);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(426, 64);
            this.button_Login.TabIndex = 2;
            this.button_Login.Text = "Bejelentlezés";
            this.button_Login.UseVisualStyleBackColor = true;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(580, 360);
            this.Controls.Add(this.button_Login);
            this.Controls.Add(this.textBox_Jelszo);
            this.Controls.Add(this.textBox_Nev);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Nev;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Jelszo;
        private System.Windows.Forms.Button button_Login;
    }
}


namespace WindowsFormsAdatbazisLogin
{
    partial class UjTermek
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UjTermek));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_UjTermekNev = new System.Windows.Forms.TextBox();
            this.numericUpDown_UjTermekAr = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_UjTermekDarabszam = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_UjTermekAr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_UjTermekDarabszam)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(183, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Új termék hozzáadása";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(91, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Termék neve:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(10, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Termék ára forintban:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(25, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Termék darabszám:";
            // 
            // textBox_UjTermekNev
            // 
            this.textBox_UjTermekNev.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBox_UjTermekNev.Location = new System.Drawing.Point(258, 89);
            this.textBox_UjTermekNev.Name = "textBox_UjTermekNev";
            this.textBox_UjTermekNev.Size = new System.Drawing.Size(329, 34);
            this.textBox_UjTermekNev.TabIndex = 1;
            // 
            // numericUpDown_UjTermekAr
            // 
            this.numericUpDown_UjTermekAr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.numericUpDown_UjTermekAr.Location = new System.Drawing.Point(258, 148);
            this.numericUpDown_UjTermekAr.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDown_UjTermekAr.Name = "numericUpDown_UjTermekAr";
            this.numericUpDown_UjTermekAr.Size = new System.Drawing.Size(174, 34);
            this.numericUpDown_UjTermekAr.TabIndex = 2;
            this.numericUpDown_UjTermekAr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericUpDown_UjTermekDarabszam
            // 
            this.numericUpDown_UjTermekDarabszam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.numericUpDown_UjTermekDarabszam.Location = new System.Drawing.Point(258, 205);
            this.numericUpDown_UjTermekDarabszam.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDown_UjTermekDarabszam.Name = "numericUpDown_UjTermekDarabszam";
            this.numericUpDown_UjTermekDarabszam.Size = new System.Drawing.Size(174, 34);
            this.numericUpDown_UjTermekDarabszam.TabIndex = 2;
            this.numericUpDown_UjTermekDarabszam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button1.Location = new System.Drawing.Point(258, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(329, 47);
            this.button1.TabIndex = 3;
            this.button1.Text = "Termék hozzáadása";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UjTermek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 374);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDown_UjTermekDarabszam);
            this.Controls.Add(this.numericUpDown_UjTermekAr);
            this.Controls.Add(this.textBox_UjTermekNev);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UjTermek";
            this.Text = "Új termék hozzáadása";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_UjTermekAr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_UjTermekDarabszam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_UjTermekNev;
        private System.Windows.Forms.NumericUpDown numericUpDown_UjTermekAr;
        private System.Windows.Forms.NumericUpDown numericUpDown_UjTermekDarabszam;
        private System.Windows.Forms.Button button1;
    }
}
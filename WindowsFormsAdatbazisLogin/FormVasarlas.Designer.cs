namespace WindowsFormsAdatbazisLogin
{
    partial class FormVasarlas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVasarlas));
            this.listBox_Termekek = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_RendelesLeadasa = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_KivalasztottTermekNev = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown_TermekAr = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown_Raktaron = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox_TermekID = new System.Windows.Forms.TextBox();
            this.numericUpDown_Darabszam = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.termékToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.újToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.módosításToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.törlésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.felhasználóToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_TermekAr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Raktaron)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Darabszam)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox_Termekek
            // 
            this.listBox_Termekek.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.listBox_Termekek.FormattingEnabled = true;
            this.listBox_Termekek.ItemHeight = 29;
            this.listBox_Termekek.Location = new System.Drawing.Point(0, 39);
            this.listBox_Termekek.Name = "listBox_Termekek";
            this.listBox_Termekek.Size = new System.Drawing.Size(400, 381);
            this.listBox_Termekek.TabIndex = 0;
            this.listBox_Termekek.SelectedIndexChanged += new System.EventHandler(this.listBox_Termekek_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(419, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kívánt darabszám:";
            // 
            // button_RendelesLeadasa
            // 
            this.button_RendelesLeadasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button_RendelesLeadasa.Location = new System.Drawing.Point(415, 362);
            this.button_RendelesLeadasa.Name = "button_RendelesLeadasa";
            this.button_RendelesLeadasa.Size = new System.Drawing.Size(369, 52);
            this.button_RendelesLeadasa.TabIndex = 5;
            this.button_RendelesLeadasa.Text = "Rendelés leadása";
            this.button_RendelesLeadasa.UseVisualStyleBackColor = true;
            this.button_RendelesLeadasa.Click += new System.EventHandler(this.button_RendelesLeadasa_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(419, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Termék neve:";
            // 
            // textBox_KivalasztottTermekNev
            // 
            this.textBox_KivalasztottTermekNev.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBox_KivalasztottTermekNev.Location = new System.Drawing.Point(586, 90);
            this.textBox_KivalasztottTermekNev.Name = "textBox_KivalasztottTermekNev";
            this.textBox_KivalasztottTermekNev.Size = new System.Drawing.Size(198, 34);
            this.textBox_KivalasztottTermekNev.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(419, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Termék ára:";
            // 
            // numericUpDown_TermekAr
            // 
            this.numericUpDown_TermekAr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.numericUpDown_TermekAr.Location = new System.Drawing.Point(586, 151);
            this.numericUpDown_TermekAr.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDown_TermekAr.Name = "numericUpDown_TermekAr";
            this.numericUpDown_TermekAr.Size = new System.Drawing.Size(198, 34);
            this.numericUpDown_TermekAr.TabIndex = 6;
            this.numericUpDown_TermekAr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(419, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Raktáron (db):";
            // 
            // numericUpDown_Raktaron
            // 
            this.numericUpDown_Raktaron.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.numericUpDown_Raktaron.Location = new System.Drawing.Point(586, 209);
            this.numericUpDown_Raktaron.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDown_Raktaron.Name = "numericUpDown_Raktaron";
            this.numericUpDown_Raktaron.Size = new System.Drawing.Size(198, 34);
            this.numericUpDown_Raktaron.TabIndex = 6;
            this.numericUpDown_Raktaron.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.Location = new System.Drawing.Point(419, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 29);
            this.label5.TabIndex = 3;
            this.label5.Text = "TermékID:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBox1.Location = new System.Drawing.Point(586, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(198, 34);
            this.textBox1.TabIndex = 4;
            // 
            // textBox_TermekID
            // 
            this.textBox_TermekID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBox_TermekID.Location = new System.Drawing.Point(586, 39);
            this.textBox_TermekID.Name = "textBox_TermekID";
            this.textBox_TermekID.ReadOnly = true;
            this.textBox_TermekID.Size = new System.Drawing.Size(198, 34);
            this.textBox_TermekID.TabIndex = 4;
            // 
            // numericUpDown_Darabszam
            // 
            this.numericUpDown_Darabszam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.numericUpDown_Darabszam.Location = new System.Drawing.Point(633, 306);
            this.numericUpDown_Darabszam.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDown_Darabszam.Name = "numericUpDown_Darabszam";
            this.numericUpDown_Darabszam.Size = new System.Drawing.Size(151, 34);
            this.numericUpDown_Darabszam.TabIndex = 6;
            this.numericUpDown_Darabszam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.termékToolStripMenuItem,
            this.felhasználóToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // termékToolStripMenuItem
            // 
            this.termékToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.újToolStripMenuItem,
            this.módosításToolStripMenuItem,
            this.törlésToolStripMenuItem});
            this.termékToolStripMenuItem.Name = "termékToolStripMenuItem";
            this.termékToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.termékToolStripMenuItem.Text = "Termék";
            // 
            // újToolStripMenuItem
            // 
            this.újToolStripMenuItem.Name = "újToolStripMenuItem";
            this.újToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.újToolStripMenuItem.Text = "Új";
            this.újToolStripMenuItem.Click += new System.EventHandler(this.újToolStripMenuItem_Click);
            // 
            // módosításToolStripMenuItem
            // 
            this.módosításToolStripMenuItem.Name = "módosításToolStripMenuItem";
            this.módosításToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.módosításToolStripMenuItem.Text = "Módosítás";
            this.módosításToolStripMenuItem.Click += new System.EventHandler(this.módosításToolStripMenuItem_Click);
            // 
            // törlésToolStripMenuItem
            // 
            this.törlésToolStripMenuItem.Name = "törlésToolStripMenuItem";
            this.törlésToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.törlésToolStripMenuItem.Text = "Törlés";
            this.törlésToolStripMenuItem.Click += new System.EventHandler(this.törlésToolStripMenuItem_Click);
            // 
            // felhasználóToolStripMenuItem
            // 
            this.felhasználóToolStripMenuItem.Name = "felhasználóToolStripMenuItem";
            this.felhasználóToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.felhasználóToolStripMenuItem.Text = "Felhasználó";
            // 
            // FormVasarlas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numericUpDown_Darabszam);
            this.Controls.Add(this.numericUpDown_Raktaron);
            this.Controls.Add(this.numericUpDown_TermekAr);
            this.Controls.Add(this.button_RendelesLeadasa);
            this.Controls.Add(this.textBox_TermekID);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox_KivalasztottTermekNev);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox_Termekek);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormVasarlas";
            this.Text = "FormVasarlas";
            this.Load += new System.EventHandler(this.FormVasarlas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_TermekAr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Raktaron)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Darabszam)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Termekek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_RendelesLeadasa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_KivalasztottTermekNev;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown_TermekAr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown_Raktaron;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox_TermekID;
        private System.Windows.Forms.NumericUpDown numericUpDown_Darabszam;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem termékToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem újToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem módosításToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem törlésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem felhasználóToolStripMenuItem;
    }
}
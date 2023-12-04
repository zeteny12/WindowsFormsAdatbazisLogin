namespace WindowsFormsAdatbazisLogin
{
    partial class Modositas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Modositas));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown_TermekAzonModositas = new System.Windows.Forms.NumericUpDown();
            this.textBox_TermekNevModosit = new System.Windows.Forms.TextBox();
            this.numericUpDown_TermekArModosit = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_TermekDarabszamModosit = new System.Windows.Forms.NumericUpDown();
            this.button_TernekadatokModositasa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_TermekAzonModositas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_TermekArModosit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_TermekDarabszamModosit)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(133, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Termék módosítása";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Termék azonosítója:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(82, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Termék neve:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(100, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "Termék ára:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.Location = new System.Drawing.Point(128, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 29);
            this.label5.TabIndex = 1;
            this.label5.Text = "Raktáron:";
            // 
            // numericUpDown_TermekAzonModositas
            // 
            this.numericUpDown_TermekAzonModositas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.numericUpDown_TermekAzonModositas.Location = new System.Drawing.Point(264, 75);
            this.numericUpDown_TermekAzonModositas.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown_TermekAzonModositas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_TermekAzonModositas.Name = "numericUpDown_TermekAzonModositas";
            this.numericUpDown_TermekAzonModositas.Size = new System.Drawing.Size(181, 34);
            this.numericUpDown_TermekAzonModositas.TabIndex = 2;
            this.numericUpDown_TermekAzonModositas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown_TermekAzonModositas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_TermekAzonModositas.ValueChanged += new System.EventHandler(this.numericUpDown_TermekAzonModositas_ValueChanged);
            // 
            // textBox_TermekNevModosit
            // 
            this.textBox_TermekNevModosit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBox_TermekNevModosit.Location = new System.Drawing.Point(264, 123);
            this.textBox_TermekNevModosit.Name = "textBox_TermekNevModosit";
            this.textBox_TermekNevModosit.Size = new System.Drawing.Size(181, 34);
            this.textBox_TermekNevModosit.TabIndex = 3;
            // 
            // numericUpDown_TermekArModosit
            // 
            this.numericUpDown_TermekArModosit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.numericUpDown_TermekArModosit.Location = new System.Drawing.Point(264, 175);
            this.numericUpDown_TermekArModosit.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown_TermekArModosit.Name = "numericUpDown_TermekArModosit";
            this.numericUpDown_TermekArModosit.Size = new System.Drawing.Size(181, 34);
            this.numericUpDown_TermekArModosit.TabIndex = 2;
            this.numericUpDown_TermekArModosit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericUpDown_TermekDarabszamModosit
            // 
            this.numericUpDown_TermekDarabszamModosit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.numericUpDown_TermekDarabszamModosit.Location = new System.Drawing.Point(264, 228);
            this.numericUpDown_TermekDarabszamModosit.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown_TermekDarabszamModosit.Name = "numericUpDown_TermekDarabszamModosit";
            this.numericUpDown_TermekDarabszamModosit.Size = new System.Drawing.Size(181, 34);
            this.numericUpDown_TermekDarabszamModosit.TabIndex = 2;
            this.numericUpDown_TermekDarabszamModosit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_TernekadatokModositasa
            // 
            this.button_TernekadatokModositasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button_TernekadatokModositasa.Location = new System.Drawing.Point(133, 301);
            this.button_TernekadatokModositasa.Name = "button_TernekadatokModositasa";
            this.button_TernekadatokModositasa.Size = new System.Drawing.Size(229, 51);
            this.button_TernekadatokModositasa.TabIndex = 4;
            this.button_TernekadatokModositasa.Text = "Módosítás";
            this.button_TernekadatokModositasa.UseVisualStyleBackColor = true;
            this.button_TernekadatokModositasa.Click += new System.EventHandler(this.button_TernekadatokModositasa_Click);
            // 
            // Modositas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 374);
            this.Controls.Add(this.button_TernekadatokModositasa);
            this.Controls.Add(this.textBox_TermekNevModosit);
            this.Controls.Add(this.numericUpDown_TermekDarabszamModosit);
            this.Controls.Add(this.numericUpDown_TermekArModosit);
            this.Controls.Add(this.numericUpDown_TermekAzonModositas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Modositas";
            this.Text = "Termék módosítása";
            this.Load += new System.EventHandler(this.Modositas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_TermekAzonModositas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_TermekArModosit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_TermekDarabszamModosit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown_TermekAzonModositas;
        private System.Windows.Forms.TextBox textBox_TermekNevModosit;
        private System.Windows.Forms.NumericUpDown numericUpDown_TermekArModosit;
        private System.Windows.Forms.NumericUpDown numericUpDown_TermekDarabszamModosit;
        private System.Windows.Forms.Button button_TernekadatokModositasa;
    }
}
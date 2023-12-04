namespace WindowsFormsAdatbazisLogin
{
    partial class Torles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Torles));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown_TermekAzonTorles = new System.Windows.Forms.NumericUpDown();
            this.button_TermekTorlese = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_TermekAzonTorles)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(132, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Termék törlése";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(13, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Termék azonosítója:";
            // 
            // numericUpDown_TermekAzonTorles
            // 
            this.numericUpDown_TermekAzonTorles.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.numericUpDown_TermekAzonTorles.Location = new System.Drawing.Point(264, 85);
            this.numericUpDown_TermekAzonTorles.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_TermekAzonTorles.Name = "numericUpDown_TermekAzonTorles";
            this.numericUpDown_TermekAzonTorles.Size = new System.Drawing.Size(113, 34);
            this.numericUpDown_TermekAzonTorles.TabIndex = 2;
            this.numericUpDown_TermekAzonTorles.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown_TermekAzonTorles.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button_TermekTorlese
            // 
            this.button_TermekTorlese.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button_TermekTorlese.Location = new System.Drawing.Point(111, 168);
            this.button_TermekTorlese.Name = "button_TermekTorlese";
            this.button_TermekTorlese.Size = new System.Drawing.Size(215, 58);
            this.button_TermekTorlese.TabIndex = 3;
            this.button_TermekTorlese.Text = "Termék törlése";
            this.button_TermekTorlese.UseVisualStyleBackColor = true;
            this.button_TermekTorlese.Click += new System.EventHandler(this.button_TermekTorlese_Click);
            // 
            // Torles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 253);
            this.Controls.Add(this.button_TermekTorlese);
            this.Controls.Add(this.numericUpDown_TermekAzonTorles);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Torles";
            this.Text = "Termék törlése";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_TermekAzonTorles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown_TermekAzonTorles;
        private System.Windows.Forms.Button button_TermekTorlese;
    }
}
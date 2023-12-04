using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAdatbazisLogin
{
    public partial class FormVasarlas : Form
    {
        public FormVasarlas()
        {
            InitializeComponent();
        }

        //Megnyitás
        private void FormVasarlas_Load(object sender, EventArgs e)
        {
            TermekekBetoltese();
        }
        
        //Termékek betöltése
        private void TermekekBetoltese()
        {
            //Lista tisztítása
            listBox_Termekek.Items.Clear();

            //
            try
            {
                //Ha nincs csatlakozva, akkor csatlakozunk
                if (Program.connection.State != ConnectionState.Open)
                {
                    Program.connection.Open();
                }

                //SQL parancs
                Program.command.CommandText = "SELECT * FROM `termek`;";
                using (MySqlDataReader dr = Program.command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        //Adatok kinyerése
                        Termek beolvasottTermek = new Termek(dr.GetInt32("termekid"), dr.GetString("termek_nev"), dr.GetInt32("termek_ar"), dr.GetInt32("db"));
                        listBox_Termekek.Items.Add(beolvasottTermek);   //Kiiratás
                    }
                }
            }
            catch (Exception ex)    //Hiba
            {
                MessageBox.Show(ex.Message);
                Environment.Exit(0);
            }
        }

        //Rendelés leadása GOMB
        private void button_RendelesLeadasa_Click(object sender, EventArgs e)
        {
            MySqlTransaction tr = null;
            decimal vegosszeg = numericUpDown_Darabszam.Value * numericUpDown_TermekAr.Value;
            string szoveg = $"Valóban meg akarja vásárolni a következőt?: {numericUpDown_Darabszam.Value} darabot ebből, {textBox_KivalasztottTermekNev.Text}? Végösszeg: {vegosszeg}Ft";
            

            DialogResult result = MessageBox.Show(szoveg, "Vásárlás megerősítése", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    tr = Program.connection.BeginTransaction();
                    Program.command.Transaction = tr;
                    Program.command.CommandText = "INSERT INTO `vasarlas` (`vasarloid`, `termekid`, `datum`, `vasarolt_darab`) VALUES ('@vasarloid', '@termekid', '@vasarolt_darab');";
                    Program.command.Parameters.Clear();
                    Program.command.Parameters.AddWithValue("@vasarloid", Program.Userid);
                    Program.command.Parameters.AddWithValue("@termekid", textBox_TermekID.Text);
                    Program.command.Parameters.AddWithValue("@vasarolt_darab", numericUpDown_Darabszam.Value);
                    Program.command.ExecuteNonQuery();
                    Program.command.CommandText = "UPDATE termek SET `vasarolt_darab` = `vasarolt_darab` - @vasarolt_darab WHERE `termekid` = @termekid";
                    Program.command.ExecuteNonQuery();
                    tr.Commit();
                }
                catch (MySqlException ex)
                {
                    tr.Rollback();
                    MessageBox.Show(ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                TermekekBetoltese();
                textBox_TermekID.Text = "";
                textBox_KivalasztottTermekNev.Text = "";
                numericUpDown_TermekAr.Value = numericUpDown_TermekAr.Minimum;
                numericUpDown_Raktaron.Value = numericUpDown_Raktaron.Minimum;
                numericUpDown_Darabszam.Value = numericUpDown_Darabszam.Minimum;
                MessageBox.Show("Sikeres vásárlás!");
            }

            
        }

        //Lista kijelölt eleme
        private void listBox_Termekek_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_Termekek.SelectedIndex >= 0)
            {
                Termek selectedTermek = (Termek)listBox_Termekek.SelectedItem;
                textBox_TermekID.Text = selectedTermek.Termekid.ToString();
                textBox_KivalasztottTermekNev.Text = selectedTermek.Termek_nev;
                numericUpDown_TermekAr.Value = selectedTermek.Termek_ar;
                numericUpDown_Raktaron.Value = selectedTermek.Db;
                numericUpDown_Darabszam.Maximum = selectedTermek.Db;
                
            }
        }

        //Új termék hozzáadása
        private void újToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.ujTermek.ShowDialog();
        }

        private void módosításToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.modositas.ShowDialog();
        }

        private void törlésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.torles.ShowDialog();
        }
    }
}

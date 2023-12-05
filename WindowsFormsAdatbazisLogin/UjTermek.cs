using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAdatbazisLogin
{
    public partial class UjTermek : Form
    {
        public UjTermek()
        {
            InitializeComponent();
        }

        //Gomb
        private void button1_Click(object sender, EventArgs e)
        {
            //Megerősítö szöveg a felhasználónak
            string szoveg = "Valóban hozzá akarja adni ezt a terméket?: " + textBox_UjTermekNev.Text + ", ára: " + numericUpDown_UjTermekAr.Value + "Ft, darabszám: " + numericUpDown_UjTermekDarabszam.Value + " db";

            //Ennek megjelenítése felugró ablakkal
            DialogResult result = MessageBox.Show(szoveg, "Figyelem!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            //Ha a felhasználó 'igen'-re ment
            if (result == DialogResult.Yes)
            {
                try
                {
                    //Adatbázis kapcsolat megnyitása, ha még nincs megnyitva
                    if (Program.connection.State != ConnectionState.Open)
                    {
                        Program.connection.Open();
                    }

                    //'Program.command' objektum
                    Program.command.CommandText = "INSERT INTO termek (termek_nev, termek_ar, db) VALUES (@nev, @ar, @darab);";
                    Program.command.Parameters.Clear();
                    Program.command.Parameters.AddWithValue("@nev", textBox_UjTermekNev.Text);
                    Program.command.Parameters.AddWithValue("@ar", numericUpDown_UjTermekAr.Value);
                    Program.command.Parameters.AddWithValue("@darab", numericUpDown_UjTermekDarabszam.Value);

                    //Futtatása
                    Program.command.ExecuteNonQuery();

                    //Közöljük, hogy sikeres volt
                    MessageBox.Show("A termék hozzáadása sikeres volt!");
                }
                catch (MySqlException ex)
                {
                    //Adatbázisműveletek közbeni hibák kezelése és hibaüzenet megjelenítése
                    MessageBox.Show("Hiba történt az adatbázis művelet közben: " + ex.Message);
                }

                //Új termék felvétele után ismét frissítjük a lista tartalmát
                Program.formVasarlas.TermekekBetoltese();

                //Kapcsolat zárása
                Program.connection.Close();
            }
        }
    }
}

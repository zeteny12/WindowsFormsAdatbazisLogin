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
    public partial class Modositas : Form
    {
        public Modositas()
        {
            InitializeComponent();
        }

        //Megynitás
        private void Modositas_Load(object sender, EventArgs e)
        {
            Beolvasas();
        }

        //'id' mező változtatása
        private void numericUpDown_TermekAzonModositas_ValueChanged(object sender, EventArgs e)
        {
            Beolvasas();
        }

        //Adatok kiolvasása az adatbázisból
        private void Beolvasas()
        {
            //Adatok kiolvasása az adatbázisból 'id' alapján
            int termekId = Convert.ToInt32(numericUpDown_TermekAzonModositas.Value);

            try
            {
                //Adatbázis kapcsolat megnyitása, ha még nincs megnyitva
                if (Program.connection.State != ConnectionState.Open)
                {
                    Program.connection.Open();
                }

                //SQL parancs
                string query = "SELECT termek_nev, termek_ar, db FROM termek WHERE termekid = @termekId;";

                //'Program.command' objektum
                Program.command.CommandText = query;
                Program.command.Parameters.Clear();
                Program.command.Parameters.AddWithValue("@termekId", termekId);

                using (MySqlDataReader reader = Program.command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        //A talált adatok megjelenítése
                        textBox_TermekNevModosit.Text = reader["termek_nev"].ToString();
                        numericUpDown_TermekArModosit.Value = Convert.ToDecimal(reader["termek_ar"]);
                        numericUpDown_TermekDarabszamModosit.Value = Convert.ToDecimal(reader["db"]);
                    }
                    else
                    {
                        //Ha nincs találat, akkor nem jelenítünk meg semmit
                        textBox_TermekNevModosit.Text = "";
                        numericUpDown_TermekArModosit.Value = 0;
                        numericUpDown_TermekDarabszamModosit.Value = 0;
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Hiba történt az adatbázis művelet közben: " + ex.Message);
            }
            //Kapcsolat zárása
            Program.connection.Close();
        }

        //Termék módosítása
        private void button_TernekadatokModositasa_Click(object sender, EventArgs e)
        {
            try
            {
                //Adatbázis kapcsolat megnyitása, ha még nincs megnyitva
                if (Program.connection.State != ConnectionState.Open)
                {
                    Program.connection.Open();
                }

                //Ellenőrizzük, hogy az 'id' meg van-e adva
                int termekId = Convert.ToInt32(numericUpDown_TermekAzonModositas.Value);

                //SQL parancs
                string updateQuery = "UPDATE termek SET termek_nev = @nev, termek_ar = @ar, db = @darab WHERE termekid = @termekId;";

                //'Program.command' objektum
                Program.command.CommandText = updateQuery;
                Program.command.Parameters.Clear();
                Program.command.Parameters.AddWithValue("@nev", textBox_TermekNevModosit.Text);
                Program.command.Parameters.AddWithValue("@ar", numericUpDown_TermekArModosit.Value);
                Program.command.Parameters.AddWithValue("@darab", numericUpDown_TermekDarabszamModosit.Value);
                Program.command.Parameters.AddWithValue("@termekId", termekId);

                //Futtatása
                int affectedRows = Program.command.ExecuteNonQuery();

                //Válasz a felhasználónak
                if (affectedRows > 0)
                {
                    MessageBox.Show("Az adatok módosítása sikeres volt!");
                }
                else
                {
                    MessageBox.Show("Az adatok módosítása nem sikerült.");
                }
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

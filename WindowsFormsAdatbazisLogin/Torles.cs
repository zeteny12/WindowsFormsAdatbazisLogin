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
    public partial class Torles : Form
    {
        public Torles()
        {
            InitializeComponent();
        }

        //Termék törlése
        private void button_TermekTorlese_Click(object sender, EventArgs e)
        {
            try
            {
                //Adatbázis kapcsolat megnyitása, ha még nincs megnyitva
                if (Program.connection.State != ConnectionState.Open)
                {
                    Program.connection.Open();
                }

                // Ellenőrizzük, hogy az "id" meg van-e adva
                int termekId = Convert.ToInt32(numericUpDown_TermekAzonTorles.Value);

                //SQL parancs
                string deleteQuery = "DELETE FROM termek WHERE termekid = @termekId;";

                //'Program.command' objektum
                Program.command.CommandText = deleteQuery;
                Program.command.Parameters.Clear();
                Program.command.Parameters.AddWithValue("@termekId", termekId);

                //Futtatása
                int affectedRows = Program.command.ExecuteNonQuery();

                //Közöljük a felhasználóval
                if (affectedRows > 0)
                {
                    MessageBox.Show("Az adatok törlése sikeres volt!");
                }
                else
                {
                    MessageBox.Show("Az adatok törlése nem sikerült. Lehet, hogy az adott 'id' nem létezik.");
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

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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            Program.command.CommandText = "SELECT vasarlo.jelszo, vasarlo.vasarloid FROM vasarlo WHERE vasarlo.nev = @nev";
            Program.command.Parameters.Clear();
            Program.command.Parameters.AddWithValue("@nev", textBox_Nev.Text);
            MySqlDataReader reader = Program.command.ExecuteReader();
            if (reader.Read())
            {
                string taroltJelszo = reader.GetString("jelszo");   //'getString' -- érték kiolvasása
                Program.Userid = reader.GetInt32("vasarloid");
                reader.Close();

                if (taroltJelszo == textBox_Jelszo.Text)    //Megegyezik-e a jelszó
                {
                    //Ha igen, akkor megnyitjuk a 'formVasarlas'-t
                    Program.formVasarlas.Show();
                    this.Hide();    //'formLogin' elrejtése
                    
                }
            }
        }
    }
}

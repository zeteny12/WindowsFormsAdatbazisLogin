using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsAdatbazisLogin
{
    internal static class Program
    {
        //A többi osztályban is használható
        public static FormLogin formLogin = null;
        public static FormVasarlas formVasarlas = null;
        public static UjTermek ujTermek = null;
        public static Modositas modositas = null;
        public static Torles torles = null;
        public static MySqlConnection connection = null;
        public static MySqlCommand command = null;
        public static Int32 Userid;

        //MAIN
        static void Main()
        {
            //Objektumok inicializálása -- Csatlakozás
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "vasarlas";
            builder.CharacterSet = "utf8";

            //
            connection = new MySqlConnection(builder.ConnectionString);
            command = connection.CreateCommand();

            try
            {
                connection.Open();   
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                Environment.Exit(0);
            }
            
            //
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //
            formLogin = new FormLogin();
            formVasarlas = new FormVasarlas();
            ujTermek = new UjTermek();
            modositas = new Modositas();
            torles = new Torles();
            
            //Melyik rész legyen futtatva
            Application.Run(formLogin);
        }
    }
}

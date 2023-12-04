using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAdatbazisLogin
{
    internal class Termek
    {
        private int termekid;
        private string termek_nev;
        private int termek_ar;
        private int db;

        public Termek(int termekid, string termek_nev, int termek_ar, int db)
        {
            this.Termekid = termekid;
            this.Termek_nev = termek_nev;
            this.Termek_ar = termek_ar;
            this.Db = db;
        }

        public int Termekid { get => termekid; set => termekid = value; }
        public string Termek_nev { get => termek_nev; set => termek_nev = value; }
        public int Termek_ar { get => termek_ar; set => termek_ar = value; }
        public int Db { get => db; set => db = value; }

        public override string ToString()
        {
            //' $"{...}" ' -- több érték visszaadásánál
            return $"{Termek_nev}, {Termek_ar}Ft, raktáron: {Db}db";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace markoGalavićProvjera
{
    class Osoba
    {
        string ime;
        string prezime;
        string oIB;

        string datumRodenja;

        public string Ime { get => Ime; set => Ime = value; }
        public string Prezime { get => Prezime; set => Prezime = value; }
        public string OIB { get => OIB; set => OIB = value; }
        public string DatumRođenja { get => datumRodenja; set => datumRodenja = value; }

        public Osoba()
        {

        }
        public Osoba(string ime,string prezime,string oib,string datumRodenja)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.oIB = oib;
            this.datumRodenja = datumRodenja;
        }
        public override string ToString()
        {
            return ime + " " + prezime + " " + oIB + " " + datumRodenja;
        }
    }
}

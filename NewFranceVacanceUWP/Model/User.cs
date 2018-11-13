using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewFranceVacanceUWP.Model
{
    class User
    {
        public string Navn { get; set; }
        public string Adresse { get; set; }
        public string Email { get; set; }
        public int TelefonNr { get; set; }

        public User()
        {
        }
        public User(string navn, string adresse, string email, int telefonNr)
        {
            Navn = navn;
            Adresse = adresse;
            Email = email;
            TelefonNr = telefonNr;
        }

        public override string ToString()
        {
            return string.Format($"Navn: {Navn}, Adresse: {Adresse}, Email: {Email}, Telefon Nr: {TelefonNr}");
        }
    }
}

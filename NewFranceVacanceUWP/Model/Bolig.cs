using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewFranceVacanceUWP.Model
{
    class Bolig
    {
        public int AntalPersoner { get; set; }
        public int AntalSoveværelser { get; set; }
        public string Type { get; set; }
        public int AntalBadeværelser { get; set; }
        public int Kvadratmeter { get; set; }
        public string Adresse { get; set; }
        public double Rating { get; set; }
        public bool Husdyr { get; set; }
        //public Udlejer Owner { get; set; 
        //TODO: Lav association til owner class?

        //TODO: Dictionary for featueres?

        public Bolig() { }
        public Bolig(int antalPersoner, int antalSoveværelser, string type,
            int antalBadeværelser, int kvadratmeter, string adresse,
            double rating, bool husdyr)
        {
            AntalPersoner = antalPersoner;
            AntalSoveværelser = antalSoveværelser;
            Type = type;
            AntalBadeværelser = antalBadeværelser;
            Kvadratmeter = kvadratmeter;
            Adresse = adresse;
            Rating = rating;
            Husdyr = husdyr;
        }

        public override string ToString()
        {
            return string.Format(
                $"Antal Personer: {AntalPersoner}, Antal Soveværelser: {AntalSoveværelser}, " +
                $"Type: {Type}, Antal Badeværelser: {AntalBadeværelser}, Kvadratmeter {Kvadratmeter}, " +
                $"Adresse: {Adresse}, Rating: {Rating}, Husdyr: {Husdyr}");
        }
    }
}

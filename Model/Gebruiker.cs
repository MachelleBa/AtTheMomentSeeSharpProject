using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtTheMomentSeeSharpSquad.Model
{
    class Gebruiker
    {
        private string voornaam;
        private string achternaam;
        private string rekeningNummer;
        private int pasNummer;

        public Gebruiker(string voornaam, string achternaam)
        {
            this.voornaam = voornaam;
            this.achternaam = achternaam;
        }

        //Om bij het inloggen de lijst met pinpassen op te halen
        public Gebruiker(string voornaam, string achternaam, string rekeningNummer, int pasNummer) {
            this.voornaam = voornaam;
            this.achternaam = achternaam;
            this.rekeningNummer = rekeningNummer;
            this.pasNummer = pasNummer;        
        }

        public string getVoornaam()
        {
            return this.voornaam;
        }

        public string getAchternaam()
        {
            return this.achternaam;
        }

        public string getRekeningNummer()
        {
            return this.rekeningNummer;
        }

        public int getPasNummer()
        {
            return this.pasNummer;
        }
    }
}

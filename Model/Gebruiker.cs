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

        public Gebruiker(string voornaam, string achternaam)
        {
            this.voornaam = voornaam;
            this.achternaam = achternaam;
        }

        private string getVoornaam()
        {
            return this.voornaam;
        }

        private string getAchternaam()
        {
            return this.achternaam;
        }
    }
}

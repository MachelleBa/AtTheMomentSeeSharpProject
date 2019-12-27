using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtTheMomentSeeSharpSquad.Model
{
    class Gebruiker
    {
        private String voornaam;
        private String achternaam;

        public Gebruiker(String voornaam, String achternaam)
        {
            this.voornaam = voornaam;
            this.achternaam = achternaam;
        }

        private String getVoornaam()
        {
            return this.voornaam;
        }

        private String getAchternaam()
        {
            return this.achternaam;
        }
    }
}

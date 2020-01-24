using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtTheMomentSeeSharpSquad.Model
{
    class Pinpas
    {
        private int pasNummer;
        private int pinCode;
        private DateTime vervalDatum;

        public Pinpas(int pasNummer, int pinCode, DateTime vervalDatum)
        {
            this.pasNummer = pasNummer;
            this.pinCode = pinCode;
            this.vervalDatum = vervalDatum;
        }

        //voor het weergeven van de pinpassenlijst
        public Pinpas(int pasNummer, DateTime vervalDatum) {

            this.pasNummer = pasNummer;
            this.vervalDatum = vervalDatum;
        
        }
        public int getPasNummer()
        {
            return this.pasNummer;
        }

        public int getPinCode()
        {
            return this.pinCode;
        }

        public DateTime getVervalDatum()
        {
            return this.vervalDatum;
        }
    }
}

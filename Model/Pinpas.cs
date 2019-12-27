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

        private int getPasNummer()
        {
            return this.pasNummer;
        }

        private int getPinCode()
        {
            return this.pinCode;
        }

        private DateTime getVervalDatum()
        {
            return this.vervalDatum;
        }
    }
}

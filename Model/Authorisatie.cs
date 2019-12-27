using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtTheMomentSeeSharpSquad.Model
{
    class Authorisatie
    {
        private BetaalRekening gebruikerBetaalrekening;
        private Gebruiker gebruiker;
        private Pinpas pinpas;
        private BetaalRekening betaalRekening;
        private Authorisatie authorisatie;

        public Authorisatie login()
        {
            return this.authorisatie;
        }

        public Authorisatie logout()
        {
            return this.authorisatie;
        }

        private void simulatePinPasInname()
        {

        }

        private void simulatePinPasUitgifte()
        {

        }

        public Gebruiker getGebruiker()
        {
            return this.gebruiker;
        }

        public Pinpas getPinpas()
        {
            return this.pinpas;
        }

        public BetaalRekening getBetaalRekening()
        {
            return this.betaalRekening;
        }
    }
}

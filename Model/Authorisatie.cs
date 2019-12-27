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


        public Authorisatie()
        {
            //maak hier in methodes om de gegevens op te halen
            //this.gebruikerBetaalrekening = haalBetaalRekeningOp();
            //this.gebruiker = haalGebruikerOp();
            //this.pinpas = haalPinpasOp();
        }

        public Authorisatie login()
        {
            Authorisatie auth = new Authorisatie();
            return auth;
        }

        public Authorisatie logout()
        {
            //return this.authorisatie;
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
            return this.gebruikerBetaalrekening;
        }
    }
}

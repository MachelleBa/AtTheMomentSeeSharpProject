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
            //login();
        }

     //   public Authorisatie login()
     //   {
            //maak hier in methodes om de gegevens op te halen

            //auth = null als input niet overeenkomt met een account in de database, anders, ga door met de code die hier onder staat

            //this.gebruikerBetaalrekening = haalBetaalRekeningOp();
            //this.gebruiker = haalGebruikerOp();
            //this.pinpas = haalPinpasOp();
          //  return auth;
      //  }

        //public Authorisatie logout()
        //{
        //    //return this.authorisatie;
        //}

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

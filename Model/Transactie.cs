using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtTheMomentSeeSharpSquad.Model
{
    class Transactie
    {
        private long transactieID;
    //    private Gebruiker transactionDoneBy;
        private BetaalRekening sourceBetaalRekening;
        private BetaalRekening destinationBetaalRekening;


        //public Transactie(long transactieID, Gebruiker gebruiker, BetaalRekening sourceRekening, BetaalRekening destinationRekening) {
        //    this.transactieID = transactieID;
        //    this.gebruiker = gebruiker;
        //    this.sourceBetaalRekening = sourceRekening;
        //    this.destinationBetaalRekening = destinationRekening;
        //}

        //voor het ophalen van info van een transactie uit de db
        //public Transactie(long transactieID) {
        //    this.transactieID = transactieID;
        //    this.gebruiker = haalGebruikerO(transactieID); //<methode die uiteindelijk data ophaald vanuit de db, deze is nog niet gemaakt
        //    this.sourceBetaalRekening = haalSourceRekeningOp(transactieID);
        //    this.destinationBetaalRekening = haalDestinationRekeningOp(transactieID);
        //}

        private void printTransactieBon() { 
        
        }

        public long getTransactieID() {

            return this.transactieID;
        }

        //public Gebruiker getGebruiker() {

        //    return this.gebruiker;
        //}

        public BetaalRekening getSourceBetaalRekening() {

            return this.sourceBetaalRekening;
        }

        public BetaalRekening getDestinationBetaalRekening()
        {

            return this.destinationBetaalRekening;
        }
    }
}

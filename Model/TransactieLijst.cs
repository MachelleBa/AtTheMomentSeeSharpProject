using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtTheMomentSeeSharpSquad.Model
{
    class TransactieLijst
    {
        private List<Transactie> transacties;
        //   private Gebruiker gebruiker;

        //public TransactieLijst(Gebruiker gebruiker, Transactie transactie) {

        //    this.transacties.Add(transactie);
        //    this.gebruiker = gebruiker;

        //}

        public List<Transactie> getTransactieLijst() {

            return this.transacties;
        }

        //public Gebruiker getGebruiker() {

        //    return this.gebruiker;
        //}

        //public Transactie getSpecificTransactie(long transactieID)
        //{
        //    //where transactieID == transactieID in lijst, haal diens values op en return deze als een Transactie object

        //    return Transactie transactie;

        //}
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtTheMomentSeeSharpSquad.Model
{
    class BetaalRekening
    {
        private string rekeningNummer;
        // private List<Pinpas> pinpassenLijst; // = new List<Pinpas>();
        // private List<Transactie> transactieLijst; // = new List<Transactie>();
        // private Saldo saldo;
        // private Gebruiker gebruiker;

        //public BetaalRekening(String rekeningNummer, List<Pinpas> pinpassenLijst, List<Transactie> transactieLijst, Saldo saldo, Gebruiker gebruiker)
        //{

        //    this.rekeningNummer = rekeningNummer;
        //    this.pinpassenLijst = pinpassenLijst;
        //    this.transactieLijst = transactieLijst;
        //    this.saldo = saldo;
        //    this.gebruiker = gebruiker;

        //}


        public string getRekeningNummer() {

            return this.rekeningNummer;
        }

        //gebruik cntrl+kc om een block code te commenten. Gebruik cntr+ku om te uncommenten!

        //public List<Pinpas> getPinpassenLijst()
        //{

        //    return this.pinpassenLijst;
        //}

        //public List<Transactie> getTransactieLijst()
        //{

        //    return this.TransactieLijst;
        //}

        //public Saldo getSaldo() {

        //    return this.saldo;
        
        //}

        //public Gebruiker gebruiker() {

        //    return this.gebruiker;
        //}
    }
}

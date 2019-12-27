using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtTheMomentSeeSharpSquad.Model
{
    public class Saldo
    {
        private double balans;

        public double getBalans() {

            return this.balans;
        
        }

        public void updateSaldo(double verschil, bool optellen ) {

            if (optellen) { //als optellen true is, doe dan dit

                this.balans = this.balans + verschil;
            }
            else
            {
                this.balans = this.balans - verschil;
            }
        }
    }
}

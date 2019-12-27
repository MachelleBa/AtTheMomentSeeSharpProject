using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtTheMomentSeeSharpSquad.Model
{
    class AutomaatSassy
    {
        private string automaatID;
        private string automaatLokatie;
        private Authorisatie authrorisedGebruiker;

        private Authorisatie login() {

            Authorisatie authorisatie = new Authorisatie();
            authorisatie.login();
            this.authrorisedGebruiker = authorisatie;

            return authorisatie;
        }
    }
}

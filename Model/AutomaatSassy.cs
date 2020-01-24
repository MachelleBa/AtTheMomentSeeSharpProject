using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtTheMomentSeeSharpSquad.Model
{
    public sealed class AutomaatSassy //Singleton, maak hier geen objecten van!
    {
        private static string automaatID;
        private static string automaatLokatie;
        private static Authorisatie authorisedGebruiker;

        private static AutomaatSassy sassy = new AutomaatSassy("2", "Hoofddorp"); //dummydata, haal dit uit DB

        private AutomaatSassy(string input_automaatID, string input_automaatLokatie) {

            automaatID = input_automaatID;
            automaatLokatie = input_automaatLokatie;
            authorisedGebruiker = login();
        }

        private Authorisatie login() {

            Authorisatie authorisatie = null;

            while (authorisatie == null) {
                try
                {

                    authorisatie = new Authorisatie();


                    if (authorisatie == null)
                    {

                        throw new Exception("That username/password combination does not exist. Please try again!");

                    }
                    else
                    {

                        authorisedGebruiker = authorisatie;
                    }

                }
                catch (Exception e) {

                    Console.WriteLine(e.Message);
                }
                }

            return authorisatie;
        }

        //private Authorisatie logout()
        //{
        //    authorisedGebruiker = null;

            
        //}
    }
}

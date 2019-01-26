using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0731847
{
    class Program
    {
        static void Main(string[] args)

        { }
        class Countryside
        {
            Village Alst;
            Village Maeland;
            Village Schenig;
            public void Initializemap()
            {
                Alst = new Village();
                Alst.VillageName = "Alst";
                Maeland = new Village();
                Maeland.VillageName = "Maeland";
                Maeland.isAstrildeHere = true;
                Schenig = new Village();
                Schenig.VillageName = " Schenig";

                Alst.NextVillage = Maeland;
                Maeland.NextVillage = Schenig;
                Schenig.NextVillage = Alst;
            }
            public void FindAstrilde()
            {
                Village CurrentVillage = this.Maeland;
                if (CurrentVillage.isAstrildeHere)
                {
                    Console.WriteLine("Hugi found Astrilde!!! Celeberations");
                }
                Village NextVillage;
                NextVillage = CurrentVillage.NextVillage;
            }
        

            class Village
            {
                public Village PreviousVillage;
                public Village NextVillage;
                public String VillageName;
                public bool isAstrildeHere = false;



                public Village() { }
            }
        }
    }
}

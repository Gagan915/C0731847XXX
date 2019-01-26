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
                Maeland = new Village();
                Maeland.isAstrildeHere = true;
                 Schenig = new Village();

                Alst.NextVillage = Maeland;
                Maeland.NextVillage = Schenig;
                Schenig.NextVillage = Alst;
            }
            public void WalkAround()
            {
                Village initiallVillage = this.Maeland;
            }

            class Village
            {
                public Village PreviousVillage;
                public Village NextVillage;
                public String Villagename;
                public bool isAstrildeHere = false;



                public Village() { }
            }
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _060121_oefeningenCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welkom in het woordenboek De Grote Van Mauro\n");

            Woordenboek woordenboek = new Woordenboek();
            bool stop = true;
            do
            {
                string inputWoord;
                string inputValue;
                Console.WriteLine("Voeg een woord toe(typ stop om te stoppen,typ count om te tellen):");
                inputWoord = Console.ReadLine();
                Console.WriteLine("Geef de betekenis van het woord in:");
                inputValue = Console.ReadLine();

                if (inputWoord.ToUpper() != "STOP")
                {
                    woordenboek.VoegToe(inputWoord, inputValue);
                    Console.WriteLine();
                }

                else
                {
                    Console.WriteLine(woordenboek);
                    Console.WriteLine("Aantal woorden: "+woordenboek.GrooteWoordenboek());
                    stop = false;
                }
            } while (stop);
            stop = true;
        }
    }
    public class Woordenboek
    {
        private Dictionary<string, string> woordenBoek;

        public void VoegToe(string woord, string betekenis)
        {
            woordenBoek.Add(woord, betekenis);
        }

        public int GrooteWoordenboek()
        {
            return woordenBoek.Count;
        }

        public Woordenboek()
        {
            woordenBoek = new Dictionary<string, string>();
        }

        public override string ToString()
        {
            string output = "";
            foreach (var item in woordenBoek)
            {
                output = output + "Woord: " + item.Key + "\t" + "Betekenis: " + item.Value + "\n\n";
            }
            return "\nDe Grote Van Mauro woordenboek\n" + output;
        }
    }
}


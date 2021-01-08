using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmCollectie.Models
{
    public class DVD
    {
        public string Titel { get; set; }
        public int Jaartal { get; set; }
        public double Score { get; set; }

        public DVD(string titel, int jaartal, double score)
        {
           Titel = titel;
           Jaartal = jaartal;
           Score = score;
        }
    }
}

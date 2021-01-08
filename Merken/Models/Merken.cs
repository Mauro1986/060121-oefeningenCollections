using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merken.Models
{
    public class Merken1
    {
        List<string> merken = new List<string>() ;

        ArrayList arrayList = new ArrayList();
        private Data data;

        public Merken1(Data data)
        {
            merken = new List<string>();
            ArrayList tempArrayList = new ArrayList(Data.Merken);
            foreach (var item in tempArrayList)
            {
                merken.Add((string)item);

            }
        }

        public void sorteer()
        {
            merken.Sort() ;
        }

        public void keerOm()
        {
            merken.Reverse();
        }

        public override string ToString()
        {
            string listString = "";
            foreach (var item in merken)
            {
                listString += item + " ";
            }
            return listString;
        }
    }
}

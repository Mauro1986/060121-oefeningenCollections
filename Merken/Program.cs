using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Merken.Models;

namespace Merken
{
    public class TestMerken
    {
        public static void Main(string[] args)
        {
            Data data = new Data();
            Merken1 merken = new Merken1(data);
            Console.WriteLine(merken);
            merken.sorteer();
            Console.WriteLine(merken);
            merken.keerOm();
            Console.WriteLine(merken);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Studenten.Models;

namespace Studenten
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            List<Student> listStudenten = new List<Student>();

            Student student1 = new Student() {Naam = "Mauro", Leeftijd = 34 };
            Student student2 = new Student() {Naam = "Jeff", Leeftijd = 44 };
            Student student3 = new Student() {Naam = "Louis", Leeftijd = 24 };
            Student student4 = new Student() {Naam = "Jarno", Leeftijd = 25 };
            Student student5 = new Student() {Naam = "Kenan", Leeftijd = 31 };
            Student student6 = new Student() {Naam = "Jan", Leeftijd = 55 };

            listStudenten.Add(student1);
            listStudenten.Add(student2);
            listStudenten.Add(student3);
            listStudenten.Add(student4);
            listStudenten.Add(student5);
            listStudenten.Add(student6);
            #endregion

            Console.WriteLine();
            ShowInfo(listStudenten);
            Console.WriteLine();
  
            SortByAge perLeeftijd = new SortByAge();
            listStudenten.Sort(perLeeftijd);

            ShowInfo(listStudenten);


        }

        private static void ShowInfo(List<Student> listStudenten)
        {
            foreach (var item in listStudenten)
            {
                Console.WriteLine(item.Naam + " " + item.Leeftijd);
            }
        }
    }
}
/*
Maak daarna een hoofdprogramma waarin je een lijst van 6 studenten aanmaakt. Deze lijst moet
gesorteerd zijn op leeftijd.
Print alle studenten op het scherm.
Zorg er met generics voor dat je aan de lijst enkel Student objecten kan toevoegen, en niets anders.
  */
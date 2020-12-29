using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListeZad2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> godine = new List<int>() { 2009, 2010, 2011, 2012, 2013, 2014 };

            Console.Write("Pre dodavanja elemenata.");
            Console.WriteLine();
            Console.Write("Broj elemenata: " + godine.Count);
            Console.WriteLine();
            Console.Write("Kapacitet: " + godine.Capacity);
            Console.WriteLine();

            Console.WriteLine();

            godine.Add(2015);
            godine.Add(2016);
            godine.Add(2017);

            Console.Write("Posle dodavanja elemenata.");
            Console.WriteLine();
            Console.Write("Broj elemenata: " + godine.Count);
            Console.WriteLine();
            Console.Write("Kapacitet: " + godine.Capacity);
            Console.WriteLine();

            foreach (int god in godine)
                Console.WriteLine(god);
            Console.WriteLine();
            Console.WriteLine("====================================");
            //=============================================================

            godine.Add(2010);//dodajemo element 
            godine.Add(2010);

            godine.Remove(2010);//traži element sa prosleđenom vrednošću za uklanjenje. Vraća true ako je element uklonjen.
            godine.RemoveAt(3);//Uklanja element na prosleđenom indeksu
            godine.RemoveRange(4, 2);//uklanja broj elemenata počevši od prosleđenog indeksa
                                     //uklanja 2 elementa pocevsi od indeksa 2

            Console.Write("Posle dodavanja elemenata.");
            Console.WriteLine();
            Console.Write("Broj elemenata: " + godine.Count);
            Console.WriteLine();
            Console.Write("Kapacitet: " + godine.Capacity);
            Console.WriteLine();

            foreach (int god in godine)
                Console.WriteLine(god);
            Console.WriteLine();
            Console.WriteLine("====================================");
            //=============================================================
            Console.ReadLine();
        }
    }
}

using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérem adja meg a személyazonosító első tíz jelét");
            string Szemelyszam = Console.ReadLine();
            var nem = Szemelyszam[0];
            if (nem == 1 || nem == 3)
            {
                Console.WriteLine("A személy férfi");
            }
            else if (nem == 2 || nem == 4)
            {
                Console.WriteLine("A személy nő");
            }
            else
            {
                Console.WriteLine("A személy azonosítója hibás");
            }
            string szuletesiSorszam = Szemelyszam.Substring(7, 3);
            Console.WriteLine($"A születési sorszám: {szuletesiSorszam}");

            var sz = 19 + Szemelyszam.Substring(2, 2);
            int cd = Convert.ToInt32(sz);
            var ev = DateTime.Now.Year;
            var szuletes = ev - cd;
            Console.WriteLine(szuletes);

            Console.Write("Kérem adjon meg egy másik személyazonosító első tíz számjegyét");
            string szemelyiszam2 = Console.ReadLine();

            var sz2 = 19 +szemelyiszam2.Substring(2, 2);
            int cd2 = Convert.ToInt32(sz2);
            var ev2 = DateTime.Now.Year;
            var szuletes2 = ev2 - cd2;
            if (szuletes > szuletes2)
            {
                Console.WriteLine($"{Szemelyszam} az idősebb");
                var korkulonbseg = cd2 - cd;
                Console.WriteLine($"A korkülönbség {korkulonbseg}");
            }
            int eredmeny = 0;
            int szorzo = 1;
            for (int i = 0;i < 10;i++)
            {
                eredmeny = szorzo * szemelyiszam2[i];
                szorzo++;
            }
            string st = Convert.ToString(eredmeny);
            string szemgs = szemelyiszam2 + st;
            Console.WriteLine($"Ez a 11 számmal {szemgs}");

            
        }
    }
}

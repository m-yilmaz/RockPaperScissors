using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
        // Rock => r,
        // Paper => p,
        // Scissors =>s
        int bilgisayarSkor = 0, oyuncuSkor = 0;
        bas:
            Console.WriteLine("******* Rock | Paper | Scissors  ********");
            Console.WriteLine("        Rock     =>   R");
            Console.WriteLine("        Paper    =>   P");
            Console.WriteLine("        Scissors =>   S");
            Console.WriteLine("*****************************************");
            
            string oyuncuSecim = Console.ReadLine().ToLower();
           
            string bilgisayarSecim = "";
            

            Random rnd = new Random();
            int x = rnd.Next(0,3);

            string[] xx = { "r", "p", "s" };

            bilgisayarSecim = xx[x];

            if (bilgisayarSecim == oyuncuSecim)
            {
                Console.WriteLine("Berabere");
                bilgisayarSecim += 0;
                oyuncuSecim += 0;
                Console.WriteLine($"{bilgisayarSkor} -- {oyuncuSkor}");
                
            }
            else if (bilgisayarSecim == "r")
            {
                if (oyuncuSecim == "p")
                {
                    Console.WriteLine($"Bilgisayar : {bilgisayarSecim}  -----   {oyuncuSecim} : Siz ");
                    oyuncuSkor += 10;
                    Console.WriteLine("Kazanan Oyuncu !!");
                    Console.WriteLine($"{bilgisayarSkor} -- {oyuncuSkor}");
                }
                else if (oyuncuSecim == "s")
                {
                    Console.WriteLine($"Bilgisayar : {bilgisayarSecim}  -----   {oyuncuSecim} : Siz ");
                    bilgisayarSkor += 10;
                    Console.WriteLine("Kazanan Bilgisayar !!");
                    Console.WriteLine($"{bilgisayarSkor} -- {oyuncuSkor}");
                }
            }
            else if (bilgisayarSecim == "p")
            {
                if (oyuncuSecim == "r")
                {
                    Console.WriteLine($"Bilgisayar : {bilgisayarSecim}  -----   {oyuncuSecim} : Siz ");
                    bilgisayarSkor += 10;
                    Console.WriteLine("Kazanan Bilgisayar !!");
                    Console.WriteLine($"{bilgisayarSkor} -- {oyuncuSkor}");
                }
                else if (oyuncuSecim == "s")
                {
                    Console.WriteLine($"Bilgisayar : {bilgisayarSecim}  -----   {oyuncuSecim} : Siz ");
                    oyuncuSkor += 10;
                    Console.WriteLine("Kazanan Oyuncu !!");
                    Console.WriteLine($"{bilgisayarSkor} -- {oyuncuSkor}");
                }
            }
            else if (bilgisayarSecim == "s")
            {
                if (oyuncuSecim == "r")
                {
                    Console.WriteLine($"Bilgisayar : {bilgisayarSecim}  -----   {oyuncuSecim} : Siz ");
                    oyuncuSkor += 10;
                    Console.WriteLine("Kazanan Oyuncu !!");
                    Console.WriteLine($"{bilgisayarSkor} -- {oyuncuSkor}");
                }
                else if (oyuncuSecim == "p")
                {
                    Console.WriteLine($"Bilgisayar : {bilgisayarSecim}  -----   {oyuncuSecim} : Siz ");
                    bilgisayarSkor += 10;
                    Console.WriteLine("Kazanan Bilgisayar !!");
                    Console.WriteLine($"{bilgisayarSkor} -- {oyuncuSkor}");
                }
            }

            Console.Write("Devam etmek istiyor musunuz ? (E/H): ");
            String cevap = Console.ReadLine().ToLower();
            if (cevap != "h")
            {
                Console.Clear();
                goto bas;
            }
            Console.WriteLine($"Bilgisayar Skor: {bilgisayarSkor} -- Oyuncu skor:  {oyuncuSkor}");
            if (bilgisayarSkor > oyuncuSkor)
                Console.WriteLine("Oyunu Bilgisayar Kazandı");
            else if (bilgisayarSkor < oyuncuSkor)
                Console.WriteLine("Oyunu Siz Kazandınız");
            else
                Console.WriteLine("Oyun Berabere");

            Console.ReadKey();
            
        }
    }
}

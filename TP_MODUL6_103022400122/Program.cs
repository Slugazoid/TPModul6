using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_MODUL6_103022400122
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayaMusicTrack laguSaya = new SayaMusicTrack("ini lagu enak banget");

            Console.WriteLine("State Awal");
            laguSaya.PrintTrackDetails();

            Console.WriteLine(" ");
            Console.WriteLine("Memutar lagu 45 kali ");
            laguSaya.IncreasePlayCount(45);
            Console.WriteLine(" ");
            
            Console.WriteLine("State Akhir");
            laguSaya.PrintTrackDetails();
        }
    }
}

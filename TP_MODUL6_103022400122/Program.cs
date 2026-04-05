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
            Console.WriteLine("Menambahkan 10.000.000 views berulang kali hingga melebihi batas Integer...");
            for (int i = 1; i <= 220; i++)
            {
                laguSaya.IncreasePlayCount(10000000);
            }
            Console.WriteLine(" ");
            
            Console.WriteLine("State Akhir");
            laguSaya.PrintTrackDetails();
        }
    }
}

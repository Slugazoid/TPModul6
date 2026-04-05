using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_MODUL6_103022400122
{
    internal class SayaMusicTrack
    {
        private int id;
        private string playCount;
        private string title;

        public SayaMusicTrack(string title)
        {
            this.title = title;
            Random random = new Random();
            this.id = random.Next(10000, 100000);
            this.playCount = "0";
        }
        public void IncreasePlayCount(int count)
        {
            int currentPlayCount = int.Parse(this.playCount);
            currentPlayCount += count;
            this.playCount = currentPlayCount.ToString();
        }
        public void PrintTrackDetails()
        {
            Console.WriteLine("ID Lagu     : " + this.id);
            Console.WriteLine("Judul Lagu  : " + this.title);
            Console.WriteLine("Total Putar : " + this.playCount + " kali");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            Debug.Assert(title != null, "Judul track tidak boleh null");
            Debug.Assert(title.Length <= 100, "Judul track memiliki panjang maksimal 100 karakter");
            this.title = title;
            Random random = new Random();
            this.id = random.Next(10000, 100000);
            this.playCount = "0";
        }
        public void IncreasePlayCount(int count)
        {
            Debug.Assert(count <= 10000000, "Input penambahan play count maksimal 10.000.000");


            try
            {
                int tempPlayCount = int.Parse(this.playCount);
                checked
                {
                    tempPlayCount += count;
                }
                this.playCount = tempPlayCount.ToString();
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Error: Penambahan melebihi batas maksimum integer (Overflow)!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\n[ERROR] Terjadi kesalahan tak terduga: {ex.Message}");
            }
        }
        public void PrintTrackDetails()
        {
            Console.WriteLine("ID Lagu     : " + this.id);
            Console.WriteLine("Judul Lagu  : " + this.title);
            Console.WriteLine("Total Putar : " + this.playCount + " kali");
        }
    }
}

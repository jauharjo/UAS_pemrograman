using System;

namespace FinalProject
{
    class Reguler : Bioskop
    {
        public void Spesifikasi()
        {
            Console.WriteLine(" Fasilitas              : - Minuman");
            Console.WriteLine("                          *Dilarang membawa makanan dan minuman selain dari Bioskop");
        }
        public double JumlahTiket { get; set; }
        public double HargaTiket { get; set; }
        public double UangBayar { get; set; }
        public override double Bayar()
        {
            return JumlahTiket * HargaTiket;
        }
        public override double Kembalian()
        {
            return UangBayar - Bayar();
        }
    }
}

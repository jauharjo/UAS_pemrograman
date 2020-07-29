namespace FinalProject
{
    abstract class Bioskop
    {
        public string Nama { get; set; }
        public abstract double Bayar();
        public abstract double Kembalian();
    }
}

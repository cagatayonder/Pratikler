using System;

namespace struct_
{
    class Program
    {
        static void Main(string[] args)
        {
            Dikdörtgen dikdortgen = new Dikdörtgen();
            dikdortgen.kısaKenar = 3;
            dikdortgen.uzunKenar = 4;
            Console.WriteLine(dikdortgen.AlanHesapla());

            Dikdörtgen_Struct dikdortgen_struct = new Dikdörtgen_Struct(3,4);
            Console.WriteLine(dikdortgen_struct.AlanHesapla());
        }
    }
    class Dikdörtgen
    {
        public int kısaKenar;
        public int uzunKenar;

        public long AlanHesapla()
        {
            return this.kısaKenar*this.uzunKenar;
        }
    }
    struct Dikdörtgen_Struct
    {
        public int kısaKenar;
        public int uzunKenar;

        public Dikdörtgen_Struct(int kısaKenar, int uzunKenar)
        {
            this.kısaKenar = kısaKenar;
            this.uzunKenar = uzunKenar;
        }

        public long AlanHesapla()
        {
            return this.kısaKenar*this.uzunKenar;
        }
    }
}

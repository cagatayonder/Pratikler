using System;

namespace method_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            // Out parametreler
            string sayı = "999";

            int.TryParse(sayı,out int outSayı);

            Console.WriteLine(outSayı);
            Console.WriteLine(sayı);

            Methods instance = new Methods();
            instance.Topla(4,5,out int toplamSonuc);
            Console.WriteLine(toplamSonuc);
        }
    }

    class Methods
    {
        public void Topla(int a, int b, out int toplam)
        {
            toplam = a+b ;
        }
    }
}

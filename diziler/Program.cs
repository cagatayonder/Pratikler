using System;

namespace diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] renkler = new string[5] ;

            string[] hayvanlar = {"Kedi","Köpek","Kuş","Balık"};

            // Console.WriteLine(hayvanlar.Length);

            renkler[0] = "Mavi";

            Console.WriteLine("Bir sayı giriniz.");
            int diziUzunlugu = int.Parse(Console.ReadLine());
            int[] sayıDizisi = new int[diziUzunlugu];

            for( int i= 0; i<diziUzunlugu ; i++){
                Console.WriteLine("Lutfen {0}. sayısı giriniz", i+1);
                sayıDizisi[i] = int.Parse(Console.ReadLine());
            }
            int toplam = 0;
            foreach (var sayı in sayıDizisi)
            {
                toplam += sayı;
            }
            Console.WriteLine("Ortalama" +(toplam/diziUzunlugu));
        }
    }
}

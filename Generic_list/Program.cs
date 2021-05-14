using System;
using System.Collections.Generic;

namespace Generic_list
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sayıListesi = new List<int>();

            sayıListesi.Add(23);
            sayıListesi.Add(5);
            sayıListesi.Add(11);
            sayıListesi.Add(87);
            sayıListesi.Add(59);

            List<string> renkListesi = new List<string>();

            renkListesi.Add("sarı");
            renkListesi.Add("kırmızı");
            renkListesi.Add("yeşil");
            renkListesi.Add("mavi");
            // Count
            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayıListesi.Count);
            // Foreach
            foreach (var sayı in sayıListesi)
            {
                Console.WriteLine(sayı);
            }
            foreach (var renk in renkListesi)
            {
                Console.WriteLine(renk);
            }
            // List foreach
            sayıListesi.ForEach(sayı =>Console.WriteLine(sayı));
            renkListesi.ForEach(renk =>Console.WriteLine(renk));

            // Remove item
            sayıListesi.Remove(5);  // 5 elemanı çıkar
            sayıListesi.RemoveAt(2); // 2. elemanı çıkartır

            // Liste içinde arama 

            sayıListesi.Contains(5) ; // BOOL 

            // Eleman ile Index erişme 

            Console.WriteLine(renkListesi.BinarySearch("kırmızı"));

            // Diziyi listeye çevirme

            string[] hayvanlar = {"Kedi","Köpek","Kuş","İnek"};
            List<string> hayvanListesi = new List<string> (hayvanlar) ;

            // clear

            hayvanListesi.Clear();

            // List içerisinde nesne tutmak 
            List<Kullanıcılar> kullanıcıListesi = new List<Kullanıcılar>();

            Kullanıcılar kullanıcı1 = new Kullanıcılar();
            kullanıcı1.Isim = "Çağatay";
            kullanıcı1.Soyisim = "ÖNDER";
            kullanıcı1.Yaş = 26;

            Kullanıcılar kullanıcı2 = new Kullanıcılar();
            kullanıcı2.Isim = "Recep";
            kullanıcı2.Soyisim = "Keçeci";
            kullanıcı2.Yaş = 26;

            kullanıcıListesi.Add(kullanıcı1);
            kullanıcıListesi.Add(kullanıcı2);

            List<Kullanıcılar> yeniListe = new List<Kullanıcılar>();
            yeniListe.Add(new Kullanıcılar(){
                Isim = "Deniz",
                Soyisim = "Arda",
                Yaş = 24

            });

            foreach (Kullanıcılar kullanıcı in kullanıcıListesi)
            {
                Console.WriteLine("Kullanıcı Adı:" +kullanıcı.Isim);
                Console.WriteLine("Kullanıcı Soyadı:" +kullanıcı.Soyisim);
                Console.WriteLine("Kullanıcı YAşı:" +kullanıcı.Yaş);
            }

            yeniListe.Clear();
        }
    }

    public class Kullanıcılar
    {
        private string isim;
        private string soyisim;
        private int yaş;

        public string Isim{ get=>isim; set=>isim = value; }

        public string Soyisim{ get=>soyisim; set=>soyisim = value; }

        public int Yaş{ get=>yaş; set=>yaş = value; }
    }
}

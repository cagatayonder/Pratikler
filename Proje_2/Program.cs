using System;
using System.Collections.Generic;

namespace Proje_2
{
    class Program
    {
        public Dictionary<int,string> takımÜyeleri = new Dictionary<int, string>();
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :) ");
            Console.WriteLine("******************************************* ");
            Console.WriteLine("(1) Board Listelemek ");
            Console.WriteLine("(2) Board'a Kart Eklemek ");
            Console.WriteLine("(3) Board'dan Kart Silmek ");
            Console.WriteLine("(4) Kart Taşımak ");

            int key = Convert.ToInt32(Console.ReadLine());

            switch (key)
            {
                case 1:
                    BoardListeleme(); 
                    break;
                case 2:
                    KartEkleme(); 
                    break;
                case 3:
                    KartSilme();
                    break;
                case 4:
                    KartTaşıma();
                    break;
            }
            List<Kart> toDo = new List<Kart>();
            List<Kart> ınProg = new List<Kart>();
            List<Kart> done = new List<Kart>();
            

        }

        private static void BoardListeleme()
        {
            
        }

        public void TakımÜyeleri()
       {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            Dictionary<int,string> takımÜyeleri = dictionary;
            takımÜyeleri.Add(123,"Çağatay ÖNDER");
            takımÜyeleri.Add(124,"Büşra Kandemir");
            takımÜyeleri.Add(125,"Sılay ÖNDER");
            takımÜyeleri.Add(126,"Recep Can Keçeci");
       }

        private static void KartTaşıma()
        {
            // 
        }

        private static void KartSilme()
        {
            // 
        }

        private static void KartEkleme()
        {
            Kart newKart = new Kart();
            Console.Write("Başlık Giriniz                                  : ");
            newKart.başlık = Console.ReadLine();

            Console.Write("İçerik Giriniz                                  : ");
            newKart.içerik = Console.ReadLine();

            Console.Write("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5)  : ");
            int consolaYazılan = Convert.ToInt32(Console.ReadLine());
            if( consolaYazılan == 1)
            {
                newKart.büyüklük = Kart.Büyüklük.XS;
            }
            if( consolaYazılan == 2)
            {
                newKart.büyüklük = Kart.Büyüklük.S;
            }
            if( consolaYazılan == 3)
            {
                newKart.büyüklük = Kart.Büyüklük.M;
            }
            if( consolaYazılan == 4)
            {
                newKart.büyüklük = Kart.Büyüklük.L;
            }
            if( consolaYazılan == 5)
            {
                newKart.büyüklük = Kart.Büyüklük.XL;
            }

            Console.Write("Kişi Seçiniz                                    : ");
            newKart.atanankisi = Console.ReadLine();

            Console.WriteLine("Hangi Line'a eklemek istiyorsunuz? -> ToDo (1), Progress (2), Done (3) :");
            Main(null);
        }
    }
    
    class Kart
    {
        public string başlık,içerik,atanankisi;

        public enum Büyüklük
        {
            XS = 1,
            S = 2,
            M = 3,
            L = 4,
            XL =5 
        }

        public Büyüklük büyüklük;
    }
}   


using System;
using System.Collections.Generic;

namespace Proje_2
{
    class Program
    {  
        public static List<Kartlar> toDo = new List<Kartlar>();
        public static List<Kartlar> progress = new List<Kartlar>();
        public static List<Kartlar> done = new List<Kartlar>();
        public static Dictionary<int, TakımÜyeleri> takımÜyeleri = new Dictionary<int, TakımÜyeleri>(){
            { 101, new TakımÜyeleri {id=101, isim_soyisim="Recep"}},
            { 102, new TakımÜyeleri {id=102, isim_soyisim="Çağatay "}},
            { 103, new TakımÜyeleri {id=103, isim_soyisim="Büşra"}},
            { 104, new TakımÜyeleri {id=104, isim_soyisim="Sılay"}},
            { 105, new TakımÜyeleri {id=105, isim_soyisim="Ahmet"}} };
        static void Main(string[] args)
        {
            int key = 0;
            while (key < 1 || key > 4)
            {
                Console.Clear();
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)");
                Console.WriteLine("*******************************************");
                Console.WriteLine("(1) Board Listelemek");
                Console.WriteLine("(2) Board'a Kart Eklemek");
                Console.WriteLine("(3) Board'dan Kart Silmek");
                Console.WriteLine("(4) Kart Taşımak");
                
                key = Convert.ToInt32(Console.ReadLine());

                switch (key)
                {
                    case 1:
                        BoardListeleme();
                        break;

                    case 2:
                        BoardaKartEkleme();
                        break;

                    case 3:
                        BoarddanKartSilme();
                        break;

                    case 4:
                        KartTasima();
                        break;
                    
                }
            }
            
        }

        private static void KartTasima()
        {
            Console.Clear();
            Console.WriteLine("Öncelikle taşımak istediğiniz kartı seçmeniz gerekiyor.");
            Console.WriteLine("Lütfen kart başlığını yazınız: ");
            string tempbaslik = Console.ReadLine();
            for (int i = 0; i < toDo.Count; i++)
            {
                if (toDo[i].baslik == tempbaslik)
                {
                    Console.WriteLine("Bulunan Kart Bilgileri:");
                    Console.WriteLine("*************************");
                    Console.WriteLine("Başlık : " + toDo[i].baslik);
                    Console.WriteLine("İçerik : " + toDo[i].icerik);
                    Console.WriteLine("Atanan Kişi : " + toDo[i].atanankisi.isim_soyisim);
                    Console.WriteLine("Büyüklük: " + toDo[i].kartBuyuklugu);
                    Console.WriteLine("Line: ToDo");
                    Console.WriteLine();
                    Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz.");
                    Console.WriteLine("(1) ToDo");
                    Console.WriteLine("(2) Progess");
                    Console.WriteLine("(3) Done");
                    int selec = Convert.ToInt32(Console.ReadLine());
                    if(selec == 2)
                    {
                        progress.Add(toDo[i]);
                        toDo.RemoveAt(i);
                        Console.WriteLine("Başarıyla taşındı.");
                        Console.ReadKey();
                        BoardListeleme();
                    }
                    if(selec == 3)
                    {
                        done.Add(toDo[i]);
                        toDo.RemoveAt(i);
                        Console.WriteLine("Başarıyla taşındı.");
                        Console.ReadKey();
                        BoardListeleme();
                    }
                    else
                    {
                        KartTasima();
                    }
                }
            }
            for (int i = 0; i < progress.Count; i++)
            {
                if (progress[i].baslik == tempbaslik)
                {
                    Console.WriteLine("Bulunan Kart Bilgileri:");
                    Console.WriteLine("*************************");
                    Console.WriteLine("Başlık : " + progress[i].baslik);
                    Console.WriteLine("İçerik : " + progress[i].icerik);
                    Console.WriteLine("Atanan Kişi : " + progress[i].atanankisi.isim_soyisim);
                    Console.WriteLine("Büyüklük: " + progress[i].kartBuyuklugu);
                    Console.WriteLine("Line: Progress");
                    Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz.");
                    Console.WriteLine("(1) ToDo");
                    Console.WriteLine("(2) Progess");
                    Console.WriteLine("(3) Done");
                    Console.WriteLine();
                    int selec = Convert.ToInt32(Console.ReadLine());
                    if(selec == 1)
                    {
                        toDo.Add(progress[i]);
                        progress.RemoveAt(i);
                        Console.WriteLine("Başarıyla taşındı.");
                        Console.ReadKey();
                        BoardListeleme();
                    }
                    if(selec == 3)
                    {
                        done.Add(progress[i]);
                        progress.RemoveAt(i);
                        Console.WriteLine("Başarıyla taşındı.");
                        Console.ReadKey();
                        BoardListeleme();
                    }
                    else
                    {
                        KartTasima();
                    }

                }
            }
            for (int i = 0; i < done.Count; i++)
            {
                if (done[i].baslik == tempbaslik)
                {
                    Console.WriteLine("Bulunan Kart Bilgileri:");
                    Console.WriteLine("*************************");
                    Console.WriteLine("Başlık : " + done[i].baslik);
                    Console.WriteLine("İçerik : " + done[i].icerik);
                    Console.WriteLine("Atanan Kişi : " + done[i].atanankisi.isim_soyisim);
                    Console.WriteLine("Büyüklük: " + done[i].kartBuyuklugu);
                    Console.WriteLine("Line: Done");
                    Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz.");
                    Console.WriteLine("(1) ToDo");
                    Console.WriteLine("(2) Progess");
                    Console.WriteLine("(3) Done");
                    Console.WriteLine();
                    int selec = Convert.ToInt32(Console.ReadLine());
                    if(selec == 1)
                    {
                        toDo.Add(done[i]);
                        done.RemoveAt(i);
                        Console.WriteLine("Başarıyla taşındı.");
                        Console.ReadKey();
                        BoardListeleme();
                    }
                    if(selec == 2)
                    {
                        progress.Add(done[i]);
                        done.RemoveAt(i);
                        Console.WriteLine("Başarıyla taşındı.");
                        Console.ReadKey();
                        BoardListeleme();
                    }
                    else
                    {
                        KartTasima();
                    }

                }
            }
        }

        private static void BoarddanKartSilme()
        {
            Console.Clear();
            Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
            Console.WriteLine("Lütfen kart başlığını yazınız: ");
            string tempbaslik = Console.ReadLine();
            for (int i = 0; i < toDo.Count; i++)
            {
                if (toDo[i].baslik == tempbaslik)
                {
                    toDo.RemoveAt(i);
                    Console.WriteLine("Silme işlemi başarıyla tamamlandı.");
                    Console.ReadKey();
                    Main(null);
                }
                else
                {
                    Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                    Console.WriteLine("Ana Menüye Dönmek için : (1)");
                    Console.WriteLine("Yeniden Denemek için :(2)");
                    int selec = Convert.ToInt32(Console.ReadLine());
                    if(selec == 1)
                    {
                        
                        Main(null);
                    }
                    else
                    {
                        
                        BoarddanKartSilme();
                    }
                }
            }
            for (int i = 0; i < progress.Count; i++)
            {
                if (progress[i].baslik == tempbaslik)
                {
                    progress.RemoveAt(i);
                    Console.WriteLine("Silme işlemi başarıyla tamamlandı.");
                    Console.ReadKey();
                    Main(null);
                }
                else
                {
                    Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                    Console.WriteLine("Ana Menüye Dönmek için : (1)");
                    Console.WriteLine("Yeniden Denemek için :(2)");
                    int selec = Convert.ToInt32(Console.ReadLine());
                    if(selec == 1)
                    {
                        
                        Main(null);
                    }
                    else
                    {
                        
                        BoarddanKartSilme();
                    }
                }
            }
            for (int i = 0; i < done.Count; i++)
            {
                if (done[i].baslik == tempbaslik)
                {
                    done.RemoveAt(i);
                    Console.WriteLine("Silme işlemi başarıyla tamamlandı.");
                    Console.ReadKey();
                    Main(null);
                }
                else
                {
                    Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                    Console.WriteLine("Ana Menüye Dönmek için : (1)");
                    Console.WriteLine("Yeniden Denemek için :(2)");
                    int selec = Convert.ToInt32(Console.ReadLine());
                    if(selec == 1)
                    {
                        
                        Main(null);
                    }
                    else
                    {
                        
                        BoarddanKartSilme();
                    }
                }
            }
        }
        public static void BoardaKartEkleme()
        {
            Console.Clear();
            Kartlar yeniKart = new Kartlar();

            Console.WriteLine("Başlık giriniz                                      : ");
            yeniKart.baslik = Console.ReadLine();
            
            Console.WriteLine("İçerik giriniz                                      : ");
            yeniKart.icerik = Console.ReadLine();

            Console.WriteLine("Büyüklük seçiniz -> XS(1), S(2), M(3), L(4), XL(5)  : ");
            int temp = Convert.ToInt32(Console.ReadLine());
            if (temp == 1)
            {
                yeniKart.kartBuyuklugu = KartBuyuklugu.XS;
            }
            if (temp == 2)
            {
                yeniKart.kartBuyuklugu = KartBuyuklugu.S;
            }
            if (temp == 3)
            {
                yeniKart.kartBuyuklugu = KartBuyuklugu.M;
            }
            if (temp == 4)
            {
                yeniKart.kartBuyuklugu = KartBuyuklugu.L;
            }
            if (temp == 5)
            {
                yeniKart.kartBuyuklugu = KartBuyuklugu.XL;
            }

            Console.WriteLine("Kişi seçiniz                                        : ");
            int keytemp = Convert.ToInt32(Console.ReadLine());
            if (takımÜyeleri.ContainsKey(keytemp))
            {
                yeniKart.atanankisi = takımÜyeleri[keytemp];
                Console.WriteLine("Hangi Line'a eklemek istiyorsunuz? -> ToDo (1), Progress (2), Done (3) :");
                int line = Convert.ToInt32(Console.ReadLine());
                if (line == 1)
                {
                    toDo.Add(yeniKart);
                }
                if (line == 2)
                {
                    progress.Add(yeniKart);
                }
                if (line == 3)
                {
                    done.Add(yeniKart);
                }
                Console.WriteLine("Başarıyla eklendi.");
                Console.ReadKey();
                Main(null);
            }
            else
            {
                Console.WriteLine("Hatalı giriş yaptınız.");
                Console.ReadKey();
                BoardaKartEkleme();
            }           
        }

        public static void BoardListeleme()
        {
            Console.Clear();
            Console.WriteLine("Done List");
            Console.WriteLine("******************");
            for (int i = 0; i < done.Count; i++)
            {
                Console.WriteLine("Başlık : " + done[i].baslik);
                Console.WriteLine("İçerik : " + done[i].icerik);
                Console.WriteLine("Atanan Kişi : " + done[i].atanankisi.isim_soyisim);
                Console.WriteLine("Büyüklük: " + done[i].kartBuyuklugu);
                Console.WriteLine("-----------------");
            }
            
            Console.WriteLine();
            Console.WriteLine("Progress List");
            Console.WriteLine("******************");
            for (int i = 0; i < progress.Count; i++)
            {
                Console.WriteLine("Başlık : " + progress[i].baslik);
                Console.WriteLine("İçerik : " + progress[i].icerik);
                Console.WriteLine("Atanan Kişi : " + progress[i].atanankisi.isim_soyisim);
                Console.WriteLine("Büyüklük: " + progress[i].kartBuyuklugu);
                Console.WriteLine("-----------------");
            }
            
            Console.WriteLine();
            Console.WriteLine("ToDo List");
            Console.WriteLine("******************");
            for (int i = 0; i < toDo.Count; i++)
            {
                Console.WriteLine("Başlık : " + toDo[i].baslik);
                Console.WriteLine("İçerik : " + toDo[i].icerik);
                Console.WriteLine("Atanan Kişi : " + toDo[i].atanankisi.isim_soyisim);
                Console.WriteLine("Büyüklük: " + toDo[i].kartBuyuklugu);
                Console.WriteLine("-----------------");
            }
            Console.WriteLine();
            Console.ReadKey();
            Main(null);
        }
        public static void KartOlustur()
        {
            Kartlar kart_1 = new Kartlar();
            kart_1.baslik = "Proje taslağını çıkar.";
            kart_1.icerik = "Taslak";
            kart_1.kartBuyuklugu = KartBuyuklugu.M;
            kart_1.progress = 2;
            done.Add(kart_1);

            Kartlar kart_2 = new Kartlar();
            kart_2.baslik = "Projeyi tamamla.";
            kart_2.icerik = "Proje";
            kart_2.kartBuyuklugu = KartBuyuklugu.XL;
            kart_2.progress = 1;
            progress.Add(kart_2);

            Kartlar kart_3 = new Kartlar();
            kart_3.baslik = "Projeyi gite yükle";
            kart_3.icerik = "Proje";
            kart_3.kartBuyuklugu = KartBuyuklugu.XS;
            kart_3.progress = 2;
            toDo.Add(kart_3);

        }
    }
    public enum KartBuyuklugu
    {
        XS, S, M, L, XL
    }
    public class TakımÜyeleri
    {
        public int id { get; set; }
        public string isim_soyisim;
        
    }
    
    public class Kartlar
    {

        public TakımÜyeleri atanankisi;
        public string baslik, icerik;
        public int progress;
        public KartBuyuklugu kartBuyuklugu;
    }
}
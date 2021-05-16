using System;
using System.Collections.Generic;

namespace Proje_1
{
    class Program
    {
        static List<Telefon> telefonRehberi = new List<Telefon>();
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :) ");
            Console.WriteLine("******************************************* ");
            Console.WriteLine("(1) Yeni Numara Kaydetmek ");
            Console.WriteLine("(2) Varolan Numarayı Silmek ");
            Console.WriteLine("(3) Varolan Numarayı Güncelleme ");
            Console.WriteLine("(4) Rehberi Listelemek ");
            Console.WriteLine("(5) Rehberde Arama Yapmak ");

            int numara = Convert.ToInt32(Console.ReadLine());

            switch (numara)
            {
                case 1:
                    yeni_numara(); 
                    break;
                case 2:
                    numara_sil(); 
                    break;
                case 3:
                    numara_güncelle();
                    break;
                case 4:
                    rehberi_göster();
                    break;
                case 5:
                    arama_yap();
                    break;
                
            }
            
            
        }
        static void yeni_numara()
        {
            Console.Clear();

        Telefon kişi = new Telefon();
        
        Console.Write("Lütfen isim giriniz             : ");
        kişi.isim = Console.ReadLine();

        Console.Write("Lütfen soyisim giriniz          : ");
        kişi.soyisim = Console.ReadLine();

        Console.Write("Lütfen telefon numarası giriniz : ");
        kişi.telefon = Console.ReadLine();

        telefonRehberi.Add(kişi);

        Console.WriteLine("Kişi başarıyla kaydedildi.");

        Console.ReadKey(); 

        Main(null);

        }
         static void numara_sil()
        {
            Console.Clear();
            Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz: ");
            var consolaYazılan = Console.ReadLine();
            bool bulundu = false;
            for (int i = telefonRehberi.Count - 1; i > 0; i--)
            {               
                if(telefonRehberi[i].isim == consolaYazılan || telefonRehberi[i].soyisim == consolaYazılan)
                {
                    bulundu = true;
                    Console.WriteLine(consolaYazılan + " isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)");
                    string confirm = Console.ReadLine();
                    if(confirm == "y")
                    {
                        telefonRehberi.RemoveAt(i); // eşleşme bulduğumuz i'inci eleman listeden siliniyor
                        Console.WriteLine("Kişi kaydı başarıyla silindi.");
                        Console.ReadKey();
                        Main(null);
                    }
                    else{ numara_sil(); }
                }
            }
            if(!bulundu) // eğer eşleşme bulunamazsa bir önceki if içindeki kodlar çalışmadığı 
            {            // için bulundu bool değişkeni false olarak devam edip buradaki kodu çalıştırıyor
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("Silmeyi sonlandırmak için : (1)");
                Console.WriteLine("Yeniden denemek için :      (2)");
                int selection = Convert.ToInt32(Console.ReadLine());
                if (selection == 1)
                { 
                    Main(null);
                }
                else
                { 
                    numara_sil(); 
                }
            }            
        }
        static void numara_güncelle()
        {
            Console.Clear();
            Console.WriteLine("Lütfen telefon numarasını değiştirmek istediğiniz kişinin adını ya da soyadını giriniz: ");
            var consolaYazılan = Console.ReadLine();
            bool bulundu = false;
            for (int i = 0; i < telefonRehberi.Count; i++)
            {               
                if(telefonRehberi[i].isim == consolaYazılan || telefonRehberi[i].soyisim == consolaYazılan)
                {
                    bulundu = true;
                    Console.WriteLine("Lütfen yeni telefon numarası giriniz.");
                    string new_number = Console.ReadLine();
                    telefonRehberi[i].telefon = new_number;
                    Console.WriteLine("Telefon numarası başarıyla değiştirildi.");
                    Console.ReadKey();
                    Main(null);
                }
            }
            if(!bulundu)
            {
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("Güncellemeyi sonlandırmak için : (1)");
                Console.WriteLine("Yeniden denemek için :           (2)");
                int selection = Convert.ToInt32(Console.ReadLine());
                if (selection == 1)
                { 
                    Main(null);
                }
                else
                { 
                    numara_güncelle(); 
                }
            }         
        }
        static void rehberi_göster()
        {
            {
                Console.Clear();
                Console.WriteLine("A-Z listele: (1)");
                Console.WriteLine("Z-A listele: (2)");
                int selection = Convert.ToInt32(Console.ReadLine());
                // rehber listesi isme göre alfabetik olarak sıralanıyor
                telefonRehberi.Sort((x, y) => x.isim.CompareTo(y.isim));
                
                if (selection == 2)
                { 
                    telefonRehberi.Reverse(); // 2 seçilirse liste tersine çevriliyor
                }
                Console.WriteLine("Telefon Rehberi.\n");
                
                foreach (Telefon item in telefonRehberi)
                {
                    Console.WriteLine("İsim: " + item.isim);
                    Console.WriteLine("Soyisim: " + item.soyisim);
                    Console.WriteLine("Telefon Numarası: " + item.telefon);
                    Console.WriteLine("-");
                }
                Console.ReadKey();
                Main(null);
            }
        }
        static void arama_yap()
        {
         {
            Console.Clear();
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
            Console.WriteLine("***************************************");
            Console.WriteLine("İsim veya soyisime göre arama yapmak için : (1)");
            Console.WriteLine("Telefon numarasına göre arama yapmak için : (2)");
            int selection = Convert.ToInt32(Console.ReadLine());
            if (selection == 1)
            {
                Console.WriteLine("İsim ya da soyisim giriniz");
                string isim_soyisim = Console.ReadLine();
                for (int i = 0; i < telefonRehberi.Count; i++)
                {
                    if (telefonRehberi[i].isim == isim_soyisim || telefonRehberi[i].soyisim == isim_soyisim)
                    {
                        Console.WriteLine("İsim: " + telefonRehberi[i].isim);
                        Console.WriteLine("Soyisim: " + telefonRehberi[i].soyisim);
                        Console.WriteLine("Telefon numarası: " + telefonRehberi[i].telefon);                       
                    }
                }
                Console.ReadKey();
                Main(null);

            }
            if (selection == 2)
            {
                Console.WriteLine("Telefon numarası giriniz.");
                string tel_no = Console.ReadLine();
                for (int i = 0; i < telefonRehberi.Count; i++)
                {
                    if (telefonRehberi[i].telefon == tel_no)
                    {
                        Console.WriteLine("İsim: " + telefonRehberi[i].isim);
                        Console.WriteLine("Soyisim: " + telefonRehberi[i].soyisim);
                        Console.WriteLine("Telefon numarası: " + telefonRehberi[i].telefon);
                    }
                }
                Console.ReadKey();
                Main(null);
            }
            else
            {
                arama_yap();
            }
            
        }
        }

    }
    class Telefon
    {
        public string isim, soyisim ,telefon ;
    }
}
using System;

namespace static_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çalışan Sayısı:{0}",Calısan.CalısanSayısı);

            Calısan calısan1 = new Calısan("Çağatay","Onder","Backend");
            Console.WriteLine("Çalışan Sayısı:{0}",Calısan.CalısanSayısı);

            Calısan calısan2 = new Calısan("REcep","Kecei","Game-DEv");
            Console.WriteLine("Çalışan Sayısı:{0}",Calısan.CalısanSayısı);
        }
    }

    class Calısan 
    {
        private static int calısanSayısı;

        public static int CalısanSayısı { get => calısanSayısı; set => calısanSayısı = value; }

        private string Isim;
        private string Soyisim;
        private string Departman;

        static Calısan(){
            calısanSayısı = 0;
        }

        public Calısan(string ısim, string soyisim, string departman){
            this.Isim = ısim;
            this.Soyisim = soyisim;
            this.Departman = departman;
            calısanSayısı ++;
        }
    }
}

using System;

namespace encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
           Ogrenci ogrenci = new Ogrenci();
           ogrenci.Isim ="Çağatay" ;
           ogrenci.Soyisim = "ÖNDER";
           ogrenci.Numara =202992;
           ogrenci.Sınıf = 4;

           ogrenci.SınıfAtlat();
           ogrenci.OgrenciBilgileriniGetir();

           Ogrenci ogrenci2 = new Ogrenci("Sılay","ONDER",2101236,6);

           ogrenci2.SınıfAtlat();
           ogrenci2.OgrenciBilgileriniGetir();
           
        }
    }

    class Ogrenci
    {
        private string isim;
        private string soyisim;
        private int numara ;
        private int sınıf;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Numara { get => numara; set => numara = value; }
        public int Sınıf 
        { get => sınıf; 
          set 
          {
            if(value>=1 && value<=8)
            sınıf = value;
          } 
        }

        public Ogrenci(string ısim, string soyisim, int numara, int sınıf)
        {
            Isim = ısim;
            Soyisim = soyisim;
            Numara = numara;
            Sınıf = sınıf;
        }
        public Ogrenci(){}

        public void OgrenciBilgileriniGetir(){
            Console.WriteLine("Öğrenci Adı:{0}" ,this.Isim);
            Console.WriteLine("Öğrenci Soyadı:{0}" ,this.Soyisim);
            Console.WriteLine("Öğrenci Numarası:{0}" ,this.Numara);
            Console.WriteLine("Öğrenci Sınıfı:{0}" ,this.Sınıf);
        }

        public void SınıfAtlat(){
            this.Sınıf = this.Sınıf+1;
        }
        public void SınıfDüşür(){
            this.Sınıf = this.Sınıf-1;
        }
    }
}

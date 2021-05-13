using System;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 5;

            Console.WriteLine(a+b);
            int sonuc = Topla(a,b);

            Console.WriteLine(sonuc);

            Methods ornek = new Methods();
            ornek.EkranaYazdır(Convert.ToString(sonuc));

            int sonuc2 = ornek.ArttırVeTopla(ref a,ref b);
            ornek.EkranaYazdır("sonuc:" +Convert.ToString(sonuc2));
        }
        static int Topla(int deger1,int deger2){
            return (deger1 + deger2);
        }
    }
    class Methods
    {
        public void EkranaYazdır(string veri){
            Console.WriteLine(veri);
        }
        public int ArttırVeTopla(ref int deger1, ref int deger2){
            deger1 += 1;
            deger2 += 1;

            return deger1 + deger2 ;
        }
    }
}

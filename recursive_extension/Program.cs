using System;

namespace recursive_extension
{
    class Program
    {
        static void Main(string[] args)
        {
            // recursive
            Islemler instance = new();
            Console.WriteLine(instance.Expo(3,4));

            // extension
            string veri = "Çağatay ÖNDER";
            bool sonuc =veri.CheckSpaces();
            Console.WriteLine(veri.CheckSpaces());
            if(sonuc){
                Console.WriteLine(veri.RemoveWhiteSpaces());
            }

        }
    }

    public class Islemler
    {
        public int Expo (int sayı,int üs)
        {
            if(üs<2)
                return sayı;
            return Expo(sayı,(üs-1))*sayı;
            
        }
    }
    public static class extension
    {
        public static bool CheckSpaces(this string param)
        {
            return param.Contains(" ");
        }
        public static string RemoveWhiteSpaces(this string param)
        {
            string[] dizi =param.Split();
            return string.Join("",dizi);
        }
    }
}

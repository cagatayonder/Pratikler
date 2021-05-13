using System;

namespace while_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sayı Giriniz");
            int sayı = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;

            while(sayac <= sayı){

                toplam += sayac;
                sayac++;

            }
            Console.WriteLine(toplam/sayı);

            Console.Write("******** Foreach *****************");
            Console.WriteLine();
            string[] arabalar = {"BMW","Ford","Fiat"};

            foreach ( var araba in arabalar){
                Console.WriteLine(araba);
            }
        }
    }
}

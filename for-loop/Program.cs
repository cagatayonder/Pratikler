using System;

namespace for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sayı Giriniz");
            int sayac =  int.Parse(Console.ReadLine());
            for ( int i=0; i<= sayac; i++){
                if(i%2 ==1){
                    Console.WriteLine(i);
                }
            }
        }
    }
}

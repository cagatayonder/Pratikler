using System;

namespace if_elseif
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;
            // if-else-elseif
            if(time>= 6 && time<18){
                Console.WriteLine("Günaydın");
            }

            else if( time <= 18)
            {
                Console.WriteLine("İyi Günler");
            }
            else{
                Console.WriteLine("İyi Geceler");
            }
            // Ternary 

            // string sonuc = time <= 18 ? "İyi Günler" : "İyi Geceler";

            string sonuc = time>= 6 && time<18 ? "Günaydın" : time <= 18 ? "İyi Günler" : "İyi Geceler";
            Console.WriteLine(sonuc);
        }
    }
}

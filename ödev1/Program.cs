using System;

namespace ödev1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Soru-1
            #region Soru 1
            Console.WriteLine("Bir Sayı Giriniz :)");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[n];

            Console.WriteLine("Sayıları Giriniz :)");
            for (int i = 0; i < n; i++)
            {
                
                numbers[i] = Convert.ToInt32(Console.ReadLine());

            }

            Console.WriteLine("Çift Sayılar :)");
            foreach (var number in numbers)
            {
                if(number%2 == 0){
                    
                    Console.WriteLine(number);
                }
            }
            #endregion 

            // Soru 2
            #region Soru2
            Console.WriteLine("İki Sayı Giriniz :)");
            int x = Convert.ToInt32(Console.ReadLine());
            int[] numberss = new int[n];
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sayıları Giriniz :)");
            for (int i = 0; i < x; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Mod 0 :");
             foreach (var number in numbers)
            {
                if(number%m == 0){
                    Console.WriteLine(number);
                }
            }
            #endregion 

            // Soru 3
            #region Soru3
            
            Console.WriteLine("Bir Sayı Giriniz :)");
            int y = Convert.ToInt32(Console.ReadLine());
            string[] kelimeler = new string[n];
            Console.WriteLine("Kelimeleri Giriniz");
            for (int i = 0; i < y; i++)
            {
                kelimeler[i] = (Console.ReadLine());
            }

            Array.Reverse(kelimeler);
            Console.WriteLine("Tersten Sıralanmış Kelimeler");
            foreach(var kelime in kelimeler)
                {
                    Console.WriteLine(kelime.ToString());
                }
                
            #endregion

            // Soru 4
            #region Soru4
           
            Console.WriteLine("Bir Cümle Yazınız :)");
            string cümle = Console.ReadLine();
            string cümle2 = cümle.Trim();

             int words = cümle2.Split(" ").Length;
             int letter = cümle2.Replace(" ","").Length;
             

             Console.WriteLine("Kelime sayısı:" +words);
             Console.WriteLine("Harf sayısı:" +letter);
            
                 
            #endregion
            

        }

    }
}

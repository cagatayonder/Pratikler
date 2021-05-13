using System;

namespace hata_yonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            try{Console.WriteLine("Write a Number");
            int deger = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Girmiş olduğunuz sayı " +deger);
            }
            catch(Exception ex){
                Console.WriteLine("Hata" +ex.Message.ToString());
            }
            finally{
                Console.WriteLine("İşlem Tamamlandı!");
            }

        }
            
    }
}

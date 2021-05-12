using System;

namespace operatörler
{
    class Program
    {
        static void Main(string[] args)
        {
            int x =3;
            int y =5;

            y += 2;
            x *= 3;
            Console.WriteLine(x);
            Console.WriteLine(y);

            bool isSuccess = true;
            bool isCompleted = true;

            if(isSuccess&&isCompleted)
            Console.WriteLine("Helal");
            

        }
    }
}

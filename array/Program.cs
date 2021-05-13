using System;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sort
            int[] sayıDizisi = {76,45,78,94,14,3,5,9};

            Console.WriteLine("***Sırasız Dizi***");
            foreach (var sayi in sayıDizisi)
                Console.WriteLine(sayi);
            
            Console.WriteLine("***Sıralı Dizi***");
            Array.Sort(sayıDizisi);
            foreach (var sayi in sayıDizisi)
                Console.WriteLine(sayi);

            // Clear
            Console.WriteLine("***Array Clear***");

            Array.Clear(sayıDizisi,2,2);
            foreach (var sayi in sayıDizisi)
                Console.WriteLine(sayi);

            
            // Reverse
            Console.WriteLine("***Array Reverse***");
            Array.Reverse(sayıDizisi);
            foreach (var sayi in sayıDizisi)
                Console.WriteLine(sayi);

            // IndexOf
            Console.WriteLine("***Array IndexOf***");
            Console.WriteLine(Array.IndexOf(sayıDizisi,45));

            // Resize
            Console.WriteLine("***Array Resize***");
            Array.Resize<int>(ref sayıDizisi,9);
            sayıDizisi[8] = 99;

            foreach (var sayi in sayıDizisi)
                Console.WriteLine(sayi);

        }
    }
}

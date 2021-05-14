using System;
using System.Collections;
using System.Collections.Generic;

namespace array_list
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList liste = new ArrayList();
            liste.Add("Çağatay");
            liste.Add(2);
            liste.Add(true);
            liste.Add('A');

            // Verilere erişmek

            Console.WriteLine(liste[1]);

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            // AddRange
            string[] renkler = {"sarı","kırmızı","yeşil"};
            List<int> sayılar = new List<int>(){1,8,3,9,92,5};
            liste.AddRange(renkler);
            liste.AddRange(sayılar);

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            // Sort

            liste.Sort();

            // Binary Search

            liste.BinarySearch(9);

            

        }
    }
}

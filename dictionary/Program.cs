using System;
using System.Collections.Generic;

namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
        Dictionary<int,string> kullanıcılar = new Dictionary<int, string>();
        kullanıcılar.Add(10,"Ayşe Yılmaz");
        kullanıcılar.Add(12,"Ahmet Yılmaz");
        kullanıcılar.Add(18,"Deniz Arda");
        kullanıcılar.Add(20,"Özcan Coşar");

        Console.WriteLine(kullanıcılar[12]);
        foreach (var item in kullanıcılar)
        {
            Console.WriteLine(item);
        }

        // Count
        Console.WriteLine(kullanıcılar.Count);

        // Contains
        Console.WriteLine(kullanıcılar.ContainsKey(12));
        Console.WriteLine(kullanıcılar.ContainsValue("Deniz Arda"));

        }
    }
}

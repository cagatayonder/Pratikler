using System;
public class Hayvanlar: Canlilar{
    public void SuruHalindeHareket(){
        Console.WriteLine("Hayvanlar sürüler halinde hareket eder."); 
    }
}

public class Kus:Hayvanlar{
    public void Ucmak(){
        Console.WriteLine("Kuşlar uçar");
    }
}

public class Ordek:Hayvanlar{
    public void Yuzmek(){
        Console.WriteLine("Ördekler yüzer");
    }
}
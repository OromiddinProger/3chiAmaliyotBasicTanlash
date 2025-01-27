using System;

class Preogram
{
    static void Main1()
    {
        Console.WriteLine("Soznikiriting :");
        string Soz = Console.ReadLine();

        if (IsPalindrom(Soz))
        {
            Console.WriteLine("Plaindrom");
        }
        else
        {
            Console.WriteLine("Palindrom emas");
        }


        static bool IsPalindrom(string Soz)
        {
            Soz = Soz.ToLower();

            char[] SozArr = Soz.ToCharArray();
            Array.Reverse(SozArr);
            string TeskariSoz = new string(SozArr);

            return Soz == TeskariSoz;
        }
    }
    static void Main2()
    {
        Console.WriteLine("Temperaturani kiriting");
        double Temp = Convert.ToDouble(Console.ReadLine());

        double fara = 0.0;
        double kel = 0.0;

        switch (Temp) 
        {
            case 1:
                fara = (Temp * 9 / 5) + 32;
                kel = Temp + 273.15;
                break;
        }
        Console.WriteLine($"farangheit = {fara} , kelvin = {kel} , celsius = {Temp}");
    }
    static void Main()
    {
        Console.Write("Sonlarni kiriting (vergul bilan ajrating): ");
        string Kiritilganson = Console.ReadLine();

 
        string[] inputArray = Kiritilganson.Split(',');
        int[] sonlar = Array.ConvertAll(inputArray, s => int.Parse(s.Trim())); 

        Array.Sort(sonlar);
        Console.Write("Tartiblangan qator: ");
        foreach (var son in sonlar)
        {
            Console.Write(son + " ");
        }
        Console.WriteLine(); 

        Array.Reverse(sonlar);
        Console.Write("Teskari tartib: ");
        foreach (var son in sonlar)
        {
            Console.Write(son + " ");
        }
    }
}

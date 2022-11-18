using System;

public class Kodiki_dz3
{
    public static void Main(string[] args)
    {
        string[] myClass = new string[5];
        myClass[0] = "Вася";
        myClass[1] = "Даниил";
        myClass[2] = "Света";
        myClass[3] = "Лена";
        myClass[4] = "Аня";
        int ocenka = 5;
        for (int i = 0; i < myClass.Lenght; i++)
        {
            if (myClass[i] == "Даниил")
            {
                Console.WriteLine("Молодец, |" + myClass[i] + "Получаешь" + ocenka);
            }
        }
    }
}

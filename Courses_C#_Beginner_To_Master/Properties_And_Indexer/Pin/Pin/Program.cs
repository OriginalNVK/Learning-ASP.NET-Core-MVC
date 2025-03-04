using System;

class Program
{
    static void Main()
    {
        DebitCard card = new DebitCard();
        card.pin = "1001";
        Console.WriteLine(card.pin);
    }
}
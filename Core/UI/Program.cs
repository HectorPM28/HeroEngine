using HeroEngine.Core.Models;
using HeroEngine.Core.UI;
using System;

public class Program
{
    public static void Main()
    {
        Warrior warrior = new Warrior("pepe", 12, 4, "Pendejo");
        Mage mago = new Mage("Juan", 2, 3, 12);
        Rogue rogue = new Rogue("Yo", 12, 12);
        Console.WriteLine(warrior.ToString());
        Console.WriteLine(mago.ToString());
        Console.WriteLine(rogue.ToString());
        ThunderSmash test = new ThunderSmash();
        Console.WriteLine(test.ToString());
    }
}
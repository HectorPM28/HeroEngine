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
        ThunderSmash Thunder = new ThunderSmash();
        SecondWind wind = new SecondWind();
        Wartaunt taunt = new Wartaunt();
        Console.WriteLine(Thunder.ToString());
        warrior.AddAbility(Thunder);
        warrior.UseAbility(warrior.Abilities[Thunder.Name]);
        warrior.AddAbility(wind);
        warrior.AddAbility(taunt);
        warrior.AddAbility(Thunder);
        warrior.ShowAbilities();
    }
}
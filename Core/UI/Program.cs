using HeroEngine.Core.Models;
using HeroEngine.Core.Models.Interfaces;
using HeroEngine.Core.UI;
using System;
using System.Reflection.Metadata.Ecma335;

public class Program
{
    public static void Main()
    {
        const int minMenuVal = 0, maxMenuVal = 5;
        int menuSelected = 0;

        List<AHero> party = new List<AHero>(3);
        Usables.CreateParty(party);
        Console.Clear();
        do
        {
            UIConfig.ShowMenu();
            menuSelected = Usables.IntParse(minMenuVal, maxMenuVal);

            switch (menuSelected)
            {
                case 1:
                    Usables.ShowPartyHeroes(party);
                    Console.WriteLine(UIConfig.Menu.PressToContinue);
                    Console.ReadKey();
                    break;
                case 2:
                    Usables.AssignAbilityToHero(party);                                     
                    break;
                case 3:
                    Usables.StartCombat(party);
                    Usables.RestartPartyAfterBattle(party);
                    Console.ReadKey();
                    break;
            }
            Console.Clear();
        } while (menuSelected != 4);
    }    
}
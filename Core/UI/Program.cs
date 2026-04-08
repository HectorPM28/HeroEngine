using HeroEngine.Core.Models;
using HeroEngine.Core.UI;
using System;

public class Program
{
    public static void Main()
    {
        int menuSelected = 0, minMenuVal = 0, maxMenuVal = 5;

        List<AHero> party = new List<AHero>(3);
        CreateParty(party);
        Console.Clear();
        do
        {
            UIConfig.ShowMenu();
            menuSelected = IntParse(minMenuVal, maxMenuVal);

            switch (menuSelected)
            {
                case 1:
                    ShowParty(party);
                    Console.WriteLine("Press anything to continue..");
                    Console.ReadKey();
                    break;
                case 2:
                    AssignAbilityToHero(party);                                     
                    break;
                case 3:
                    break;
            }
            Console.Clear();
        } while (menuSelected != 4);
    }
    public static void AssignAbilityToHero(List<AHero> party)
    {
        int heroSelectedInt, abilitySelectedInt, minAbilityVal = 0, maxAbilityVal = 5;
        ShowParty(party);
        Console.WriteLine("Who will be granted an ability");

        heroSelectedInt = IntParse(0, party.Count + 1);
        UIConfig.ShowAbilities();
        abilitySelectedInt = IntParse(minAbilityVal, maxAbilityVal);
        party[heroSelectedInt - 1].AddAbility(SelectAbility(abilitySelectedInt));
    }
    public static void CreateParty(List<AHero> party)
    {
        string heroName;
        int minHeroVal = 0, maxHeroVal = 4;

        for (int i = 0; i < 3; i++)
        {
            heroName = NameHero();
            UIConfig.ShowHeroes();
            party.Add(SelectHero(IntParse(minHeroVal, maxHeroVal), heroName));
        }
    }
    public static void ShowParty(List<AHero> party)
    {
        for(int i = 0; i < party.Count; i++)
        {
            if (party[i] is Mage isMage)
            {
                Console.WriteLine($"{i + 1}. {isMage.ToString()}");
                isMage.ShowAbilities();
            }
            else
            {
                Console.WriteLine($"{i + 1}. {party[i].ToString()}");
            }
        }
    }
    public static int IntParse(int minVal, int maxVal)
    {
        bool correctOpt = false;
        string num = "";
        do
        {            
            num = Console.ReadLine();
            if (int.TryParse(num, out int choosed))
            {
                if (choosed < maxVal && choosed > minVal)
                {
                    return choosed;
                }
                else
                {
                    Console.WriteLine("Choose between the options");
                }
            }
            else
            {
                Console.WriteLine(UIConfig.InputError.IntError);
            }
        } while(!correctOpt);
        return 1;
    }
    public static AAbility SelectAbility(int opt)
    {
        switch (opt)
        {
            case 1:
                ThunderSmash thunderSmash = new ThunderSmash();
                return thunderSmash;
            case 2:
                SecondWind secondWind = new SecondWind();
                return secondWind;
            case 3:
                IronFortress ironFortress = new IronFortress();
                return ironFortress;
            case 4:
                Wartaunt warTaunt = new Wartaunt();
                return warTaunt;
        }
        ThunderSmash test = new ThunderSmash();
        return test;
    }
    public static AHero SelectHero(int opt, string name)
    {
        string warTaunt;

        switch (opt)
        {
            case 1:
                Console.WriteLine("Give a war scream to your warrior");
                warTaunt = Console.ReadLine();
                Warrior warrior = new Warrior(name,Warrior.WarriorBaseHp, 1, 45, warTaunt);
                return warrior;
            case 2:
                Mage mage = new Mage(name,Mage.BaseMageHp, 1, 100, 1);
                return mage;
            case 3:
                Rogue rogue = new Rogue(name,Rogue.RogueBaseHp, 1, 5);
                return rogue;
        }
        Warrior test = new Warrior(name,Warrior.WarriorBaseHp, 1, 45, "ScreamLess");
        return test;
    }
    public static string NameHero()
    {
        string name;
        Console.WriteLine("Give a name to the hero");
        name = Console.ReadLine();
        return name;
    }
    public static void ShowPartyHeroes(List<AHero> party)
    {
        foreach (AHero hero in party)
        {
            Console.WriteLine(hero.ToString());
        }
    }
}
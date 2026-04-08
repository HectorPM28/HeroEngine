using HeroEngine.Core.Models;
using HeroEngine.Core.UI;
using System;

public class Program
{
    public static void Main()
    {
        string opt = "", heroName, menuOp = "", abilityOpt = "", heroSelected = "", abilitySelected = "";
        int minHeroVal = 0, maxHeroVal = 4, menuSelected = 0, minMenuVal = 0, maxMenuVal = 5, heroSelectedInt, abilitySelectedInt, minAbilityVal = 0, maxAbilityVal = 5;

        List<AHero> party = new List<AHero>(3);
        
        for (int i = 0; i < 3; i++)
        {            
            heroName = NameHero();
            UIConfig.ShowHeroes();
            party.Add(SelectHero(IntParse(opt, minHeroVal, maxHeroVal), heroName));
        }
        Console.Clear();
        Console.WriteLine(party.Count);
        do
        {
            Console.WriteLine("What do you wanna do?");
            Console.WriteLine("1. See party");
            Console.WriteLine("2. Assign abilities");
            Console.WriteLine("3. Fight enemies");
            Console.WriteLine("4. Finish adventure");
            menuSelected = IntParse(menuOp, minMenuVal, maxMenuVal);

            switch (menuSelected)
            {
                case 1:
                    ShowParty(party);
                    Console.WriteLine("Press anything to continue..");
                    Console.ReadKey();
                    break;
                case 2:
                    ShowParty(party);
                    Console.WriteLine("Who will be granted an ability");

                    heroSelectedInt = IntParse(heroSelected, 0, party.Count + 1);
                    if (party[heroSelectedInt - 1] is Mage mage)
                    {
                        UIConfig.ShowAbilities();
                        abilitySelectedInt = IntParse(abilitySelected, minAbilityVal, maxAbilityVal);
                        mage.AddAbility(SelectAbility(abilitySelectedInt));
                    }
                    else
                    {
                        Console.WriteLine("Only Mages can get abilities");
                        Thread.Sleep(1500);
                    }                                        
                    break;
                case 3:
                    break;
            }
            Console.Clear();
        } while (menuSelected != 4);
    }
    public static void ShowParty(List<AHero> party)
    {
        foreach (AHero hero in party)
        {
            if (hero is Mage isMage)
            {
                Console.WriteLine(isMage.ToString());
                isMage.ShowAbilities();
            }
            else
            {
                Console.WriteLine(hero.ToString());
            }
        }
    }
    public static int IntParse(string opt, int minVal, int maxVal)
    {
        bool correctOpt = false;
        do
        {            
            opt = Console.ReadLine();
            if (int.TryParse(opt, out int choosed))
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
                Warrior warrior = new Warrior(name, 1, 45, warTaunt);
                return warrior;
            case 2:
                Mage mage = new Mage(name, 1, 100, 1);
                return mage;
            case 3:
                Rogue rogue = new Rogue(name, 1, 5);
                return rogue;
        }
        Warrior test = new Warrior(name, 1, 45, "ScreamLess");
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
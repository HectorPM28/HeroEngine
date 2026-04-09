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
        CreateParty(party);
        Console.Clear();
        do
        {
            UIConfig.ShowMenu();
            menuSelected = IntParse(minMenuVal, maxMenuVal);

            switch (menuSelected)
            {
                case 1:
                    ShowPartyHeroes(party);
                    Console.WriteLine("Press anything to continue..");
                    Console.ReadKey();
                    break;
                case 2:
                    AssignAbilityToHero(party);                                     
                    break;
                case 3:
                    StartCombat(party);
                    Console.ReadKey();
                    break;
            }
            Console.Clear();
        } while (menuSelected != 4);
    }
    public static void StartCombat(List<AHero> party)
    {
        List<AEnemy> enemies = new List<AEnemy>(3);
        CreateEnemyTeam(enemies);
        Console.WriteLine("Enemies found!");
        ShowPartyToSelect(enemies);
        Console.ReadKey();

        do
        {            
            CombatRound(party, enemies, 1);
        } while (!CheckPartyState(party) || !CheckPartyState(enemies));         
    }
    public static bool CheckPartyState<T>(List<T> party) where T : AEntity
    {
        foreach (T entity in party) if (entity.Hp > 0) return false;
        return true;
    }
    public static void CombatRound(List<AHero> party, List<AEnemy> enemies, int num)
    {
        const int minEnemyVal = -1;
        int enemyChoosen;

        ShowPartyHeroes(party);
        ShowPartyToSelect(enemies);
        
        Console.WriteLine($"{party[num].Name} is attacking. Choose an enemy to attack");
        enemyChoosen = IntParse(minEnemyVal, enemies.Count);
        enemies[enemyChoosen].GetAttacked(party[num].Attack(RandomNumsHelper.GetRandomDamage()));
        party[RandomNumsHelper.GetRandomHero(party)].GetAttacked(enemies[num].Attack(RandomNumsHelper.GetRandomDamage()));
    }
    public static void CreateEnemyTeam(List<AEnemy> enemies)
    {
        for (int i = 0; i < enemies.Capacity; i++)
        {
            enemies.Add(GetRandomEnemy());
        }
    }
    public static AEnemy GetRandomEnemy()
    {
        Random rnd = new Random();
        const int minEnemyVal = 0, maxEnemyVal = 4;
        int enemyCreated = rnd.Next(minEnemyVal, maxEnemyVal);

        switch (enemyCreated)
        {
            case 1:
                return new Minion(Minion.MinionHp);
            case 2:
                return new Elites(Elites.EliteHp);
            case 3: 
                return new Boss(Boss.BossesHp);
            default: Boss defaultEnemy = new Boss(Boss.BossesHp);
                return defaultEnemy;
        }
    }
    public static void AssignAbilityToHero(List<AHero> party)
    {
        const int minAbilityVal = 0, maxAbilityVal = 5;
        int heroSelectedInt, abilitySelectedInt;

        ShowPartyToSelect(party);
        Console.WriteLine("Who will be granted an ability");

        heroSelectedInt = IntParse(0, party.Count + 1);
        UIConfig.ShowAbilities();
        abilitySelectedInt = IntParse(minAbilityVal, maxAbilityVal);
        party[heroSelectedInt - 1].AddAbility(SelectAbility(abilitySelectedInt));
    }
    public static void CreateParty(List<AHero> party)
    {
        const int minHeroVal = 0, maxHeroVal = 4;

        for (int i = 0; i < party.Capacity; i++)
        {
            UIConfig.ShowHeroes();
            party.Add(SelectHero(IntParse(minHeroVal, maxHeroVal)));
        }
    }
    public static void ShowPartyToSelect<T>(List<T> party)
    {
        for (int i = 0; i < party.Count; i++)
        {      
            Console.WriteLine($"{i + 1}. {party[i].ToString()}");
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
                return new ThunderSmash();
            case 2:
                return new SecondWind();
            case 3:
                return new IronFortress();
            case 4:
                return new Wartaunt();
            default:
                return new ThunderSmash();
        }        
    }
    public static AHero SelectHero(int opt)
    {
        string warTaunt;

        switch (opt)
        {
            case 1:
                Console.WriteLine("Give a war scream to your warrior");
                warTaunt = Console.ReadLine();
                return new Warrior(NameHero(), Warrior.WarriorBaseHp, 1, 45, warTaunt); ;
            case 2:
                return new Mage(NameHero(), Mage.BaseMageHp, 1, 100, 1);
            case 3:
                return new Rogue(NameHero(), Rogue.RogueBaseHp, 1, 5);
            default:
                return new Warrior(NameHero(), Warrior.WarriorBaseHp, 1, 45, "ScreamLess");
        }        
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
        for (int i = 0; i < party.Count; i++)
        {
            if (party[i] is IAbilityUser isUser)
            {
                Console.WriteLine($"{i + 1}. {isUser.ToString()}");
                isUser.ShowAbilities();
            }
            else
            {
                Console.WriteLine($"{i + 1}. {party[i].ToString()}");
            }
        }
    }
}
using System;
public class Character
{
    protected string name;
    protected int health;
    protected int attack;
    protected int defense;

    //Properties

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Health
    {
        get { return health; }
        set { health = value; }
    }

    public int Attack
    {
        get { return attack; }
        set { this.attack = value; }
    }

    public int Defense
    {
        get { return defense; }
        set
        {
            this.defense = value;
        }
    }

    public Character(string name, int health, int attact, int defense)
    {
        this.Name = name;
        this.Health = health;
        this.Attack = attact;
        this.Defense = defense;
    }

    // Method
    public virtual void Atrack(Character target)
    {
        if(attack > 0)
        {
            target.health -= attack;
            System.Console.WriteLine(this.name + " attacks " + target.name + " for " + this.attack + " damage!");
        }
        else
        {
            System.Console.WriteLine($"{this.name}'s attack has no effect on {target.name}.");
        }
    }
    public virtual void Defend()
    {
        System.Console.WriteLine($"{this.name} has defends and gains {this.defense} defense.");
    }
}

public class Warrior : Character
{
    public void Charge(Character target)
    {
        base.Atrack(target);
    }

    public override void Defend()
    {
        this.defense += 5;
        base.Defend();
    }
    public Warrior(string name, int health, int attack, int defense):base(name, health, attack, defense) { }
}    

public class Mage: Character
{
    public void CastSpell(Character target)
    {
        base.Atrack(target);
    }

    public override sealed void Defend()
    {
        base.Defend();
    }

    public Mage(string name, int health, int attack, int defense): base(name, health, attack, defense) { }
}

public class Dragon : Character
{
    public void BreatheFire(Character target)
    {
        Console.WriteLine($"{this.name} breathes fire on {target.Name} for {this.Attack} damage");
        target.Health -= this.Attack;
    }

    public override void Atrack(Character target)
    {
        base.Atrack(target);
        base.Atrack(target);
    }

    public Dragon(string name, int health, int attack, int defense):base(name, health, attack, defense) { }
}

public class Game
{
    static void Main()
    {
        Warrior Arthur = new Warrior("Arthur", 20, 5, 5);
        Mage Merlin = new Mage("Merlin", 20, 5, 5);  
        Dragon Smagur = new Dragon("Smagur", 100, 5, 5);
        bool check = false;
        while(true)
        {
            if(!check)
            {
                Arthur.Charge(Merlin);
                check = true;
            }
            else
            {
                 Merlin.CastSpell(Arthur);
                check = false;
            }
            if(Arthur.Health == 0)
            {
                Console.WriteLine($"--- Battle between {Arthur.Name} and {Merlin.Name} ---");
                Console.WriteLine($"{Merlin.Name} won!");
                break;
            }    
            else if(Merlin.Health == 0) {
                Console.WriteLine($"--- Battle between {Arthur.Name} and {Merlin.Name} ---");
                Console.WriteLine($"{Arthur.Name} won!");
                break;
            }
        }    
    }
}
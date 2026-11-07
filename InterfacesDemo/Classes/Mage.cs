namespace InterfacesDemo.Interfaces;

public class Mage :  ICombactant, IHealer
{
    public string? Name {get; set;}
    public int Health {get; set;}
    public int AttackPower {get; set;}

    public void Attack()
    {
        Console.WriteLine($"{Name} cast a fireball for {AttackPower} damage.");
    
    }

    public void Defend()
    {
        Console.WriteLine($"{Name} created a magical barrier.");
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        Console.WriteLine($"{Name} takes {damage} damage.");
    }

    public void Heal(int hp)
    {
        Health += hp;
        Console.WriteLine($"{Name} recovered health.");
    }
}

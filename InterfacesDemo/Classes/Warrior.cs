namespace InterfacesDemo.Interfaces;

public class Warrior :  ICombactant
{
    public string? Name { get; set; }
    public int Health { get; set; }
    public int AttackPower { get; set;}

    public void Attack()
    {
        Console.WriteLine($"{Name} attacks with a sword for {AttackPower} damage!");
    }

    public void Defend()
    {
        Console.WriteLine($"{Name} raises a shield to defend.");
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        Console.WriteLine($"{Name} takes {damage} damage. Current health: {Health}");
    }   
}
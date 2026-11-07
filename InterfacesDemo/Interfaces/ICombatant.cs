using InterfaceDemo.Interfaces;

namespace InterfacesDemo.Interfaces;

public interface ICombactant : ICharacter
{
    //string? Name { get; set; }
    //int Health { get; set; }
    int AttackPower { get; set; }

    void Attack();
    void Defend();
    //void TakeDamage(int damage);
}
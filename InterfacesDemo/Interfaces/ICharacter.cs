namespace InterfaceDemo.Interfaces;

public interface ICharacter
{
    string? Name {get; set;}
    int Health {get; set;}

    void TakeDamage (int damage);
}
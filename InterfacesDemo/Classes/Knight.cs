namespace InterfacesDemo.Interfaces;

public class Knight: IAttack, IDefend
{
    void IAttack.Attack()
    {
        Console.WriteLine("Knight attacks with sword.");
    }

    void IDefend.Attack()
    {
        Console.WriteLine("Knight raises a shield to defend.");
    }
}
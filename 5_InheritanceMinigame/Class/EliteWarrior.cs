using InheritanceMinigame.Classes;
public class EliteWarrior : Warrior
{
    //base() constractor --> involve the worrier (its parent class)
    public EliteWarrior(string name) : base($"Elite Member {name}") 
    { 
        AttackPower *= 2; 
        ShieldBlock *= 2;
    }

    // This would be invalid:
    //Sealed method cannot be inheritance
/* public override void PerformAttack(Character target)
   {
      Console.WriteLine("This warrior attacks in a different way!");
   }
*/
}
namespace InheritanceMinigame.Classes
{
    public class Dragon : Character
    {
        public Dragon(string name) : base(name, 200, 20) { }
        public override void PerformAttack(Character target)
        {
            Console.WriteLine($"{Name} breathes devastating fire across the battlefield!");
            target.TakeDamage(AttackPower);
        }
    }
}
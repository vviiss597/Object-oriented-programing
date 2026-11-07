namespace InheritanceMinigame.Classes
{
    public class Goblin : Character
    {
        public Goblin(string name) : base(name, 60, 10)
        {
            BattleCry = "Kekeke! Kekekekeeee!";
        }

        public override void PerformAttack(Character target)
        {
            Console.WriteLine($"{Name} shouts '{BattleCry}' and slashes with a rusty dagger!");
            target.TakeDamage(AttackPower);
            
            if (Random.Shared.Next(0, 100) < 30)
            {
                Console.WriteLine($"{Name} shouts '{BattleCry}' !");
                Console.WriteLine($"\n'{BattleCry}'!!!\n");
                Console.WriteLine($"and strikes a second time out of nowhere!");
                target.TakeDamage(AttackPower / 2);
            }
        }
    }
}
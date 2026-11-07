namespace InheritanceMinigame.Classes
{ 
    public sealed class Mage : Character
    {
        public int Mana {get; private set;}=50;
        //private set --> can only write it in the class

        public Mage(string name) : base(name, 80, 25) { }

        public override void PerformAttack(Character target)
        {
            if (Mana >= 20)
            {
                Mana -= 20;
                Console.WriteLine($"{Name} casts a massive Fireball at {target.Name}! (Mana left: {Mana})");
                target.TakeDamage(AttackPower);
            }
            else
            {
                Console.WriteLine($"{Name} is out of mana! They whack {target.Name} weakly with a staff.");
                target.TakeDamage(5); 
            }
        }
    }
}

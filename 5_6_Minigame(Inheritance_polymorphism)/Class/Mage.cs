namespace InheritanceMinigame.Classes
{ 
    public sealed class Mage : Character
    {
        public int Mana {get; private set;}=50;
        //private set --> can only write it in the class

        public Mage(string name) : base(name, 80, 25)
        {
            BattleCry = "Avada Kedavra!";
        }


        public sealed override void PerformAttack(Character target)
        {
            if (Mana >= 20)
            {
                Mana -= 20;
                Console.WriteLine($"{Name} shouts '{BattleCry}' and casts a spell at {target.Name}!");
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

namespace InheritanceMinigame.Classes
{
    //abstract should set up in class and method same time
    //if added abstract the function shoould be decleared
    public abstract class Character
    {
        //string can =not be null
        public string? Name { get; set; } //auto
        public int Health { get; set; }
        public int MaxHealth { get; set; }
        public int AttackPower { get; set; }
        protected string BattleCry { get; set; } = "Charge!";

        public bool IsAlive => Health > 0; //read
        
        //Protected : 
        public Character(string? name, int health, int attackPower)
        {
            //initialization the method
            Name = name;
            MaxHealth = health;
            Health = health;
            AttackPower = attackPower;
        }

        //Virtual : 
        public virtual void TakeDamage(int damage)
        {
            Health -= damage;
            
            if (Health < 0)
                Health = 0;
            
            Console.WriteLine($"{Name} takes {damage} damage! (HP: {Health}/{MaxHealth})");
        }

        //if added abstract the function shoould be decleared
        public abstract void PerformAttack(Character target);
    }
}

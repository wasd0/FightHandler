namespace LearningApp
{
    public class Warrior : Hero
    {
        public Warrior(float health, string name, float damage) : base(health, name, damage) { }

        public override void ActivateUltimate()
        {
            Console.WriteLine("Activated Warrior Ultimate");
        }
    }
}
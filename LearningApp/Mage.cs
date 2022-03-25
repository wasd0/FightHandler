namespace LearningApp
{
    internal class Mage : Hero
    {
        public Mage(float health, string name, float damage) : base(health, name, damage) { }

        public override void ActivateUltimate()
        {
            Console.WriteLine("Activated Mage Ultimate");
        }
    }
}
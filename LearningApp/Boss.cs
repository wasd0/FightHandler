namespace LearningApp
{
    public class Boss : Enemy, IAttacker<Boss, Hero>
    {
        public Boss(float health, string name, float damage) : base(health, name, damage) { }
        public FightHandler<Boss, Hero> Attack(Hero defender)
        {
            return new FightHandler<Boss, Hero>(this, defender);
        }
    }
}
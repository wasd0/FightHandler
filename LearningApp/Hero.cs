namespace LearningApp
{
    public abstract class Hero : Entity, IAttacker<Hero, Boss>
    {
        public Hero(float health, string name, float damage) : base(health, name, damage)
        {
        }
        public abstract void ActivateUltimate();

        public FightHandler<Hero, Boss> Attack(Boss defender) //TODO: Плфиксить атаку
        {
            return new FightHandler<Hero, Boss>(this, defender);
        }
    }
}
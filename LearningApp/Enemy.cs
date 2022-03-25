namespace LearningApp
{
    public abstract class Enemy : Entity
    {
        public State ActiveState { get; set; }
        public Enemy(float health, string name, float damage) : base(health, name, damage) { }
    }
}
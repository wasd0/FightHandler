namespace LearningApp
{
    public interface IAttacker<T, K> where T : Entity
        where K : Entity
    {
        public FightHandler<T, K> Attack(K defender);
    }
}
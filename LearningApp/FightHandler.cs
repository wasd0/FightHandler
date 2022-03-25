namespace LearningApp
{
    public class FightHandler<T, K> where T : Entity
        where K : Entity
    {
        public FightHandler(T attacker, K defender)
        {
            StartFight(attacker, defender);
        }

        private void StartFight(T attacker, K defender)         
        {
            if (!attacker.Equals(defender))
            {
                defender.GetDamage(attacker);
            }
            else throw new Exception("Attacker is defender");
        }   
    }
}
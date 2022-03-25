namespace LearningApp
{ 
    public class StateController<T> where T : Enemy
    {
        public StateSwitcher<T> OnControlState(T enemy )
        {
            if (enemy.Health <= enemy.MaxHealth / 2 && enemy.Health > 0) return new StateSwitcher<T>(State.Rage, enemy);
            else if (enemy.Health <= 0) return new StateSwitcher<T>(State.Death, enemy);
            else return new StateSwitcher<T>(State.Idle, enemy);
        }
    }
}
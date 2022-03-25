namespace LearningApp
{
    public class StateSwitcher<T> where T : Enemy
    {
        private State _state;

        public StateSwitcher(State state, T enemy)
        {
            _state = state;
            SwitchState(state, enemy);
        }
        private void SwitchState(State state, T enemy)
        {
            enemy.ActiveState = _state;
        }
    }
}
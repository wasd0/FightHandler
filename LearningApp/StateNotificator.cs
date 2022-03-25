namespace LearningApp
{
    public class StateNotificator : IObservable<State>
    {
        private readonly List<IObserver<State>> _observers;

        public StateNotificator() => _observers = new List<IObserver<State>>();

        public IDisposable Subscribe(IObserver<State> _observer)
        {
            _observers.Add(_observer);
            return new Unsubscriber<State>(_observers, _observer);
        }
        public void Notify(State state)
        {
            foreach (var _observer in _observers)
            {
                _observer.OnNext(state);
            }
        }
    }
}
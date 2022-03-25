namespace LearningApp
{
    public abstract class Entity : IObserver<State>, IDefender
    {
        public string Name { get; }
        public float MaxHealth { get; }
        public float Damage
        {
            get { if (_damage <= 0) return 0; return _damage; }
        }
        public float Health
        {
            get { if (_health <= 0) return _health = 0; return _health; }
            private set => _health = value;
        }
        private float _health, _damage;

        public Entity(float maxHealth, string name, float damage)
        {
            MaxHealth = maxHealth;
            _health = maxHealth;
            _damage = damage;
            Name = name;
        }

        public void OnCompleted()
        {
            throw new NotImplementedException();
        }
        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }
        public void OnNext(State value)
        {
            switch (value)
            {
                case State.Idle: Console.WriteLine($"{Name} beats the Enemy"); break;
                case State.Rage: Console.WriteLine($"{Name} pissed off the Enemy"); break;
                case State.Death: Console.WriteLine($"{Name} killed the Enemy"); break;
            }
        }
        public void GetDamage(Entity attacker)
        {
            Health -= attacker.Damage;
        }
    }
}
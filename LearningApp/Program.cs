namespace LearningApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            Boss boss1 = new(20f, "Boss1", 3f);
            Warrior john = new(10, "John", 2f);
            Mage steve = new(15, "Steve", 4f);
            Mage kyle = new(15, "Kyle", 4f);

            ViewInfo(boss1, kyle);
            boss1.Attack(kyle);
            ViewInfo(boss1, kyle);

            StateNotificator stateNotificator = new StateNotificator();
            StateController<Boss> stateController = new StateController<Boss>();
            IDisposable johnSubcribe = stateNotificator.Subscribe(john);
            IDisposable steveSubscribe = stateNotificator.Subscribe(steve);

            kyle.Attack(boss1);
            kyle.Attack(boss1);
            kyle.Attack(boss1);
            ViewInfo(boss1, kyle);
            boss1.Attack(kyle);
            ViewInfo(boss1, kyle);
            StateSwitcher<Boss> stateSwitcher1 = new(State.Death, boss1);
            StateSwitcher<Boss> stateSwitcher = stateController.OnControlState(boss1);

            stateNotificator.Notify(boss1.ActiveState);
            ViewInfo(boss1, kyle);

            Console.ReadKey();
        }
        public static void ViewInfo(Boss boss)
        {
            Console.WriteLine($"Name: {boss.Name}, Health: {boss.Health}, Damage: {boss.Damage}, State: {boss.ActiveState}.");
            Console.WriteLine(new String('_', 40));
        }
        public static void ViewInfo(Hero hero)
        {
            Console.WriteLine($"Name: {hero.Name}, Health: {hero.Health}, Damage: {hero.Damage}.");
            Console.WriteLine(new String('_', 40));
        }
        public static void ViewInfo(Boss boss, Hero hero)
        {
            Console.WriteLine($"Name: {boss.Name}, Health: {boss.Health}, Damage: {boss.Damage}, State: {boss.ActiveState}.");
            Console.WriteLine($"Name: {hero.Name}, Heath: {hero.Health}, Damage: {hero.Damage}.");
            Console.WriteLine(new String('_', 40));
        }
    }
}
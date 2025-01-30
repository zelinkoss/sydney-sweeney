namespace porjekt
{
    public class Equipment
    {
        public string Name { get; }
        public string ImagePath { get; }
        public int Defense { get; }
        public int Attack { get; }
        public int Speed { get; }

        public Equipment(string name, string imagePath, int defense, int attack, int speed)
        {
            Name = name;
            ImagePath = imagePath;
            Defense = defense;
            Attack = attack;
            Speed = speed;
        }
    }
}

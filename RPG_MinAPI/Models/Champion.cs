namespace RPG_MinAPI.Models
{
    public class Champion
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
        public double Level { get; set; }
        public double  Life { get; set; }
        public double Mana { get; set; }
        public double Stamina { get; set; }
        public double Strength { get; set; }
        public double Dexterity { get; set; }
        public double Intelligence { get; set; }
        public double Wisdom { get; set; }
        public double Charisma { get; set; }
        public bool ItsAlive { get; set; }

    }
}

namespace RPG_MinAPI.Models
{
    public class Champion
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Class { get; set; }
        public double Level { get; set; }
        public double  Life { get; set; }
        public double Mana { get; set; }
        public int Stamina { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }
        public bool ItsAlive { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }

    }
}

using RPG_MinAPI.Models;

namespace RPG_MinAPI.Data
{
    public static class HallOfChampions
    {
        public static List<Champion> champions = new List<Champion>()
        {
            new Champion
            {
                Id = 1,
                Name = "Cadan",
                Class = "Warrior",
                Level = 1,
                Life = 100,
                Mana = 70,
                Stamina = 100,
                Strength = 10,
                Dexterity = 5,
                Intelligence = 7,
                Wisdom = 3,
                Charisma = 5,
                ItsAlive = true,
            },
            new Champion
            {
                Id = 2,
                Name = "Eldric",
                Class = "Mage",
                Level = 1,
                Life = 70,
                Mana = 100,
                Stamina = 50,
                Strength = 3,
                Dexterity = 5,
                Intelligence = 10,
                Wisdom = 7,
                Charisma = 5,
                ItsAlive = true,
            },
            new Champion
            {
                Id = 3,
                Name = "Lorin",
                Class = "Rogue",
                Level = 1,
                Life = 80,
                Mana = 50,
                Stamina = 100,
                Strength = 5,
                Dexterity = 10,
                Intelligence = 5,
                Wisdom = 3,
                Charisma = 7,
                ItsAlive = true,
            },
        };
    }
}

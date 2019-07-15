namespace Core.Model
{
    public class Skill
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int WeaponId { get; set; }
        public Weapon Weapon { get; set; }
        public int PowerDamage { get; set; }
        public Range Range { get; set; }

    }
}
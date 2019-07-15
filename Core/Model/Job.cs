namespace Core.Model
{
    public class Job
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int WeaponId { get; set; }
        public Weapon Weapon { get; set; }
        public int SkillId { get; set; }
        public Skill Skill { get; set; }

    }
}
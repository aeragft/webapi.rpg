using Core.Enum;

namespace Core.Model
{
    public class Weapon
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Weapon_Type Type { get; set; }
        public Element Element { get; set; }
        public int Damage { get; set; }

    }
}
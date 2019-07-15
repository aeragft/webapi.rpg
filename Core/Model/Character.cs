using Core.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Model
{
    public class Character
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Biography { get; set; }
        public DateTime BirthDate { get; set; }
        public Gender Gender { get; set; }
        public Race Race { get; set; }
        public int JobID { get; set; }
        public Job  Job { get; set; }
        public int  WeaponId { get; set; }
        public Weapon Weapon { get; set; }

    }
}

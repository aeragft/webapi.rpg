using Application.Factories.Interface;
using Core.Enum;
using Core.Model;
using System;

namespace Application.Factories
{
    public class CharacterFactory : IFactory<Character>
    {
        public Character Create()
        {
            var character = new Character();
            

            return character;
        }
        public Character Create(int id, string name, string bio, DateTime birth, Gender gender, Race race, int jobId, int weaponId)
        {
            var character = new Character
            {
                ID = id,
                Name = name,
                Biography = bio,
                BirthDate = birth,
                Gender = gender,
                Race = race,
                JobID = jobId,
                WeaponId = weaponId
            };

            return character;


        }
    }

}



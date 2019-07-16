using Core.Model;
using Infrastructure.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace webapi.rpg.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharacterController : ControllerBase
    {
        static readonly List<Character> characters = new List<Character>();

        public CharacterRepository CharacterRepository;

        public CharacterController() { }

        [HttpGet]
        public IActionResult Characters()
        {
            return Ok(CharacterRepository.Get());

        }

        [HttpGet("{id}")]
        public IActionResult Character(int id)
        {
            var obj = FindCharacter(id);
            return Ok(characters);
        }

        [HttpPost]
        public IActionResult PostCharacter([FromBody] Character character)
        {
            CharacterRepository.Add(character);

            return Ok(character);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateCar(int Id, [FromBody] Character character)
        {
            var obj = FindCharacter(Id);

            obj.Gender = character.Gender;

            return Ok(CharacterRepository.Update(obj));
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCar(int Id)
        {
            var obj = FindCharacter(Id);

            if (obj != null)
                return Ok(CharacterRepository.Remove(obj));

            return NotFound(obj);
        }


        private Character FindCharacter(int Id)
        {
            return CharacterRepository.Find(Id);
        }
    }
}

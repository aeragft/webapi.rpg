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
        static List<Character> characters = new List<Character>();
        private readonly CharaterRepository charaterRepository;

        public CharacterController() { }

        [HttpGet]
        public IActionResult Characters()
        {
            return Ok(charaterRepository.Get());

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
            charaterRepository.Add(character);

            return Ok(character);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateCar(int Id, [FromBody] Character character)
        {
            var obj = FindCharacter(Id);

            obj.Gender = character.Gender;

            return Ok(charaterRepository.Update(obj));
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCar(int Id)
        {
            var obj = FindCharacter(Id);

            if (obj != null)
                return Ok(charaterRepository.Remove(obj));

            return NotFound(obj);
        }


        private Character FindCharacter(int Id)
        {
            return charaterRepository.Find(Id);
        }
    }
}

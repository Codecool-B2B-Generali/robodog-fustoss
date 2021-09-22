using Microsoft.AspNetCore.Mvc;
using RoboDog.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace RoboDog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DogController : ControllerBase
    {
        public IDogStorage dogs;
//dog storage
        public DogController(IDogStorage dogStorage)
        {
            dogs = dogStorage;
        }
//get all
        [HttpGet]
        public SortedList GetAll()
        {
            return dogs.GetAllDogs();
        }
//get by name
        [HttpGet("GetDogByName")]
        public ActionResult GetByName(string name)
        {
            if(dogs.GetDogByName(name) == null)
            {
                return NotFound();
            }else
            {
                return Ok(dogs.GetDogByName(name));
            }
        }
//add random
        [HttpPost]
        public ActionResult AddRandomDog()
        {
            var result = dogs.AddRandomDog();
            if (result == null)
            {
                return NotFound();
            }
            else
            {
                //return Ok(result);
                return Created("", result);
            }
        }
 //add by name
        [HttpPost("AddDogByName")]
        public ActionResult AddDog([FromBody] Dog tempDog)
        {
            if (dogs.AddDog(tempDog) == true)
            {
                return Ok(tempDog);
            }else
            {
                //return BadRequest("Dog alredy exists");
                //return Conflict();
                ModelState.AddModelError("Error", "Dog alredy exists");
                return BadRequest(ModelState);

            }
        }
//set data
        [HttpPut("SetDogByName")]
        public ActionResult SetDog(string name, int age, Dog.Breeds breed)
        {
            var result = dogs.SetDogByName(name, age, breed);
            if (result == null)
            {
                return NotFound();
            }else
            {
                return Ok(result);
            }
        }
    }
}

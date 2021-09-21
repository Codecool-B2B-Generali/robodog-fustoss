using RoboDog.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoboDog.Services
{
    public class DogCreator
    {
        string[] Names = new string[] { "Rex", "Bear", "Chip", "Jasper", "Cash" };

        public Dog CreateRandomDog()
        {
            Random rnd = new Random();
            var dog = new Dog();
            dog.Age = rnd.Next(1, 20);
            dog.Name = Names[rnd.Next(0,Names.Length)] + '_' + 
                             rnd.Next(1, 100).ToString();
            Array breeds = Enum.GetValues(typeof(Dog.Breeds));
            dog.Breed = (Dog.Breeds)breeds.GetValue(rnd.Next(breeds.Length));
            return dog;
        }
    }
}

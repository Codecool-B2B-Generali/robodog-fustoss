using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoboDog.Model
{
    public interface IDogStorage
    {
        public bool AddDog(Dog dog);
        public Dog AddRandomDog();
        public SortedList GetAllDogs();
        public Dog SetDogByName(string name, int age, Dog.Breeds breed);
        public Dog GetDogByName(string name);
    }
}

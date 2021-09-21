using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RoboDog.Services;

namespace RoboDog.Model
{
    public class DogStorage: IDogStorage
    {
        private SortedList Dogs = new SortedList();

        public bool AddDog(Dog dog)
        {
            if (Dogs[dog.Name] == null) 
            {  
                Dogs.Add(dog.Name,dog);
                return true;
            }else
            {
                return false;
            }
        }

        public Dog AddRandomDog()
        {
            var dogCreator = new DogCreator();
            var randomDog = dogCreator.CreateRandomDog();
            if (Dogs[randomDog.Name] == null)
            {
                Dogs.Add(randomDog.Name, randomDog);
                return randomDog;
            }else
            {
                return null;
            }
        }

        public SortedList GetAllDogs()
        {
            return Dogs;
        }

        public Dog SetDogByName(string name, int age, Dog.Breeds breed )
        {
            var tempDog = new Dog();
            tempDog.Name = name;
            tempDog.Age = age;
            tempDog.Breed = breed;
            if (Dogs[name] == null)
            {
                return null;
            }else
            {
                Dogs[name] = tempDog;
                return tempDog;
            }    
        }

        public Dog GetDogByName(string name)
        {
            return (Dog)Dogs[name];
        }
    }
}

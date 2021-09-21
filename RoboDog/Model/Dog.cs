using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RoboDog.Model
{
    public class Dog
    {
        [Required(ErrorMessage = "Age is required")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Breed is required")]
        public Breeds Breed { get; set; }

        public enum Breeds { Bullog, Bolognese, Setter, Kuvasz }
    }
}

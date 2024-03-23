using Controller.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class Estudiante : Person
    {
        public override void IncreaseAge()
        {
            this.Age++;
        }

        public override void PresentYourself()
        {
            Console.WriteLine("Hola, soy el estudiante " + this.Name + " " + this.LastName + " y tengo " + this.Age + " años.");
        }
    }
}

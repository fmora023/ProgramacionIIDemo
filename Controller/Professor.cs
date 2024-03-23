using Controller.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    /// <summary>
    /// Implemention for professor.
    /// </summary>
    /// <seealso cref="Controller.Interfaces.Person" />
    public class Professor : Person
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Professor"/> class.
        /// </summary>
        public Professor()
        {
            this.Courses = new List<string>();
        }

        public List<string> Courses { get; set; }

        public override void IncreaseAge()
        {
            this.Age++;
        }

        public override void PresentYourself()
        {
            Console.WriteLine("Hola, soy el profesor " + this.Name + " " + this.LastName + " y tengo " + this.Age + " años. E imparto los siguientes cursos: ");
            foreach (var item in Courses)
            {
                Console.WriteLine(item);
            }
        }

        public override string ToString()
        {
            var courses = string.Join(", ", this.Courses);
            return base.ToString() + " Cursos: " + courses;
        }
    }
}

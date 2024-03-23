using Controller.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    /// <summary>
    /// Generator in to handle the groups of people.
    /// </summary>
    public class PersonGenerator
    {
        /// <summary>
        /// Gets or sets the people.
        /// </summary>
        /// <value>
        /// The people.
        /// </value>
        public List<Person> People { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PersonGenerator"/> class.
        /// </summary>
        public PersonGenerator()
        {
            this.People = new List<Person>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PersonGenerator"/> class.
        /// </summary>
        /// <param name="people">The people.</param>
        public PersonGenerator(List<Person> people)
        {
            this.People = people;
        }

        public void AddPerson(Person person)
        {
            this.People.Add(person);
        }

        /// <summary>
        /// Initializes the people.
        /// </summary>
        public void InitializePeople()
        {
            var henry = this.CreateEstudiante("Henry", "Lin", 25, "ABC187");

            var gabriel = this.CreateEstudiante("Gabriel", "Segura", 25, "ABC321");

            var daniel = this.CreateEstudiante("Daniel", "Quesada", 25, "ABC456");

            var jose = this.CreateEstudiante("Jose", "Orozco", 25, "ABC789");

            var profesor = new Professor
            {
                Name = "Felipe",
                LastName = "Mora",
                Age = 26,
                Id = "123456",
                Courses = new List<string> { "Programacion II" },
            };

            this.People.AddRange(new Person[] { henry, gabriel, daniel, jose, profesor });
        }

        private Estudiante CreateEstudiante(string name, string lastName, int age, string id)
        {
            return new Estudiante
            {
                Name = name,
                LastName = lastName,
                Age = age,
                Id = id,
            };
        }
    }
}

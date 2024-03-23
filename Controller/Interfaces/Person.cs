using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.Interfaces
{
    /// <summary>
    /// Interface to define the behavior of a person.
    /// </summary>
    public abstract class Person
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>
        /// The last name.
        /// </value>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the age.
        /// </summary>
        /// <value>
        /// The age.
        /// </value>
        public int Age { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string Id { get; set; }

        /// <summary>
        /// Increases the age.
        /// </summary>
        public abstract void IncreaseAge();

        /// <summary>
        /// Presents the yourself.
        /// </summary>
        public abstract void PresentYourself();

        public override string ToString()
        {
            return this.Name + " " + this.LastName + " Edad: " + this.Age + " Identificacion: " + this.Id;
        }
    }
}

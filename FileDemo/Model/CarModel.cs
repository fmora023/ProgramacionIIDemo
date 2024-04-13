using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileDemo.Model
{
    public class CarModel : ICarModel
    {
        /// <summary>
        /// Gets or sets the marca.
        /// </summary>
        /// <value>
        /// The marca.
        /// </value>
        public string Marca { get; set; }

        /// <summary>
        /// Gets or sets the modelo.
        /// </summary>
        /// <value>
        /// The modelo.
        /// </value>
        public string Modelo { get; set; }

        /// <summary>
        /// Gets or sets the volumen.
        /// </summary>
        /// <value>
        /// The volumen.
        /// </value>
        public int Volumen { get; set; }

        /// <summary>
        /// Gets or sets the peso.
        /// </summary>
        /// <value>
        /// The peso.
        /// </value>
        public int Peso { get; set; }

        /// <summary>
        /// Gets or sets the c o2.
        /// </summary>
        /// <value>
        /// The c o2.
        /// </value>
        public int CO2 { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CarModel"/> class.
        /// </summary>
        /// <param name="marca">The marca.</param>
        /// <param name="modelo">The modelo.</param>
        /// <param name="volumen">The volumen.</param>
        /// <param name="peso">The peso.</param>
        /// <param name="cO2">The co2.</param>
        public CarModel(string marca, string modelo, int volumen, int peso, int cO2)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Volumen = volumen;
            this.Peso = peso;
            this.CO2 = cO2;
        }

        public override string ToString()
        {
            return this.Marca + ',' + this.Modelo + ',' + this.Volumen.ToString() + ',' + this.Peso.ToString() + ',' + this.CO2.ToString();
        }
    }
}

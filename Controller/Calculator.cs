﻿using Controller.Interfaces;

namespace Controller
{
    /// <summary>
    /// Implementation for ICalculator interface.
    /// </summary>
    /// <seealso cref="ICalculator" />
    public class Calculator : ICalculator
    {
        private static Calculator Instance { get; set; }

        public Calculator()
        {
        }

        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <returns>the instance of the source.</returns>
        public static Calculator GetInstance()
        {
            if (Instance == null)
            {
                return new Calculator();
            }

            return Instance;
        }

        /// <summary>
        /// Rests the specified valor1 minus valor2.
        /// </summary>
        /// <param name="valor1">The valor1.</param>
        /// <param name="valor2">The valor2.</param>
        /// <returns>
        /// valor1 - valor2
        /// </returns>
        public int Resta(int valor1, int valor2) => valor1 - valor2;

        /// <summary>
        /// Sums the specified valor1 with valor2.
        /// </summary>
        /// <param name="valor1">The valor1.</param>
        /// <param name="valor2">The valor2.</param>
        /// <returns>
        /// valor1 + valor2
        /// </returns>
        public int Suma(int valor1, int valor2) => valor1 + valor2;

        /// <summary>
        /// Multiplicacions the specified valor1.
        /// </summary>
        /// <param name="valor1">The valor1.</param>
        /// <param name="valor2">The valor2.</param>
        /// <returns>
        /// valor1 * valor2
        /// </returns>
        public int Multiplicacion(int valor1, int valor2) => valor1 * valor2;

        /// <summary>
        /// Divide valor1/valor2
        /// </summary>
        /// <param name="valor1"></param>
        /// <param name="valor2"></param>
        /// <returns> valor1/valor2 </returns>
        public int Division(int valor1, int valor2)
        {            
            if (valor2 == 0)
            {
                return -1;
            }
            return valor1 / valor2;
        }
    }
}

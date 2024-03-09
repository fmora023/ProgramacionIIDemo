namespace Controller.Interfaces
{
    /// <summary>
    /// Interface for a standard calculator.
    /// </summary>
    public interface ICalculator
    {
        /// <summary>
        /// Divides the specified valor1/valor2.
        /// </summary>
        /// <param name="valor1">The valor1.</param>
        /// <param name="valor2">The valor2.</param>
        /// <returns> valor1 / valor2</returns>
        int Division(int valor1, int valor2);

        /// <summary>
        /// Multiplicacions the specified valor1.
        /// </summary>
        /// <param name="valor1">The valor1.</param>
        /// <param name="valor2">The valor2.</param>
        /// <returns> valor1 * valor2</returns>
        int Multiplicacion(int valor1, int valor2);

        /// <summary>
        /// Sums the specified valor1 with valor2.
        /// </summary>
        /// <param name="valor1">The valor1.</param>
        /// <param name="valor2">The valor2.</param>
        /// <returns>valor1 + valor2</returns>
        int Suma(int valor1, int valor2);

        /// <summary>
        /// Rests the specified valor1 minus valor2.
        /// </summary>
        /// <param name="valor1">The valor1.</param>
        /// <param name="valor2">The valor2.</param>
        /// <returns> valor1 - valor2 </returns>
        int Resta(int valor1, int valor2);
    }
}
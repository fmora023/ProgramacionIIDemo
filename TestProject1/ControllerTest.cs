using Controller;

namespace Controller.Test
{
    /// <summary>
    ///   Test for <see cref="Controller"/>.
    /// </summary>
    [TestClass]
    public class ControllerTest
    {
        private Calculator calculator;

        /// <summary>
        ///     Initializes this test scenario.
        /// </summary>
        [TestInitialize]
        public void Initialize()
        {
            calculator = Calculator.GetInstance();
        }

        /// <summary>
        /// 	Shoulds the get instance.
        /// </summary>
        [TestMethod]
        public void ShouldGetInstance()
        {
            // Given
            Calculator calculator;

            // When
            calculator = Calculator.GetInstance();

            // Then
            Assert.IsNotNull(calculator);
        }

        /// <summary>
        /// Shoulds the sum elements.
        /// </summary>
        [TestMethod]
        public void ShouldSumElements()
        {
            // Given
            var element1 = 2;
            var element2 = 3;

            // When
            var result = this.calculator.Suma(element1, element2);

            // Then
            Assert.AreEqual(5, result);
        }

        /// <summary>
        /// Shoulds the rest element.
        /// </summary>
        [TestMethod]
        public void ShouldRestElement()
        {
            // Given
            var elemento = 1;
            var elemento2 = 0;

            // When
            var result = this.calculator.Resta(elemento, elemento2);

            // Then
            Assert.AreEqual(1, result);
        }
    }
}
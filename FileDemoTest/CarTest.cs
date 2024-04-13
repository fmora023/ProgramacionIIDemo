using FileDemo.Model;

namespace FileDemoTest
{
    [TestClass]
    public class CarTest
    {
        [TestMethod]
        public void ShouldCreateInstance()
        {
            var car = new CarModel("Toyota", "Corolla", 100, 2000, 100);

            Assert.AreEqual("Toyota", car.Marca);
            Assert.AreEqual("Corolla", car.Modelo);
        }
    }
}
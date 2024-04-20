using FileDemo.Model;
using FileDemo;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Data;

namespace FileDemoTest
{
    /// <summary>
    /// Test class for <see cref="FileLoader"/>.
    /// </summary>
    [TestClass]
    public class FileLoaderTest
    {
        private List<CarModel>? cars;

        [TestInitialize]
        public void Initialize()
        {
            cars = new List<CarModel>();
            if (!Directory.Exists("Output"))
            {
                Directory.CreateDirectory("Output");
            }
        }

        /// <summary>
        /// Cleans up.
        /// </summary>
        [TestCleanup]
        public void CleanUp()
        {
            if (File.Exists("Output\\cars_Modified.csv"))
            {
                File.Delete("Output\\cars_Modified.csv");
            }

            if (Directory.Exists("Output"))
            {
                Directory.Delete("Output", true);
            }
        }

        /// <summary>
        /// Tests the load cars.
        /// </summary>
        [TestMethod]
        public void TestLoadCars()
        {
            cars = FileLoader.LoadCars("cars.csv");
            Assert.AreEqual(37, cars.Count);
            Assert.AreEqual("Toyoty,Aygo,1000,790,99", cars[0].ToString());
        }

        /// <summary>
        /// Tests the save cars.
        /// </summary>
        [TestMethod]
        public void TestSaveCars()
        {
            cars = FileLoader.LoadCars("cars.csv");
            var newCars = new List<CarModel>
            {
                new CarModel("Toyota", "Yaris", 100, 1000, 100),
                new CarModel("Tesla", "Model 3", 200, 2000, 200),
                new CarModel("Mini", "Cooper", 300, 3000, 300)
            };

            cars.AddRange(newCars);
            FileLoader.SaveCars("Output\\cars_Modified.csv", cars);
            var lines = File.ReadAllLines("Output\\cars_Modified.csv");
            Assert.AreEqual(41, lines.Length);
            Assert.AreEqual("Car,Model,Volume,Weight,CO2", lines[0]);
            Assert.AreEqual("Toyota,Yaris,100,1000,100", lines[38]);
            Assert.AreEqual("Tesla,Model 3,200,2000,200", lines[39]);
            Assert.AreEqual("Mini,Cooper,300,3000,300", lines[40]);
        }


        [TestMethod]
        public void ReadCalories()
        {
            //Duration,Date,Pulse,Maxpulse,Calories
            //60,'2020/12/01',110,130,409.1
            var cals = FileLoader.LoadCals("calories.csv");
            Assert.AreEqual(31, cals.Count, "Count wrong");
            Assert.AreEqual(60, cals[0].Duration, $"Duration value is wrong. Current = {cals[0].Duration} => Expected: 30");
            Assert.AreEqual(110, cals[0].Pulse);
            Assert.AreEqual(130, cals[0].MaxPulse);
            Assert.AreEqual(409.1, cals[0].Calories);
            Assert.AreEqual(new DateTime(2020, 12, 01), cals[0].Date);

        }
    }
}

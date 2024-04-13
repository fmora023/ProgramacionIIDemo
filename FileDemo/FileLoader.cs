using FileDemo.Model;

namespace FileDemo
{
    /// <summary>
    /// Class in charge of handle the file methods.
    /// </summary>
    public static class FileLoader
    {
        /// <summary>
        /// Loads the cars.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <returns> all the cars loaded from the file in a list. </returns>
        public static List<CarModel> LoadCars(string path)
        {
            var cars = new List<CarModel>();
            var lines = File.ReadAllLines(path);
            for (var i = 1; i < lines.Length; i++)
            {
                var parts = lines[i].Split(',');
                var car = new CarModel(parts[0], parts[1], int.Parse(parts[2]), int.Parse(parts[3]), int.Parse(parts[4]));
                cars.Add(car);
            }

            return cars;
        }

        /// <summary>
        /// Saves the cars.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <param name="cars">The cars.</param>
        public static void SaveCars(string path, List<CarModel> cars)
        {
            var lines = new List<string> { "Car,Model,Volume,Weight,CO2" };
            foreach (var car in cars)
            {
                lines.Add(car.ToString());
            }

            File.WriteAllLines(path, lines);
        }
    }
}

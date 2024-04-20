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
        /// Loads the cals.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <returns> all the cals loaded from the file in a list. </returns>
        public static List<Cals> LoadCals(string path)
        {
            var format = "yyyy/MM/dd";
            var cals = new List<Cals>();
            var lines = File.ReadAllLines(path);
            for (var i = 1; i < lines.Length; i++)
            {
                var parts = lines[i].Split(',');
                var date = DateTime.ParseExact(parts[1].Replace("\'", string.Empty), format, null);
                var fileEntry = new Cals()
                {
                    Duration = int.Parse(parts[0]),
                    Date = date,
                    Pulse = int.Parse(parts[2]),
                    MaxPulse = int.Parse(parts[3]),
                    Calories = double.Parse(parts[4]),
                };
                cals.Add(fileEntry);
            }

            return cals;
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

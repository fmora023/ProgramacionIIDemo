namespace FileDemo.Model
{
    /// <summary>
    /// Calories file model representation.
    /// </summary>
    public class Cals
    {
        /// <summary>
        /// Gets or sets the duration.
        /// </summary>
        /// <value>
        /// The duration.
        /// </value>
        public int Duration { get; set; }

        /// <summary>
        /// Gets or sets the date.
        /// </summary>
        /// <value>
        /// The date.
        /// </value>
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets or sets the pulse.
        /// </summary>
        /// <value>
        /// The pulse.
        /// </value>
        public int Pulse { get; set; }

        /// <summary>
        /// Gets or sets the maximum pulse.
        /// </summary>
        /// <value>
        /// The maximum pulse.
        /// </value>
        public int MaxPulse { get; set; }

        /// <summary>
        /// Gets or sets the calories.
        /// </summary>
        /// <value>
        /// The calories.
        /// </value>
        public double Calories { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Cals"/> class.
        /// </summary>
        public Cals()
        {
        }
    }
}

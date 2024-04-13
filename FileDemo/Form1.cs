using FileDemo.Model;

namespace FileDemo
{
    public partial class Form1 : Form
    {
        private int xpos = 10;
        private int ypos = 10;

        internal List<CarModel> Cars { get; set; }

        public Form1()
        {
            InitializeComponent();
            this.Cars = FileLoader.LoadCars("cars.csv");
            //this.Cars = FileLoader.LoadCars(@"S:\UPI\Programacion II 2024\Demo\FileDemo\cars.csv");

            foreach (var car in this.Cars)
            {
                if (car.Marca == "Toyoty")
                {
                    car.Marca = "Toyota";
                }
                else if (car.Marca == "Tesla")
                {
                    car.CO2 *= 4;
                }
                else if (car.Marca == "Mini")
                {
                    car.CO2 *= 2;
                }
            }

            // FileLoader.SaveCars(@"S:\UPI\Programacion II 2024\Demo\FileDemo\cars_Modified.csv", this.Cars);

            this.ShowCars();
        }

        private void ShowCars()
        {
            this.SuspendLayout();

            this.Controls.Add(CreateLabel("Marca", this.xpos, this.ypos));
            this.Controls.Add(CreateLabel("Modelo", this.xpos + 100, this.ypos));
            this.Controls.Add(CreateLabel("Volumen", this.xpos + 200, this.ypos));
            this.Controls.Add(CreateLabel("CO2", this.xpos + 300, this.ypos));

            this.ypos += 25;

            foreach (var car in this.Cars)
            {
                this.Controls.Add(CreateLabel(car.Marca, this.xpos, this.ypos));
                this.Controls.Add(CreateLabel(car.Modelo, this.xpos + 100, this.ypos));
                this.Controls.Add(CreateLabel(car.Volumen.ToString(), this.xpos + 200, this.ypos));
                this.Controls.Add(CreateLabel(car.CO2.ToString(), this.xpos + 300, this.ypos));

                this.ypos += 25;
            }

            this.AutoSize = true;
            this.ResumeLayout();
            PerformLayout();
        }

        private Label CreateLabel(string text, int x, int y)
        {
            var label = new Label();
            label.Text = text;
            label.Location = new Point(x, y);
            label.AutoSize = true;

            return label;
        }
    }
}

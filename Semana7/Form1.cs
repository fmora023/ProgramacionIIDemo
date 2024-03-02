using System;
using System.Windows.Forms;

namespace Semana7
{
    /// <summary>
    /// Calculator form.
    /// </summary>
    public partial class Form1 : Form
    {
        private Calculator Calculator { get; set; }

        private readonly string DefaultValue = "1";

        /// <summary>
        /// Initializes a new instance of the <see cref="Form1"/> class.
        /// </summary>
        public Form1()
        {
            this.Calculator = Calculator.GetInstance();
            InitializeComponent();
            this.ResetValues();
        }

        private void btn_Suma_Click(object sender, EventArgs e)
        {
            var (valor1, valor2) = this.GetIntegerParameters();
            var result = this.Calculator.Suma(valor1, valor2);
            this.MostrarResultado(result, "suma");
        }

        private void btn_Resta_Click(object sender, EventArgs e)
        {
            var (valor1, valor2) = this.GetIntegerParameters();
            var result = this.Calculator.Resta(valor1, valor2);
            this.MostrarResultado(result, "resta");
        }

        private (int, int) GetIntegerParameters()
        {
            if (int.TryParse(this.tbx_Valor1.Text, out var valor1) && int.TryParse(this.tbx_Valor2.Text, out var valor2))
            {
                return (valor1, valor2);
            }

            return (0, 0);
        }

        private void MostrarResultado(int result, string operacion)
        {
            MessageBox.Show($"El resultado de la {operacion} es: {result}");
            this.ResetValues();
        }

        private void ResetValues()
        {
            this.tbx_Valor1.Text = this.DefaultValue;
            this.tbx_Valor2.Text = this.DefaultValue;
        }
    }
}

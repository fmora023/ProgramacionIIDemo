﻿using Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Semana7
{
    /// <summary>
    /// Calculator form.
    /// </summary>
    public partial class Form1 : Form
    {
        private Calculator Calculator { get; set; }

        private PersonGenerator PersonGenerator { get; set; }

        private readonly string DefaultValue = "1";

        /// <summary>
        /// Initializes a new instance of the <see cref="Form1"/> class.
        /// </summary>
        public Form1()
        {
            this.PersonGenerator = new PersonGenerator();
            this.PersonGenerator.InitializePeople();
            this.Calculator = Calculator.GetInstance();
            InitializeComponent();
            this.ResetValues();
        }

        private void btn_Mult_Click(object sender, EventArgs e)
        {
            var (valor1, valor2) = this.GetIntegerParameters();
            this.MostrarResultado(this.Calculator.Multiplicacion(valor1, valor2), "multiplicacion");
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

        private void btn_Div_Click(object sender, EventArgs e)
        {
            var (valor1, valor2) = this.GetIntegerParameters();
            var result = this.Calculator.Division(valor1, valor2);
            this.MostrarResultado(result, "division");
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

        private void btn_LoadData_Click(object sender, EventArgs e)
        {
            this.cbx_People.Items.Clear();
            this.cbx_People.Items.AddRange(this.PersonGenerator.People.Select(p => p.ToString()).ToArray());
            MessageBox.Show("Datos cargados correctamente");
        }
    }
}

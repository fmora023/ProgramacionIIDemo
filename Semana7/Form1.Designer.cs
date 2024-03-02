
namespace Semana7
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Valor1 = new System.Windows.Forms.Label();
            this.lbl_Value2 = new System.Windows.Forms.Label();
            this.tbx_Valor1 = new System.Windows.Forms.TextBox();
            this.tbx_Valor2 = new System.Windows.Forms.TextBox();
            this.btn_Suma = new System.Windows.Forms.Button();
            this.btn_Resta = new System.Windows.Forms.Button();
            this.btn_Mult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Valor1
            // 
            this.lbl_Valor1.AutoSize = true;
            this.lbl_Valor1.Location = new System.Drawing.Point(61, 52);
            this.lbl_Valor1.Name = "lbl_Valor1";
            this.lbl_Valor1.Size = new System.Drawing.Size(118, 20);
            this.lbl_Valor1.TabIndex = 0;
            this.lbl_Valor1.Text = "Valor 1 a operar:";
            // 
            // lbl_Value2
            // 
            this.lbl_Value2.AutoSize = true;
            this.lbl_Value2.Location = new System.Drawing.Point(61, 125);
            this.lbl_Value2.Name = "lbl_Value2";
            this.lbl_Value2.Size = new System.Drawing.Size(118, 20);
            this.lbl_Value2.TabIndex = 1;
            this.lbl_Value2.Text = "Valor 2 a operar:";
            // 
            // tbx_Valor1
            // 
            this.tbx_Valor1.Location = new System.Drawing.Point(265, 52);
            this.tbx_Valor1.Name = "tbx_Valor1";
            this.tbx_Valor1.Size = new System.Drawing.Size(125, 27);
            this.tbx_Valor1.TabIndex = 2;
            // 
            // tbx_Valor2
            // 
            this.tbx_Valor2.Location = new System.Drawing.Point(265, 125);
            this.tbx_Valor2.Name = "tbx_Valor2";
            this.tbx_Valor2.Size = new System.Drawing.Size(125, 27);
            this.tbx_Valor2.TabIndex = 3;
            // 
            // btn_Suma
            // 
            this.btn_Suma.Location = new System.Drawing.Point(520, 344);
            this.btn_Suma.Name = "btn_Suma";
            this.btn_Suma.Size = new System.Drawing.Size(140, 29);
            this.btn_Suma.TabIndex = 4;
            this.btn_Suma.Text = "Ejecutar Suma";
            this.btn_Suma.UseVisualStyleBackColor = true;
            this.btn_Suma.Click += new System.EventHandler(this.btn_Suma_Click);
            // 
            // btn_Resta
            // 
            this.btn_Resta.Location = new System.Drawing.Point(61, 344);
            this.btn_Resta.Name = "btn_Resta";
            this.btn_Resta.Size = new System.Drawing.Size(148, 29);
            this.btn_Resta.TabIndex = 5;
            this.btn_Resta.Text = "Ejecutar Resta";
            this.btn_Resta.UseVisualStyleBackColor = true;
            this.btn_Resta.Click += new System.EventHandler(this.btn_Resta_Click);
            // 
            // btn_Mult
            // 
            this.btn_Mult.Location = new System.Drawing.Point(276, 344);
            this.btn_Mult.Name = "btn_Mult";
            this.btn_Mult.Size = new System.Drawing.Size(195, 29);
            this.btn_Mult.TabIndex = 6;
            this.btn_Mult.Text = "Ejecutar Multiplicacion";
            this.btn_Mult.UseVisualStyleBackColor = true;
            this.btn_Mult.Click += new System.EventHandler(this.btn_Mult_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Mult);
            this.Controls.Add(this.btn_Resta);
            this.Controls.Add(this.btn_Suma);
            this.Controls.Add(this.tbx_Valor2);
            this.Controls.Add(this.tbx_Valor1);
            this.Controls.Add(this.lbl_Value2);
            this.Controls.Add(this.lbl_Valor1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Valor1;
        private System.Windows.Forms.Label lbl_Value2;
        private System.Windows.Forms.TextBox tbx_Valor1;
        private System.Windows.Forms.TextBox tbx_Valor2;
        private System.Windows.Forms.Button btn_Suma;
        private System.Windows.Forms.Button btn_Resta;
        private System.Windows.Forms.Button btn_Mult;
    }
}


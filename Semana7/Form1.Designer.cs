
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
            lbl_Valor1 = new System.Windows.Forms.Label();
            lbl_Value2 = new System.Windows.Forms.Label();
            tbx_Valor1 = new System.Windows.Forms.TextBox();
            tbx_Valor2 = new System.Windows.Forms.TextBox();
            btn_Suma = new System.Windows.Forms.Button();
            btn_Resta = new System.Windows.Forms.Button();
            btn_Mult = new System.Windows.Forms.Button();
            btn_Div = new System.Windows.Forms.Button();
            cbx_People = new System.Windows.Forms.ComboBox();
            btn_LoadData = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lbl_Valor1
            // 
            lbl_Valor1.AutoSize = true;
            lbl_Valor1.Location = new System.Drawing.Point(61, 52);
            lbl_Valor1.Name = "lbl_Valor1";
            lbl_Valor1.Size = new System.Drawing.Size(118, 20);
            lbl_Valor1.TabIndex = 0;
            lbl_Valor1.Text = "Valor 1 a operar:";
            // 
            // lbl_Value2
            // 
            lbl_Value2.AutoSize = true;
            lbl_Value2.Location = new System.Drawing.Point(61, 125);
            lbl_Value2.Name = "lbl_Value2";
            lbl_Value2.Size = new System.Drawing.Size(118, 20);
            lbl_Value2.TabIndex = 1;
            lbl_Value2.Text = "Valor 2 a operar:";
            // 
            // tbx_Valor1
            // 
            tbx_Valor1.Location = new System.Drawing.Point(265, 52);
            tbx_Valor1.Name = "tbx_Valor1";
            tbx_Valor1.Size = new System.Drawing.Size(125, 27);
            tbx_Valor1.TabIndex = 2;
            // 
            // tbx_Valor2
            // 
            tbx_Valor2.Location = new System.Drawing.Point(265, 125);
            tbx_Valor2.Name = "tbx_Valor2";
            tbx_Valor2.Size = new System.Drawing.Size(125, 27);
            tbx_Valor2.TabIndex = 3;
            // 
            // btn_Suma
            // 
            btn_Suma.Location = new System.Drawing.Point(612, 344);
            btn_Suma.Name = "btn_Suma";
            btn_Suma.Size = new System.Drawing.Size(140, 29);
            btn_Suma.TabIndex = 4;
            btn_Suma.Text = "Ejecutar Suma";
            btn_Suma.UseVisualStyleBackColor = true;
            btn_Suma.Click += btn_Suma_Click;
            // 
            // btn_Resta
            // 
            btn_Resta.Location = new System.Drawing.Point(31, 344);
            btn_Resta.Name = "btn_Resta";
            btn_Resta.Size = new System.Drawing.Size(148, 29);
            btn_Resta.TabIndex = 5;
            btn_Resta.Text = "Ejecutar Resta";
            btn_Resta.UseVisualStyleBackColor = true;
            btn_Resta.Click += btn_Resta_Click;
            // 
            // btn_Mult
            // 
            btn_Mult.Location = new System.Drawing.Point(378, 344);
            btn_Mult.Name = "btn_Mult";
            btn_Mult.Size = new System.Drawing.Size(195, 29);
            btn_Mult.TabIndex = 6;
            btn_Mult.Text = "Ejecutar Multiplicacion";
            btn_Mult.UseVisualStyleBackColor = true;
            btn_Mult.Click += btn_Mult_Click;
            // 
            // btn_Div
            // 
            btn_Div.Location = new System.Drawing.Point(198, 344);
            btn_Div.Name = "btn_Div";
            btn_Div.Size = new System.Drawing.Size(154, 29);
            btn_Div.TabIndex = 6;
            btn_Div.Text = "Ejecutar Division";
            btn_Div.UseVisualStyleBackColor = true;
            btn_Div.Click += btn_Div_Click;
            // 
            // cbx_People
            // 
            cbx_People.FormattingEnabled = true;
            cbx_People.Location = new System.Drawing.Point(31, 178);
            cbx_People.Name = "cbx_People";
            cbx_People.Size = new System.Drawing.Size(721, 28);
            cbx_People.TabIndex = 7;
            // 
            // btn_LoadData
            // 
            btn_LoadData.Location = new System.Drawing.Point(31, 273);
            btn_LoadData.Name = "btn_LoadData";
            btn_LoadData.Size = new System.Drawing.Size(148, 29);
            btn_LoadData.TabIndex = 8;
            btn_LoadData.Text = "LoadData";
            btn_LoadData.UseVisualStyleBackColor = true;
            btn_LoadData.Click += btn_LoadData_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(btn_LoadData);
            Controls.Add(cbx_People);
            Controls.Add(btn_Div);
            Controls.Add(btn_Mult);
            Controls.Add(btn_Resta);
            Controls.Add(btn_Suma);
            Controls.Add(tbx_Valor2);
            Controls.Add(tbx_Valor1);
            Controls.Add(lbl_Value2);
            Controls.Add(lbl_Valor1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbl_Valor1;
        private System.Windows.Forms.Label lbl_Value2;
        private System.Windows.Forms.TextBox tbx_Valor1;
        private System.Windows.Forms.TextBox tbx_Valor2;
        private System.Windows.Forms.Button btn_Suma;
        private System.Windows.Forms.Button btn_Resta;
        private System.Windows.Forms.Button btn_Mult;
        private System.Windows.Forms.Button btn_Div;
        private System.Windows.Forms.ComboBox cbx_People;
        private System.Windows.Forms.Button btn_LoadData;
    }
}


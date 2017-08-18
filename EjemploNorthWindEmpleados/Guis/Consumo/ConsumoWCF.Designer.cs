namespace EjemploNorthWindEmpleados.Guis.Consumo
{
    partial class ConsumoWCF
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.num1 = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.TextBox();
            this.btn_suma = new System.Windows.Forms.Button();
            this.btn_multiplicacion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(40, 49);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(100, 22);
            this.num1.TabIndex = 0;
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(268, 49);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(100, 22);
            this.num2.TabIndex = 1;
            // 
            // btn_suma
            // 
            this.btn_suma.Location = new System.Drawing.Point(160, 24);
            this.btn_suma.Name = "btn_suma";
            this.btn_suma.Size = new System.Drawing.Size(75, 23);
            this.btn_suma.TabIndex = 2;
            this.btn_suma.Text = "+";
            this.btn_suma.UseVisualStyleBackColor = true;
            this.btn_suma.Click += new System.EventHandler(this.btn_suma_Click);
            // 
            // btn_multiplicacion
            // 
            this.btn_multiplicacion.Location = new System.Drawing.Point(160, 66);
            this.btn_multiplicacion.Name = "btn_multiplicacion";
            this.btn_multiplicacion.Size = new System.Drawing.Size(75, 23);
            this.btn_multiplicacion.TabIndex = 3;
            this.btn_multiplicacion.Text = "*";
            this.btn_multiplicacion.UseVisualStyleBackColor = true;
            this.btn_multiplicacion.Click += new System.EventHandler(this.btn_multiplicacion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(386, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "=";
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.Location = new System.Drawing.Point(409, 53);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(72, 17);
            this.lbl_resultado.TabIndex = 5;
            this.lbl_resultado.Text = "Resultado";
            // 
            // ConsumoWCF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 119);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_multiplicacion);
            this.Controls.Add(this.btn_suma);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Name = "ConsumoWCF";
            this.Text = "ConsumoWCF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox num1;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.Button btn_suma;
        private System.Windows.Forms.Button btn_multiplicacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_resultado;
    }
}
namespace Deber_WindowsForm
{
    partial class Form1
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
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTemperature1 = new System.Windows.Forms.TextBox();
            this.checkCelsius = new System.Windows.Forms.CheckBox();
            this.checkFahrenheit = new System.Windows.Forms.CheckBox();
            this.response = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Blue;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(133, 256);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 42);
            this.button2.TabIndex = 0;
            this.button2.Text = "Calcular";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Yellow;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(12, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(371, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sistema de conversiòn";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(95, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ingrese una temperatura";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(102, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Convertir a:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTemperature1
            // 
            this.txtTemperature1.Location = new System.Drawing.Point(99, 123);
            this.txtTemperature1.Name = "txtTemperature1";
            this.txtTemperature1.Size = new System.Drawing.Size(206, 20);
            this.txtTemperature1.TabIndex = 4;
            // 
            // checkCelsius
            // 
            this.checkCelsius.AutoSize = true;
            this.checkCelsius.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkCelsius.Location = new System.Drawing.Point(106, 202);
            this.checkCelsius.Name = "checkCelsius";
            this.checkCelsius.Size = new System.Drawing.Size(69, 37);
            this.checkCelsius.TabIndex = 5;
            this.checkCelsius.Text = "°C";
            this.checkCelsius.UseVisualStyleBackColor = true;
            // 
            // checkFahrenheit
            // 
            this.checkFahrenheit.AutoSize = true;
            this.checkFahrenheit.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkFahrenheit.Location = new System.Drawing.Point(225, 202);
            this.checkFahrenheit.Name = "checkFahrenheit";
            this.checkFahrenheit.Size = new System.Drawing.Size(66, 37);
            this.checkFahrenheit.TabIndex = 6;
            this.checkFahrenheit.Text = "°F";
            this.checkFahrenheit.UseVisualStyleBackColor = true;
            // 
            // response
            // 
            this.response.AutoSize = true;
            this.response.Location = new System.Drawing.Point(91, 311);
            this.response.Name = "response";
            this.response.Size = new System.Drawing.Size(35, 13);
            this.response.TabIndex = 7;
            this.response.Text = "label5";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(413, 396);
            this.Controls.Add(this.response);
            this.Controls.Add(this.checkFahrenheit);
            this.Controls.Add(this.checkCelsius);
            this.Controls.Add(this.txtTemperature1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTemperature;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTemperature1;
        private System.Windows.Forms.CheckBox checkCelsius;
        private System.Windows.Forms.CheckBox checkFahrenheit;
        private System.Windows.Forms.Label response;
    }
}


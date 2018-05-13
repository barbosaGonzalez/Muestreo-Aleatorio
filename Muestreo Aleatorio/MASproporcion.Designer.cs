namespace Muestreo_Aleatorio
{
    partial class MASproporcion
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
            this.txtPoblacion = new System.Windows.Forms.TextBox();
            this.txtMuestra = new System.Windows.Forms.TextBox();
            this.txtProporcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEstimacion = new System.Windows.Forms.TextBox();
            this.txtIntervaloTotal = new System.Windows.Forms.TextBox();
            this.txtMuestraTotal = new System.Windows.Forms.TextBox();
            this.txtMuestraPreeliminar = new System.Windows.Forms.TextBox();
            this.txtIC = new System.Windows.Forms.TextBox();
            this.txtDesviacion = new System.Windows.Forms.TextBox();
            this.txtQ = new System.Windows.Forms.TextBox();
            this.txtP = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtZ = new System.Windows.Forms.TextBox();
            this.txtPresicion = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPoblacion
            // 
            this.txtPoblacion.Location = new System.Drawing.Point(143, 16);
            this.txtPoblacion.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtPoblacion.Name = "txtPoblacion";
            this.txtPoblacion.Size = new System.Drawing.Size(164, 26);
            this.txtPoblacion.TabIndex = 0;
            this.txtPoblacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPoblacion_KeyPress);
            // 
            // txtMuestra
            // 
            this.txtMuestra.Location = new System.Drawing.Point(143, 42);
            this.txtMuestra.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtMuestra.Name = "txtMuestra";
            this.txtMuestra.Size = new System.Drawing.Size(164, 26);
            this.txtMuestra.TabIndex = 1;
            this.txtMuestra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPoblacion_KeyPress);
            // 
            // txtProporcion
            // 
            this.txtProporcion.Location = new System.Drawing.Point(445, 16);
            this.txtProporcion.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtProporcion.Name = "txtProporcion";
            this.txtProporcion.Size = new System.Drawing.Size(164, 26);
            this.txtProporcion.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Población:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Muestra:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(317, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Proporción:";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(329, 76);
            this.btnGenerar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(106, 31);
            this.btnGenerar.TabIndex = 5;
            this.btnGenerar.Text = "&Calcular";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 30);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(258, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Proporcion Verdadera (p):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 56);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(258, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Proporcion Verdadera (q):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 82);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(208, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Desviacion Estandar:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 108);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(268, 18);
            this.label7.TabIndex = 10;
            this.label7.Text = "I.C. Proporcion Verdadera:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 186);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(208, 18);
            this.label8.TabIndex = 11;
            this.label8.Text = "Muestra Preeliminar:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 212);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 18);
            this.label9.TabIndex = 12;
            this.label9.Text = "Muestra Total:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 160);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(168, 18);
            this.label10.TabIndex = 13;
            this.label10.Text = "Intervalo Total:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(32, 134);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(198, 18);
            this.label11.TabIndex = 14;
            this.label11.Text = "Estimacion Puntual:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkKhaki;
            this.groupBox1.Controls.Add(this.txtEstimacion);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtIntervaloTotal);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtMuestraTotal);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtMuestraPreeliminar);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtIC);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtDesviacion);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtQ);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtP);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(6, 115);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Size = new System.Drawing.Size(654, 243);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resultados";
            // 
            // txtEstimacion
            // 
            this.txtEstimacion.Enabled = false;
            this.txtEstimacion.Location = new System.Drawing.Point(300, 126);
            this.txtEstimacion.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtEstimacion.Name = "txtEstimacion";
            this.txtEstimacion.Size = new System.Drawing.Size(341, 26);
            this.txtEstimacion.TabIndex = 23;
            // 
            // txtIntervaloTotal
            // 
            this.txtIntervaloTotal.Enabled = false;
            this.txtIntervaloTotal.Location = new System.Drawing.Point(300, 152);
            this.txtIntervaloTotal.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtIntervaloTotal.Name = "txtIntervaloTotal";
            this.txtIntervaloTotal.Size = new System.Drawing.Size(341, 26);
            this.txtIntervaloTotal.TabIndex = 22;
            // 
            // txtMuestraTotal
            // 
            this.txtMuestraTotal.Enabled = false;
            this.txtMuestraTotal.Location = new System.Drawing.Point(300, 204);
            this.txtMuestraTotal.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtMuestraTotal.Name = "txtMuestraTotal";
            this.txtMuestraTotal.Size = new System.Drawing.Size(341, 26);
            this.txtMuestraTotal.TabIndex = 21;
            // 
            // txtMuestraPreeliminar
            // 
            this.txtMuestraPreeliminar.Enabled = false;
            this.txtMuestraPreeliminar.Location = new System.Drawing.Point(300, 178);
            this.txtMuestraPreeliminar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtMuestraPreeliminar.Name = "txtMuestraPreeliminar";
            this.txtMuestraPreeliminar.Size = new System.Drawing.Size(341, 26);
            this.txtMuestraPreeliminar.TabIndex = 20;
            // 
            // txtIC
            // 
            this.txtIC.Enabled = false;
            this.txtIC.Location = new System.Drawing.Point(300, 100);
            this.txtIC.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtIC.Name = "txtIC";
            this.txtIC.Size = new System.Drawing.Size(341, 26);
            this.txtIC.TabIndex = 19;
            // 
            // txtDesviacion
            // 
            this.txtDesviacion.Enabled = false;
            this.txtDesviacion.Location = new System.Drawing.Point(300, 74);
            this.txtDesviacion.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtDesviacion.Name = "txtDesviacion";
            this.txtDesviacion.Size = new System.Drawing.Size(341, 26);
            this.txtDesviacion.TabIndex = 18;
            // 
            // txtQ
            // 
            this.txtQ.Enabled = false;
            this.txtQ.Location = new System.Drawing.Point(300, 48);
            this.txtQ.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtQ.Name = "txtQ";
            this.txtQ.Size = new System.Drawing.Size(341, 26);
            this.txtQ.TabIndex = 17;
            // 
            // txtP
            // 
            this.txtP.Enabled = false;
            this.txtP.Location = new System.Drawing.Point(300, 22);
            this.txtP.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtP.Name = "txtP";
            this.txtP.Size = new System.Drawing.Size(341, 26);
            this.txtP.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(317, 46);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 18);
            this.label12.TabIndex = 16;
            this.label12.Text = "Intervalo:";
            // 
            // txtZ
            // 
            this.txtZ.Location = new System.Drawing.Point(445, 42);
            this.txtZ.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtZ.Name = "txtZ";
            this.txtZ.Size = new System.Drawing.Size(164, 26);
            this.txtZ.TabIndex = 3;
            // 
            // txtPresicion
            // 
            this.txtPresicion.Location = new System.Drawing.Point(143, 68);
            this.txtPresicion.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtPresicion.Name = "txtPresicion";
            this.txtPresicion.Size = new System.Drawing.Size(164, 26);
            this.txtPresicion.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 75);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(108, 18);
            this.label13.TabIndex = 19;
            this.label13.Text = "Presicion:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(445, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 32);
            this.button1.TabIndex = 20;
            this.button1.Text = "Borrar Todo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MASproporcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(667, 365);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtPresicion);
            this.Controls.Add(this.txtZ);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProporcion);
            this.Controls.Add(this.txtMuestra);
            this.Controls.Add(this.txtPoblacion);
            this.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "MASproporcion";
            this.Text = "Muestreo Aleatorio Simple por proporcion";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPoblacion;
        private System.Windows.Forms.TextBox txtMuestra;
        private System.Windows.Forms.TextBox txtProporcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEstimacion;
        private System.Windows.Forms.TextBox txtIntervaloTotal;
        private System.Windows.Forms.TextBox txtMuestraTotal;
        private System.Windows.Forms.TextBox txtMuestraPreeliminar;
        private System.Windows.Forms.TextBox txtIC;
        private System.Windows.Forms.TextBox txtDesviacion;
        private System.Windows.Forms.TextBox txtQ;
        private System.Windows.Forms.TextBox txtP;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtZ;
        private System.Windows.Forms.TextBox txtPresicion;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button1;
    }
}
namespace Muestreo_Aleatorio
{
    partial class MAS
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
            this.txtValores = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lsbDatos = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtIntervalo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrecicion = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMuestraDefinitiva = new System.Windows.Forms.TextBox();
            this.txtMuestraNecesaria = new System.Windows.Forms.TextBox();
            this.txtICMediaPoblacional = new System.Windows.Forms.TextBox();
            this.txtEstimacion = new System.Windows.Forms.TextBox();
            this.txtICPromedio = new System.Windows.Forms.TextBox();
            this.txtDesviacion = new System.Windows.Forms.TextBox();
            this.txxtVarianzaMediaMuestal = new System.Windows.Forms.TextBox();
            this.txtVarianzaMuestral = new System.Windows.Forms.TextBox();
            this.txtMediaMuestral = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtValores
            // 
            this.txtValores.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.txtValores.Location = new System.Drawing.Point(4, 7);
            this.txtValores.Name = "txtValores";
            this.txtValores.Size = new System.Drawing.Size(100, 26);
            this.txtValores.TabIndex = 0;
            this.txtValores.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValores_KeyPress);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.Location = new System.Drawing.Point(110, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(106, 35);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lsbDatos
            // 
            this.lsbDatos.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.lsbDatos.FormattingEnabled = true;
            this.lsbDatos.ItemHeight = 18;
            this.lsbDatos.Location = new System.Drawing.Point(4, 40);
            this.lsbDatos.Name = "lsbDatos";
            this.lsbDatos.Size = new System.Drawing.Size(100, 328);
            this.lsbDatos.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(622, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 35);
            this.button1.TabIndex = 5;
            this.button1.Text = "&Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtIntervalo
            // 
            this.txtIntervalo.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.txtIntervalo.Location = new System.Drawing.Point(482, 37);
            this.txtIntervalo.Name = "txtIntervalo";
            this.txtIntervalo.Size = new System.Drawing.Size(100, 26);
            this.txtIntervalo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(236, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Intervalo de Confianza:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(236, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Precicion:";
            // 
            // txtPrecicion
            // 
            this.txtPrecicion.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.txtPrecicion.Location = new System.Drawing.Point(482, 63);
            this.txtPrecicion.Name = "txtPrecicion";
            this.txtPrecicion.Size = new System.Drawing.Size(100, 26);
            this.txtPrecicion.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkKhaki;
            this.groupBox1.Controls.Add(this.txtMuestraDefinitiva);
            this.groupBox1.Controls.Add(this.txtMuestraNecesaria);
            this.groupBox1.Controls.Add(this.txtICMediaPoblacional);
            this.groupBox1.Controls.Add(this.txtEstimacion);
            this.groupBox1.Controls.Add(this.txtICPromedio);
            this.groupBox1.Controls.Add(this.txtDesviacion);
            this.groupBox1.Controls.Add(this.txxtVarianzaMediaMuestal);
            this.groupBox1.Controls.Add(this.txtVarianzaMuestral);
            this.groupBox1.Controls.Add(this.txtMediaMuestral);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Enabled = false;
            this.groupBox1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(110, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(834, 262);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resultados";
            // 
            // txtMuestraDefinitiva
            // 
            this.txtMuestraDefinitiva.Enabled = false;
            this.txtMuestraDefinitiva.Location = new System.Drawing.Point(438, 226);
            this.txtMuestraDefinitiva.Name = "txtMuestraDefinitiva";
            this.txtMuestraDefinitiva.Size = new System.Drawing.Size(387, 26);
            this.txtMuestraDefinitiva.TabIndex = 21;
            // 
            // txtMuestraNecesaria
            // 
            this.txtMuestraNecesaria.Enabled = false;
            this.txtMuestraNecesaria.Location = new System.Drawing.Point(438, 200);
            this.txtMuestraNecesaria.Name = "txtMuestraNecesaria";
            this.txtMuestraNecesaria.Size = new System.Drawing.Size(387, 26);
            this.txtMuestraNecesaria.TabIndex = 20;
            // 
            // txtICMediaPoblacional
            // 
            this.txtICMediaPoblacional.Enabled = false;
            this.txtICMediaPoblacional.Location = new System.Drawing.Point(438, 174);
            this.txtICMediaPoblacional.Name = "txtICMediaPoblacional";
            this.txtICMediaPoblacional.Size = new System.Drawing.Size(387, 26);
            this.txtICMediaPoblacional.TabIndex = 19;
            // 
            // txtEstimacion
            // 
            this.txtEstimacion.Enabled = false;
            this.txtEstimacion.Location = new System.Drawing.Point(438, 148);
            this.txtEstimacion.Name = "txtEstimacion";
            this.txtEstimacion.Size = new System.Drawing.Size(387, 26);
            this.txtEstimacion.TabIndex = 18;
            // 
            // txtICPromedio
            // 
            this.txtICPromedio.Enabled = false;
            this.txtICPromedio.Location = new System.Drawing.Point(438, 122);
            this.txtICPromedio.Name = "txtICPromedio";
            this.txtICPromedio.Size = new System.Drawing.Size(387, 26);
            this.txtICPromedio.TabIndex = 17;
            // 
            // txtDesviacion
            // 
            this.txtDesviacion.Enabled = false;
            this.txtDesviacion.Location = new System.Drawing.Point(438, 96);
            this.txtDesviacion.Name = "txtDesviacion";
            this.txtDesviacion.Size = new System.Drawing.Size(387, 26);
            this.txtDesviacion.TabIndex = 16;
            // 
            // txxtVarianzaMediaMuestal
            // 
            this.txxtVarianzaMediaMuestal.Enabled = false;
            this.txxtVarianzaMediaMuestal.Location = new System.Drawing.Point(438, 70);
            this.txxtVarianzaMediaMuestal.Name = "txxtVarianzaMediaMuestal";
            this.txxtVarianzaMediaMuestal.Size = new System.Drawing.Size(387, 26);
            this.txxtVarianzaMediaMuestal.TabIndex = 15;
            // 
            // txtVarianzaMuestral
            // 
            this.txtVarianzaMuestral.Enabled = false;
            this.txtVarianzaMuestral.Location = new System.Drawing.Point(438, 44);
            this.txtVarianzaMuestral.Name = "txtVarianzaMuestral";
            this.txtVarianzaMuestral.Size = new System.Drawing.Size(387, 26);
            this.txtVarianzaMuestral.TabIndex = 14;
            // 
            // txtMediaMuestral
            // 
            this.txtMediaMuestral.Enabled = false;
            this.txtMediaMuestral.Location = new System.Drawing.Point(438, 18);
            this.txtMediaMuestral.Name = "txtMediaMuestral";
            this.txtMediaMuestral.Size = new System.Drawing.Size(387, 26);
            this.txtMediaMuestral.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 234);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(198, 18);
            this.label11.TabIndex = 12;
            this.label11.Text = "Muestra Definitiva:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 208);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(188, 18);
            this.label10.TabIndex = 11;
            this.label10.Text = "Muestra Necesaria:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 182);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(298, 18);
            this.label9.TabIndex = 10;
            this.label9.Text = "I.C. de la Media Poblacional:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(428, 18);
            this.label8.TabIndex = 9;
            this.label8.Text = "Estimacion Puntual de la Mdia Poblacional:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(328, 18);
            this.label7.TabIndex = 8;
            this.label7.Text = "I.C. del Promedio de la Muestra:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(388, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "Desviacion Estandar de Media Muestral:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(288, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Varianza de Media Muestral: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Varianza Muestral:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Media muestral:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Enabled = false;
            this.label12.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(236, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(198, 18);
            this.label12.TabIndex = 9;
            this.label12.Text = "Total de Poblacion:";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.txtTotal.Location = new System.Drawing.Point(482, 11);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 26);
            this.txtTotal.TabIndex = 2;
            this.txtTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotal_KeyPress);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(622, 45);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 49);
            this.button2.TabIndex = 21;
            this.button2.Text = "Borrar Todo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(947, 377);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtPrecicion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIntervalo);
            this.Controls.Add(this.lsbDatos);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtValores);
            this.Controls.Add(this.button1);
            this.Name = "MAS";
            this.Text = "Muestreo Aleatorio Simple";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValores;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListBox lsbDatos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtIntervalo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrecicion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMuestraDefinitiva;
        private System.Windows.Forms.TextBox txtMuestraNecesaria;
        private System.Windows.Forms.TextBox txtICMediaPoblacional;
        private System.Windows.Forms.TextBox txtEstimacion;
        private System.Windows.Forms.TextBox txtICPromedio;
        private System.Windows.Forms.TextBox txtDesviacion;
        private System.Windows.Forms.TextBox txxtVarianzaMediaMuestal;
        private System.Windows.Forms.TextBox txtVarianzaMuestral;
        private System.Windows.Forms.TextBox txtMediaMuestral;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button button2;
    }
}
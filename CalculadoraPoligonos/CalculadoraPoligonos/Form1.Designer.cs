namespace CalculadoraPoligonos
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
            this.btnPerimetro = new System.Windows.Forms.Button();
            this.btnArea = new System.Windows.Forms.Button();
            this.tabCalculadora = new System.Windows.Forms.TabControl();
            this.tabTriangulo = new System.Windows.Forms.TabPage();
            this.tabCuadrado = new System.Windows.Forms.TabPage();
            this.tabCirculo = new System.Windows.Forms.TabPage();
            this.tabRectangulo = new System.Windows.Forms.TabPage();
            this.tabPentagono = new System.Windows.Forms.TabPage();
            this.lblCalculadora = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabCalculadora.SuspendLayout();
            this.tabTriangulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPerimetro
            // 
            this.btnPerimetro.Location = new System.Drawing.Point(366, 399);
            this.btnPerimetro.Name = "btnPerimetro";
            this.btnPerimetro.Size = new System.Drawing.Size(174, 27);
            this.btnPerimetro.TabIndex = 0;
            this.btnPerimetro.Text = "Calcular Perimetro";
            this.btnPerimetro.UseVisualStyleBackColor = true;
            this.btnPerimetro.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnArea
            // 
            this.btnArea.Location = new System.Drawing.Point(556, 399);
            this.btnArea.Name = "btnArea";
            this.btnArea.Size = new System.Drawing.Size(166, 27);
            this.btnArea.TabIndex = 1;
            this.btnArea.Text = "Calcular Area";
            this.btnArea.UseVisualStyleBackColor = true;
            // 
            // tabCalculadora
            // 
            this.tabCalculadora.Controls.Add(this.tabTriangulo);
            this.tabCalculadora.Controls.Add(this.tabCuadrado);
            this.tabCalculadora.Controls.Add(this.tabCirculo);
            this.tabCalculadora.Controls.Add(this.tabRectangulo);
            this.tabCalculadora.Controls.Add(this.tabPentagono);
            this.tabCalculadora.Location = new System.Drawing.Point(77, 57);
            this.tabCalculadora.Name = "tabCalculadora";
            this.tabCalculadora.SelectedIndex = 0;
            this.tabCalculadora.Size = new System.Drawing.Size(649, 336);
            this.tabCalculadora.TabIndex = 5;
            // 
            // tabTriangulo
            // 
            this.tabTriangulo.Controls.Add(this.label5);
            this.tabTriangulo.Controls.Add(this.label4);
            this.tabTriangulo.Controls.Add(this.label3);
            this.tabTriangulo.Controls.Add(this.label2);
            this.tabTriangulo.Controls.Add(this.label1);
            this.tabTriangulo.Location = new System.Drawing.Point(4, 25);
            this.tabTriangulo.Name = "tabTriangulo";
            this.tabTriangulo.Padding = new System.Windows.Forms.Padding(3);
            this.tabTriangulo.Size = new System.Drawing.Size(641, 307);
            this.tabTriangulo.TabIndex = 0;
            this.tabTriangulo.Text = "Triangulo";
            this.tabTriangulo.UseVisualStyleBackColor = true;
            this.tabTriangulo.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabCuadrado
            // 
            this.tabCuadrado.Location = new System.Drawing.Point(4, 25);
            this.tabCuadrado.Name = "tabCuadrado";
            this.tabCuadrado.Padding = new System.Windows.Forms.Padding(3);
            this.tabCuadrado.Size = new System.Drawing.Size(641, 307);
            this.tabCuadrado.TabIndex = 1;
            this.tabCuadrado.Text = "Cuadrado";
            this.tabCuadrado.UseVisualStyleBackColor = true;
            // 
            // tabCirculo
            // 
            this.tabCirculo.Location = new System.Drawing.Point(4, 25);
            this.tabCirculo.Name = "tabCirculo";
            this.tabCirculo.Size = new System.Drawing.Size(641, 307);
            this.tabCirculo.TabIndex = 2;
            this.tabCirculo.Text = "Circulo";
            this.tabCirculo.UseVisualStyleBackColor = true;
            // 
            // tabRectangulo
            // 
            this.tabRectangulo.Location = new System.Drawing.Point(4, 25);
            this.tabRectangulo.Name = "tabRectangulo";
            this.tabRectangulo.Size = new System.Drawing.Size(641, 307);
            this.tabRectangulo.TabIndex = 3;
            this.tabRectangulo.Text = "Rectangulo";
            this.tabRectangulo.UseVisualStyleBackColor = true;
            // 
            // tabPentagono
            // 
            this.tabPentagono.Location = new System.Drawing.Point(4, 25);
            this.tabPentagono.Name = "tabPentagono";
            this.tabPentagono.Size = new System.Drawing.Size(641, 307);
            this.tabPentagono.TabIndex = 4;
            this.tabPentagono.Text = "Pentagono";
            this.tabPentagono.UseVisualStyleBackColor = true;
            // 
            // lblCalculadora
            // 
            this.lblCalculadora.AutoSize = true;
            this.lblCalculadora.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalculadora.Location = new System.Drawing.Point(269, 9);
            this.lblCalculadora.Name = "lblCalculadora";
            this.lblCalculadora.Size = new System.Drawing.Size(291, 29);
            this.lblCalculadora.TabIndex = 3;
            this.lblCalculadora.Tag = "";
            this.lblCalculadora.Text = "Calculadora de Poligonos";
            this.lblCalculadora.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "label5";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCalculadora);
            this.Controls.Add(this.tabCalculadora);
            this.Controls.Add(this.btnArea);
            this.Controls.Add(this.btnPerimetro);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabCalculadora.ResumeLayout(false);
            this.tabTriangulo.ResumeLayout(false);
            this.tabTriangulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPerimetro;
        private System.Windows.Forms.Button btnArea;
        private System.Windows.Forms.TabControl tabCalculadora;
        private System.Windows.Forms.TabPage tabTriangulo;
        private System.Windows.Forms.TabPage tabCuadrado;
        private System.Windows.Forms.Label lblCalculadora;
        private System.Windows.Forms.TabPage tabCirculo;
        private System.Windows.Forms.TabPage tabRectangulo;
        private System.Windows.Forms.TabPage tabPentagono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}


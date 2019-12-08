namespace CalculadoraPoligonos
{
    partial class CalculadoraForm
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
            this.TrianguloAlturaTextBox = new System.Windows.Forms.TextBox();
            this.TrianguloBaseTextBox = new System.Windows.Forms.TextBox();
            this.TrianguloLado3TextBox = new System.Windows.Forms.TextBox();
            this.TrianguloLado2TextBox = new System.Windows.Forms.TextBox();
            this.TrianguloLado1TextBox = new System.Windows.Forms.TextBox();
            this.lblAlturaTriangulo = new System.Windows.Forms.Label();
            this.lblBaseTriangulo = new System.Windows.Forms.Label();
            this.lblLado3 = new System.Windows.Forms.Label();
            this.lblLado2 = new System.Windows.Forms.Label();
            this.lblLado1 = new System.Windows.Forms.Label();
            this.tabCuadrado = new System.Windows.Forms.TabPage();
            this.CuadradoLadoTextBox = new System.Windows.Forms.TextBox();
            this.labLado = new System.Windows.Forms.Label();
            this.tabCirculo = new System.Windows.Forms.TabPage();
            this.CirculoRadioTextBox = new System.Windows.Forms.TextBox();
            this.lblRadio = new System.Windows.Forms.Label();
            this.tabRectangulo = new System.Windows.Forms.TabPage();
            this.lblAlturaRectangulo = new System.Windows.Forms.Label();
            this.lblBaseRectangulo = new System.Windows.Forms.Label();
            this.RectanguloAlturaTextBox = new System.Windows.Forms.TextBox();
            this.RectanguloBaseTextBox = new System.Windows.Forms.TextBox();
            this.tabPentagono = new System.Windows.Forms.TabPage();
            this.PentagonoApotemaTextBox = new System.Windows.Forms.TextBox();
            this.PentagonoLadoTextBox = new System.Windows.Forms.TextBox();
            this.lblApotemaPentagono = new System.Windows.Forms.Label();
            this.lblLadoPentagono = new System.Windows.Forms.Label();
            this.lblCalculadora = new System.Windows.Forms.Label();
            this.lblNombreTab = new System.Windows.Forms.Label();
            this.tabCalculadora.SuspendLayout();
            this.tabTriangulo.SuspendLayout();
            this.tabCuadrado.SuspendLayout();
            this.tabCirculo.SuspendLayout();
            this.tabRectangulo.SuspendLayout();
            this.tabPentagono.SuspendLayout();
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
            this.btnPerimetro.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnPerimetro_MouseClick);
            // 
            // btnArea
            // 
            this.btnArea.Location = new System.Drawing.Point(556, 399);
            this.btnArea.Name = "btnArea";
            this.btnArea.Size = new System.Drawing.Size(166, 27);
            this.btnArea.TabIndex = 1;
            this.btnArea.Text = "Calcular Area";
            this.btnArea.UseVisualStyleBackColor = true;
            this.btnArea.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnArea_MouseClick);
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
            this.tabCalculadora.SelectedIndexChanged += new System.EventHandler(this.tabCalculadora_SelectedIndexChanged);
            // 
            // tabTriangulo
            // 
            this.tabTriangulo.Controls.Add(this.TrianguloAlturaTextBox);
            this.tabTriangulo.Controls.Add(this.TrianguloBaseTextBox);
            this.tabTriangulo.Controls.Add(this.TrianguloLado3TextBox);
            this.tabTriangulo.Controls.Add(this.TrianguloLado2TextBox);
            this.tabTriangulo.Controls.Add(this.TrianguloLado1TextBox);
            this.tabTriangulo.Controls.Add(this.lblAlturaTriangulo);
            this.tabTriangulo.Controls.Add(this.lblBaseTriangulo);
            this.tabTriangulo.Controls.Add(this.lblLado3);
            this.tabTriangulo.Controls.Add(this.lblLado2);
            this.tabTriangulo.Controls.Add(this.lblLado1);
            this.tabTriangulo.Location = new System.Drawing.Point(4, 25);
            this.tabTriangulo.Name = "tabTriangulo";
            this.tabTriangulo.Padding = new System.Windows.Forms.Padding(3);
            this.tabTriangulo.Size = new System.Drawing.Size(641, 307);
            this.tabTriangulo.TabIndex = 0;
            this.tabTriangulo.Text = "Triangulo";
            this.tabTriangulo.UseVisualStyleBackColor = true;
            this.tabTriangulo.Click += new System.EventHandler(this.tabTriangulo_Click);
            // 
            // TrianguloAlturaTextBox
            // 
            this.TrianguloAlturaTextBox.Location = new System.Drawing.Point(118, 227);
            this.TrianguloAlturaTextBox.Name = "TrianguloAlturaTextBox";
            this.TrianguloAlturaTextBox.Size = new System.Drawing.Size(139, 22);
            this.TrianguloAlturaTextBox.TabIndex = 9;
            this.TrianguloAlturaTextBox.Leave += new System.EventHandler(this.TrianguloAlturaTextBox_Leave);
            // 
            // TrianguloBaseTextBox
            // 
            this.TrianguloBaseTextBox.Location = new System.Drawing.Point(118, 181);
            this.TrianguloBaseTextBox.Name = "TrianguloBaseTextBox";
            this.TrianguloBaseTextBox.Size = new System.Drawing.Size(139, 22);
            this.TrianguloBaseTextBox.TabIndex = 8;
            this.TrianguloBaseTextBox.Leave += new System.EventHandler(this.TrianguloBaseTextBox_Leave);
            // 
            // TrianguloLado3TextBox
            // 
            this.TrianguloLado3TextBox.Location = new System.Drawing.Point(118, 128);
            this.TrianguloLado3TextBox.Name = "TrianguloLado3TextBox";
            this.TrianguloLado3TextBox.Size = new System.Drawing.Size(139, 22);
            this.TrianguloLado3TextBox.TabIndex = 7;
            this.TrianguloLado3TextBox.Leave += new System.EventHandler(this.TrianguloLado3TextBox_Leave);
            // 
            // TrianguloLado2TextBox
            // 
            this.TrianguloLado2TextBox.Location = new System.Drawing.Point(118, 81);
            this.TrianguloLado2TextBox.Name = "TrianguloLado2TextBox";
            this.TrianguloLado2TextBox.Size = new System.Drawing.Size(139, 22);
            this.TrianguloLado2TextBox.TabIndex = 6;
            this.TrianguloLado2TextBox.Leave += new System.EventHandler(this.TrianguloLado2TextBox_Leave);
            // 
            // TrianguloLado1TextBox
            // 
            this.TrianguloLado1TextBox.Location = new System.Drawing.Point(118, 32);
            this.TrianguloLado1TextBox.Name = "TrianguloLado1TextBox";
            this.TrianguloLado1TextBox.Size = new System.Drawing.Size(139, 22);
            this.TrianguloLado1TextBox.TabIndex = 5;
            this.TrianguloLado1TextBox.Leave += new System.EventHandler(this.TrianguloLado1TextBox_Leave);
            // 
            // lblAlturaTriangulo
            // 
            this.lblAlturaTriangulo.AutoSize = true;
            this.lblAlturaTriangulo.Location = new System.Drawing.Point(47, 230);
            this.lblAlturaTriangulo.Name = "lblAlturaTriangulo";
            this.lblAlturaTriangulo.Size = new System.Drawing.Size(45, 17);
            this.lblAlturaTriangulo.TabIndex = 4;
            this.lblAlturaTriangulo.Text = "Altura";
            // 
            // lblBaseTriangulo
            // 
            this.lblBaseTriangulo.AutoSize = true;
            this.lblBaseTriangulo.Location = new System.Drawing.Point(47, 184);
            this.lblBaseTriangulo.Name = "lblBaseTriangulo";
            this.lblBaseTriangulo.Size = new System.Drawing.Size(40, 17);
            this.lblBaseTriangulo.TabIndex = 3;
            this.lblBaseTriangulo.Text = "Base";
            // 
            // lblLado3
            // 
            this.lblLado3.AutoSize = true;
            this.lblLado3.Location = new System.Drawing.Point(47, 133);
            this.lblLado3.Name = "lblLado3";
            this.lblLado3.Size = new System.Drawing.Size(52, 17);
            this.lblLado3.TabIndex = 2;
            this.lblLado3.Text = "Lado 3";
            // 
            // lblLado2
            // 
            this.lblLado2.AutoSize = true;
            this.lblLado2.Location = new System.Drawing.Point(47, 81);
            this.lblLado2.Name = "lblLado2";
            this.lblLado2.Size = new System.Drawing.Size(52, 17);
            this.lblLado2.TabIndex = 1;
            this.lblLado2.Text = "Lado 2";
            // 
            // lblLado1
            // 
            this.lblLado1.AutoSize = true;
            this.lblLado1.Location = new System.Drawing.Point(47, 35);
            this.lblLado1.Name = "lblLado1";
            this.lblLado1.Size = new System.Drawing.Size(52, 17);
            this.lblLado1.TabIndex = 0;
            this.lblLado1.Text = "Lado 1";
            // 
            // tabCuadrado
            // 
            this.tabCuadrado.Controls.Add(this.CuadradoLadoTextBox);
            this.tabCuadrado.Controls.Add(this.labLado);
            this.tabCuadrado.Location = new System.Drawing.Point(4, 25);
            this.tabCuadrado.Name = "tabCuadrado";
            this.tabCuadrado.Padding = new System.Windows.Forms.Padding(3);
            this.tabCuadrado.Size = new System.Drawing.Size(641, 307);
            this.tabCuadrado.TabIndex = 1;
            this.tabCuadrado.Text = "Cuadrado";
            this.tabCuadrado.UseVisualStyleBackColor = true;
            // 
            // CuadradoLadoTextBox
            // 
            this.CuadradoLadoTextBox.Location = new System.Drawing.Point(148, 54);
            this.CuadradoLadoTextBox.Name = "CuadradoLadoTextBox";
            this.CuadradoLadoTextBox.Size = new System.Drawing.Size(128, 22);
            this.CuadradoLadoTextBox.TabIndex = 1;
            this.CuadradoLadoTextBox.Leave += new System.EventHandler(this.CuadradoLadoTextBox_Leave);
            // 
            // labLado
            // 
            this.labLado.AutoSize = true;
            this.labLado.Location = new System.Drawing.Point(68, 54);
            this.labLado.Name = "labLado";
            this.labLado.Size = new System.Drawing.Size(40, 17);
            this.labLado.TabIndex = 0;
            this.labLado.Text = "Lado";
            // 
            // tabCirculo
            // 
            this.tabCirculo.Controls.Add(this.CirculoRadioTextBox);
            this.tabCirculo.Controls.Add(this.lblRadio);
            this.tabCirculo.Location = new System.Drawing.Point(4, 25);
            this.tabCirculo.Name = "tabCirculo";
            this.tabCirculo.Size = new System.Drawing.Size(641, 307);
            this.tabCirculo.TabIndex = 2;
            this.tabCirculo.Text = "Circulo";
            this.tabCirculo.UseVisualStyleBackColor = true;
            // 
            // CirculoRadioTextBox
            // 
            this.CirculoRadioTextBox.Location = new System.Drawing.Point(126, 37);
            this.CirculoRadioTextBox.Name = "CirculoRadioTextBox";
            this.CirculoRadioTextBox.Size = new System.Drawing.Size(133, 22);
            this.CirculoRadioTextBox.TabIndex = 1;
            this.CirculoRadioTextBox.Leave += new System.EventHandler(this.CirculoRadioTextBox_Leave);
            // 
            // lblRadio
            // 
            this.lblRadio.AutoSize = true;
            this.lblRadio.Location = new System.Drawing.Point(59, 37);
            this.lblRadio.Name = "lblRadio";
            this.lblRadio.Size = new System.Drawing.Size(45, 17);
            this.lblRadio.TabIndex = 0;
            this.lblRadio.Text = "Radio";
            // 
            // tabRectangulo
            // 
            this.tabRectangulo.Controls.Add(this.lblAlturaRectangulo);
            this.tabRectangulo.Controls.Add(this.lblBaseRectangulo);
            this.tabRectangulo.Controls.Add(this.RectanguloAlturaTextBox);
            this.tabRectangulo.Controls.Add(this.RectanguloBaseTextBox);
            this.tabRectangulo.Location = new System.Drawing.Point(4, 25);
            this.tabRectangulo.Name = "tabRectangulo";
            this.tabRectangulo.Size = new System.Drawing.Size(641, 307);
            this.tabRectangulo.TabIndex = 3;
            this.tabRectangulo.Text = "Rectangulo";
            this.tabRectangulo.UseVisualStyleBackColor = true;
            // 
            // lblAlturaRectangulo
            // 
            this.lblAlturaRectangulo.AutoSize = true;
            this.lblAlturaRectangulo.Location = new System.Drawing.Point(98, 110);
            this.lblAlturaRectangulo.Name = "lblAlturaRectangulo";
            this.lblAlturaRectangulo.Size = new System.Drawing.Size(45, 17);
            this.lblAlturaRectangulo.TabIndex = 3;
            this.lblAlturaRectangulo.Text = "Altura";
            // 
            // lblBaseRectangulo
            // 
            this.lblBaseRectangulo.AutoSize = true;
            this.lblBaseRectangulo.Location = new System.Drawing.Point(98, 55);
            this.lblBaseRectangulo.Name = "lblBaseRectangulo";
            this.lblBaseRectangulo.Size = new System.Drawing.Size(40, 17);
            this.lblBaseRectangulo.TabIndex = 2;
            this.lblBaseRectangulo.Text = "Base";
            // 
            // RectanguloAlturaTextBox
            // 
            this.RectanguloAlturaTextBox.Location = new System.Drawing.Point(167, 110);
            this.RectanguloAlturaTextBox.Name = "RectanguloAlturaTextBox";
            this.RectanguloAlturaTextBox.Size = new System.Drawing.Size(100, 22);
            this.RectanguloAlturaTextBox.TabIndex = 1;
            this.RectanguloAlturaTextBox.Leave += new System.EventHandler(this.RectanguloAlturaTextBox_Leave);
            // 
            // RectanguloBaseTextBox
            // 
            this.RectanguloBaseTextBox.Location = new System.Drawing.Point(167, 55);
            this.RectanguloBaseTextBox.Name = "RectanguloBaseTextBox";
            this.RectanguloBaseTextBox.Size = new System.Drawing.Size(100, 22);
            this.RectanguloBaseTextBox.TabIndex = 0;
            this.RectanguloBaseTextBox.Leave += new System.EventHandler(this.RectanguloBaseTextBox_Leave);
            // 
            // tabPentagono
            // 
            this.tabPentagono.Controls.Add(this.PentagonoApotemaTextBox);
            this.tabPentagono.Controls.Add(this.PentagonoLadoTextBox);
            this.tabPentagono.Controls.Add(this.lblApotemaPentagono);
            this.tabPentagono.Controls.Add(this.lblLadoPentagono);
            this.tabPentagono.Location = new System.Drawing.Point(4, 25);
            this.tabPentagono.Name = "tabPentagono";
            this.tabPentagono.Size = new System.Drawing.Size(641, 307);
            this.tabPentagono.TabIndex = 4;
            this.tabPentagono.Text = "Pentagono";
            this.tabPentagono.UseVisualStyleBackColor = true;
            // 
            // PentagonoApotemaTextBox
            // 
            this.PentagonoApotemaTextBox.Location = new System.Drawing.Point(166, 106);
            this.PentagonoApotemaTextBox.Name = "PentagonoApotemaTextBox";
            this.PentagonoApotemaTextBox.Size = new System.Drawing.Size(100, 22);
            this.PentagonoApotemaTextBox.TabIndex = 3;
            // 
            // PentagonoLadoTextBox
            // 
            this.PentagonoLadoTextBox.Location = new System.Drawing.Point(166, 51);
            this.PentagonoLadoTextBox.Name = "PentagonoLadoTextBox";
            this.PentagonoLadoTextBox.Size = new System.Drawing.Size(100, 22);
            this.PentagonoLadoTextBox.TabIndex = 2;
            this.PentagonoLadoTextBox.Leave += new System.EventHandler(this.PentagonoLadoTextBox_Leave);
            // 
            // lblApotemaPentagono
            // 
            this.lblApotemaPentagono.AutoSize = true;
            this.lblApotemaPentagono.Location = new System.Drawing.Point(73, 111);
            this.lblApotemaPentagono.Name = "lblApotemaPentagono";
            this.lblApotemaPentagono.Size = new System.Drawing.Size(64, 17);
            this.lblApotemaPentagono.TabIndex = 1;
            this.lblApotemaPentagono.Text = "Apotema";
            // 
            // lblLadoPentagono
            // 
            this.lblLadoPentagono.AutoSize = true;
            this.lblLadoPentagono.Location = new System.Drawing.Point(73, 51);
            this.lblLadoPentagono.Name = "lblLadoPentagono";
            this.lblLadoPentagono.Size = new System.Drawing.Size(40, 17);
            this.lblLadoPentagono.TabIndex = 0;
            this.lblLadoPentagono.Text = "Lado";
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
            // 
            // lblNombreTab
            // 
            this.lblNombreTab.AutoSize = true;
            this.lblNombreTab.Location = new System.Drawing.Point(81, 408);
            this.lblNombreTab.Name = "lblNombreTab";
            this.lblNombreTab.Size = new System.Drawing.Size(0, 17);
            this.lblNombreTab.TabIndex = 6;
            // 
            // CalculadoraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNombreTab);
            this.Controls.Add(this.lblCalculadora);
            this.Controls.Add(this.tabCalculadora);
            this.Controls.Add(this.btnArea);
            this.Controls.Add(this.btnPerimetro);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Name = "CalculadoraForm";
            this.Text = "Calculadora de Poligonos";
            this.tabCalculadora.ResumeLayout(false);
            this.tabTriangulo.ResumeLayout(false);
            this.tabTriangulo.PerformLayout();
            this.tabCuadrado.ResumeLayout(false);
            this.tabCuadrado.PerformLayout();
            this.tabCirculo.ResumeLayout(false);
            this.tabCirculo.PerformLayout();
            this.tabRectangulo.ResumeLayout(false);
            this.tabRectangulo.PerformLayout();
            this.tabPentagono.ResumeLayout(false);
            this.tabPentagono.PerformLayout();
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
        private System.Windows.Forms.Label lblAlturaTriangulo;
        private System.Windows.Forms.Label lblBaseTriangulo;
        private System.Windows.Forms.Label lblLado3;
        private System.Windows.Forms.Label lblLado2;
        private System.Windows.Forms.Label lblLado1;
        private System.Windows.Forms.TextBox TrianguloAlturaTextBox;
        private System.Windows.Forms.TextBox TrianguloBaseTextBox;
        private System.Windows.Forms.TextBox TrianguloLado3TextBox;
        private System.Windows.Forms.TextBox TrianguloLado2TextBox;
        private System.Windows.Forms.TextBox TrianguloLado1TextBox;
        private System.Windows.Forms.Label labLado;
        private System.Windows.Forms.TextBox CuadradoLadoTextBox;
        private System.Windows.Forms.TextBox CirculoRadioTextBox;
        private System.Windows.Forms.Label lblRadio;
        private System.Windows.Forms.Label lblBaseRectangulo;
        private System.Windows.Forms.TextBox RectanguloAlturaTextBox;
        private System.Windows.Forms.TextBox RectanguloBaseTextBox;
        private System.Windows.Forms.Label lblAlturaRectangulo;
        private System.Windows.Forms.TextBox PentagonoApotemaTextBox;
        private System.Windows.Forms.TextBox PentagonoLadoTextBox;
        private System.Windows.Forms.Label lblApotemaPentagono;
        private System.Windows.Forms.Label lblLadoPentagono;
        private System.Windows.Forms.Label lblNombreTab;
    }
}


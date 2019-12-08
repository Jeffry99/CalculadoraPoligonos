using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UNA.Poligonos;

namespace CalculadoraPoligonos
{
    public partial class CalculadoraForm : Form
    {
        private Poligono poligonoSeleccionado = new Triangulo();
        public CalculadoraForm()
        {
            InitializeComponent();

        }

        private void tabTriangulo_Click(object sender, EventArgs e)
        {

        }

        private void tabCalculadora_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabCalculadora.SelectedIndex == 0)
            {
                poligonoSeleccionado = new Triangulo();
            }
            else
            {
                if (tabCalculadora.SelectedIndex == 1)
                {
                    poligonoSeleccionado = new Cuadrado();
                }
                else
                {
                    if (tabCalculadora.SelectedIndex == 2)
                    {
                        poligonoSeleccionado = new Circulo();
                    }
                    else
                    {
                        if (tabCalculadora.SelectedIndex == 3)
                        {
                            poligonoSeleccionado = new Rectangulo();
                        }
                        else
                        {
                            if (tabCalculadora.SelectedIndex == 4)
                            {
                                poligonoSeleccionado = new Pentagono();
                            }
                        }
                        
                    }
                    
                }
                
            }
            
        }


        private void TrianguloBaseTextBox_Leave(object sender, EventArgs e)
        {
            Triangulo triangulo = (Triangulo)poligonoSeleccionado;
            triangulo.Base = Convert.ToDouble(TrianguloBaseTextBox.Text);
        }

        private void TrianguloAlturaTextBox_Leave(object sender, EventArgs e)
        {
            Triangulo triangulo = (Triangulo)poligonoSeleccionado;
            triangulo.Altura = Convert.ToDouble(TrianguloAlturaTextBox.Text);
        }

        private void TrianguloLado1TextBox_Leave(object sender, EventArgs e)
        {
            Triangulo triangulo = (Triangulo)poligonoSeleccionado;
            triangulo.Lado1 = Convert.ToDouble(TrianguloLado1TextBox.Text);
        }

        private void TrianguloLado2TextBox_Leave(object sender, EventArgs e)
        {
            Triangulo triangulo = (Triangulo)poligonoSeleccionado;
            triangulo.Lado2 = Convert.ToDouble(TrianguloLado2TextBox.Text);
        }

        private void TrianguloLado3TextBox_Leave(object sender, EventArgs e)
        {
            Triangulo triangulo = (Triangulo)poligonoSeleccionado;
            triangulo.Lado3 = Convert.ToDouble(TrianguloLado3TextBox.Text);
        }

        private void btnPerimetro_MouseClick(object sender, MouseEventArgs e)
        {
            
            MessageBox.Show("El perimetro es: "+ poligonoSeleccionado.CalcularPerimetro().ToString(), "Resultado");
        }

        private void CuadradoLadoTextBox_Leave(object sender, EventArgs e)
        {
            Cuadrado cuadrado = (Cuadrado)poligonoSeleccionado;
            cuadrado.Lado = Convert.ToDouble(CuadradoLadoTextBox.Text);
        }

        private void CirculoRadioTextBox_Leave(object sender, EventArgs e)
        {
            Circulo circulo = (Circulo)poligonoSeleccionado;
            circulo.Radio = Convert.ToDouble(CirculoRadioTextBox.Text);
        }

        private void RectanguloBaseTextBox_Leave(object sender, EventArgs e)
        {
            Rectangulo rectangulo = (Rectangulo)poligonoSeleccionado;
            rectangulo.Base = Convert.ToDouble(RectanguloBaseTextBox.Text);
        }

        private void RectanguloAlturaTextBox_Leave(object sender, EventArgs e)
        {
            Rectangulo rectangulo = (Rectangulo)poligonoSeleccionado;
            rectangulo.Altura = Convert.ToDouble(RectanguloAlturaTextBox.Text);
        }

        private void PentagonoApotemaTextBox_Leave(object sender, EventArgs e)
        {
            Pentagono pentagono = (Pentagono)poligonoSeleccionado;
            pentagono.Apotema = Convert.ToDouble(PentagonoApotemaTextBox.Text);
        }
        private void PentagonoLadoTextBox_Leave(object sender, EventArgs e)
        {
            Pentagono pentagono = (Pentagono)poligonoSeleccionado;
            pentagono.Lado = Convert.ToDouble(PentagonoLadoTextBox.Text);
        }

        private void btnArea_MouseClick(object sender, MouseEventArgs e)
        {

            MessageBox.Show("El area es: " + poligonoSeleccionado.CalcularArea().ToString(), "Resultado");
        }
    }
}

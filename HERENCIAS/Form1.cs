using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HERENCIA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioRect_CheckedChanged(object sender, EventArgs e)
        {
            Rectangulo rectangulo = new Rectangulo(3, 5);  
            
        }
        private void radioTri_CheckedChanged(object sender, EventArgs e)
        {
            Triangulo triangulo = new Triangulo(2, 2, 2);
        }
        private void radioCirculo_CheckedChanged(object sender, EventArgs e)
        {
            Circulo circulo = new Circulo(5);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (this.radioTri.Checked)
            {
                Triangulo triangulo = new Triangulo(2, 2, 2);
                this.textArea.Text = triangulo.AreaTriste().ToString();
            }
            else if (this.radioRect.Checked)
            {
                Rectangulo rectangulo = new Rectangulo(3, 5);
                this.textArea.Text = rectangulo.AreaTriste().ToString();
            }
            else if (this.radioCirculo.Checked)
            {
                Circulo circulo = new Circulo(5);
                this.textArea.Text = circulo.AreaTriste().ToString();
            }
        }        
    }
}

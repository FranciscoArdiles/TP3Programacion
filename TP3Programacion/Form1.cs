using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP3Programacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {

            
            for (int i = 0; i < 600; i++)
            {
                
                lblCargando.Visible = true;
                lblPunto.Visible = true;
                lblPunto.Left = i;
                this.Refresh();
                lblPunto.Visible = false;
                lblCargando.Visible = false;
            }
            
            
            decimal nota1 = System.Convert.ToDecimal(numPriN.Value);
            decimal nota2 = System.Convert.ToDecimal(numSegN.Value);
            decimal nota3 = System.Convert.ToDecimal(numTerN.Value);

            decimal promedio = (nota1 + nota2 + nota3) / 3;
            promedio = Math.Round(promedio, 2);

            if (nota1 == 0 & nota2 == 0 & nota3 == 0)  
            {
                lblerror.Visible = true;
                lblResultado.Visible = false;
            }
            else
            {
                lblResultado.Text = "Resultado:";
                lblerror.Visible = false;
                lblResultado.Visible = true;
                lblResultado.Text = lblResultado.Text + System.Convert.ToString(promedio);
            }

        }
    }
    }


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_I02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (txbKilometros is null || txbLitros is null)
                {
                    throw new ParametrosVaciosException();
                }
                else
                {
                    int kilometros = int.Parse(txbKilometros.Text);
                    int litros = int.Parse(txbLitros.Text);

                    rtbResultado.Text = $"Kms/lts: {Calculador.Calcular(kilometros, litros)}";
                }
            }
            catch(ParametrosVaciosException)
            {
                MessageBox.Show("Los parámetros están vacíos");
            }
            catch (FormatException)
            {
                MessageBox.Show("Esos no son números");
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("No se puede dividir por 0");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}

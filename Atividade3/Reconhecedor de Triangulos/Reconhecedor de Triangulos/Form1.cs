using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reconhecedor_de_Triangulos
{
    public partial class ReconhecedordeTriangulos : Form
    {
        bool verificacaoOk = true;
        private bool verificacao(TextBox actual)
        {
            double verify1;

            if ((actual.Text == string.Empty) || (!double.TryParse(actual.Text, out verify1)))
            {
                actual.Clear();
                verificacaoOk = false;
                return true;
            }
            return false;
        }

        public ReconhecedordeTriangulos()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            verificacaoOk = true;
            if (verificacao(txtboxA))
                MessageBox.Show("Valor de A Invalido ou campo vazio!");
            if (verificacao(txtboxB))
                MessageBox.Show("Valor de B Invalido ou campo vazio!");
            if (verificacao(txtboxC))
                MessageBox.Show("Valor de C Invalido ou campo vazio!");

            if(verificacaoOk == true)
            {
                double numCheck, A, B, C;
                double.TryParse(txtboxA.Text, out numCheck);
                A = numCheck;
                double.TryParse(txtboxB.Text, out numCheck);
                B = numCheck;
                double.TryParse(txtboxC.Text, out numCheck);
                C = numCheck;

                if (Math.Abs(B - C) < A && A < B + C &&
                    Math.Abs(A - C) < B && B < A + C &&
                    Math.Abs(A - B) < C && C < A + B)
                {
                    if(A == B && A == C) 
                        MessageBox.Show("Suas medidas representam um triangulo equilatero");
                    else if(A == B || B == C || C == A)
                        MessageBox.Show("Suas medidas representam um triangulo isosceles");
                    else
                        MessageBox.Show("Suas medidas representam um triangulo escaleno");
                }
                else
                    MessageBox.Show("Suas medidas não representam um triangulo");
            }
        }

        private void ReconhecedordeTriangulos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }
    }
}

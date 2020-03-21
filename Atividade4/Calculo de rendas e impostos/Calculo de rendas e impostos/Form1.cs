using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculo_de_rendas_e_impostos
{
    public partial class Calculadora : Form
    {
        bool verificacaoOk = true;
        private bool verificacao(MaskedTextBox actual)
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

        double calculoDescontoINSS (double SalBruto)
        {
            if (SalBruto <= 800.47) return 0.0765;
            else if (SalBruto <= 1050) return 0.0865;
            else if (SalBruto <= 1400.77) return 0.09;
            else if (SalBruto <= 2801.56) return 0.11;
            else return 308.17;
        }

        double calculoDescontoIRPF (double SalBruto)
        {
            if (SalBruto <= 1257.12) return 0;
            else if (SalBruto <= 2512.08) return 0.15;
            else return 0.275;
        }

        double calculoSalarioFamilia(double SalBruto)
        {
            if (SalBruto <= 435.52) return 22.33;
            else if (SalBruto <= 654.51) return 15.74;
            else return 0;
        }

         
    public Calculadora()
        {
            InitializeComponent();        
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            verificacaoOk = true;

            if (mTxtBoxNomeFunc.Text == string.Empty)
            {
                MessageBox.Show("Nome do funcionario em branco!");
                mTxtBoxNomeFunc.Clear();
            }

            if (verificacao(mTxtBoxSalBruto))
            {
                MessageBox.Show("Valor do Salario Invalido");
            }

            if (verificacao(mTxtBoxNumFilhos))
            {
                MessageBox.Show("Numero de filhos invalido");
            }

            if (verificacaoOk)
            {
                double SalarioBruto, NumeroFilhos;
                double.TryParse(mTxtBoxSalBruto.Text, out SalarioBruto);
                double.TryParse(mTxtBoxNumFilhos.Text, out NumeroFilhos);

                double DescontoINSS, DescontoIRPF, INSS, IRPF, SalarioLiquido, SalarioFamilia;

                if (SalarioBruto > 2801.56)
                {
                    DescontoINSS = calculoDescontoINSS(SalarioBruto);
                    mTxtBoxAInss.Text = DescontoINSS.ToString("N2");
                }

                else
                {
                    DescontoINSS = calculoDescontoINSS(SalarioBruto);
                    mTxtBoxAInss.Text = (100*DescontoINSS).ToString("N2") + "%";
                }

                DescontoIRPF = calculoDescontoIRPF(SalarioBruto);
                mTxtBoxAIrpf.Text = (100*DescontoIRPF).ToString("N2") + "%";

                INSS = SalarioBruto * DescontoINSS;
                mTxtBoxDescInss.Text = INSS.ToString("N2");

                IRPF = SalarioBruto * DescontoIRPF;
                mTxtBoxDescIrpf.Text = IRPF.ToString("N2");

                SalarioFamilia = calculoSalarioFamilia(SalarioBruto) * NumeroFilhos;
                mTxtBoxSalFam.Text = SalarioFamilia.ToString("N2");

                SalarioLiquido = SalarioBruto - INSS - IRPF + SalarioFamilia;
                mTxtBoxSalLiq.Text = SalarioLiquido.ToString("N2");

                string EstadoCivil;
                if (checkBoxCasado.Checked)
                {
                    if (radBtnMasc.Checked)
                        EstadoCivil = "casado";
                    else EstadoCivil = "casada";
                }

                else
                {
                    if (radBtnMasc.Checked)
                        EstadoCivil = "solteiro";
                    else EstadoCivil = "solteira";
                }
                txtBoxdescricao.Text = "Os descontos do salario de " + mTxtBoxNomeFunc.Text +
                                       " que é " + EstadoCivil + " e que tem " + NumeroFilhos.ToString() +
                                       " filhos(a) são:";
            }
        }

        private void Calculadora_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }
    }
}

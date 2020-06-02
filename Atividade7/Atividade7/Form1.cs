using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Collections;

namespace Atividade7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLer20_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[20];
            string auxiliar = "", valor = "";

            for (int x = 0; x < 20; x++)
            {
                valor = Interaction.InputBox("Digite o dado:" + (x + 1), "Entradade dados");

                if (int.TryParse(valor, out vetor[x]))
                {
                    auxiliar = vetor[x] + "\n" + auxiliar;

                }
                else
                {
                    MessageBox.Show("Numero Invalido!");
                    x--;
                }
            }
            MessageBox.Show(auxiliar);
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[20];

            string auxiliar = "", valor = "";

            for(int x = 0; x<20; x++)
            {
                valor = Interaction.InputBox("Digite o dado:" + (x + 1), "Entradade dados");

                if (!int.TryParse(valor, out vetor[x]))
                {
                    MessageBox.Show("Numero Invalido!");
                    x--;

                }
               
            }
            Array.Reverse(vetor);

            for(int x = 0; x < 20; x++)
            {
                auxiliar += vetor[x] + "\n";
            }
            MessageBox.Show(auxiliar);
        }

        private void btnMerc_Click(object sender, EventArgs e)
        {
            double[] qntd = new double[10];
            double[] preco = new double[10];
            string auxiliar = "";
            bool prox;

            for (int x = 0; x < 10; x++)
            {
                prox = false;
                while (!prox)
                {
                    auxiliar = Interaction.InputBox("Digite a quantidade:" + (x + 1), "Entradade dados");

                    if (!double.TryParse(auxiliar, out qntd[x]))
                    {
                        MessageBox.Show("Numero Invalido!");
                    }
                    else
                    {
                        prox = true;
                    }
                }

                prox = false;
                while (!prox)
                {
                    auxiliar = Interaction.InputBox("Digite o preço:" + (x + 1), "Entradade dados");

                    if (!double.TryParse(auxiliar, out preco[x]))
                    {
                        MessageBox.Show("Numero Invalido!");
                    }
                    else
                    {
                        prox = true;
                    }
                }
            }
            double total = 0;
            for (int x = 0; x < 10; x++)
            {
                total += qntd[x] * preco[x];
            }

            MessageBox.Show("O faturamento total é de: " + total.ToString("N2"));
        }

        private void BtnVariavelTotal_Click(object sender, EventArgs e)
        {
            string[] Alunos = { "Viviane", "André", "Hélio", "Denise", 
                                "Junior", "Leonardo", "Jose", "Nelma", "Tobby" };

            Int32 Total = 0;
            Int32 N = Alunos.Length;

            for(int i = 0; i < N-1; i++)
                {
                Total += Alunos[i].Length;
                }

            MessageBox.Show(Total.ToString());
        }

        private void btnArrayList_Click(object sender, EventArgs e)
        {
            ArrayList Nomes = new ArrayList(10);

            for(int i = 0; i < 10; i++)
            {
                Nomes.Add("Ana");
                Nomes.Add("André");
                Nomes.Add("Debora");
                Nomes.Add("Fatima");
                Nomes.Add("João");
                Nomes.Add("Janete");
                Nomes.Add("Otavio");
                Nomes.Add("Marcelo");
                Nomes.Add("Pedro");
                Nomes.Add("Thais");

            }

            Nomes.Remove("Otavio");
            string NomesJuntos = "";
            for(int i = 0; i<9; i++)
            {
                NomesJuntos += Nomes[i] + " ";
            }
            MessageBox.Show(NomesJuntos);
        }

        private void btnMedia20em3_Click(object sender, EventArgs e)
        {
            double[,] notasPorAluno = new double[20,3];
            double[] medias = new double[20];
            string nota;
            string Saida = "";

            for (int i=0; i<20; i++)
            {
                medias[i] = 0;
                for(int j=0; j<3; j++)
                {
                    while (true)
                    {
                        nota = Interaction.InputBox("Aluno: " + (i + 1) + "\n Materia: " + (j + 1));

                        if (double.TryParse(nota, out notasPorAluno[i,j]))
                        {
                            medias[i] += notasPorAluno[i, j];
                            break;

                        }
                        else
                        {
                            MessageBox.Show("Numero Invalido!");
                        }
                    }
                    
                }
     
            }
            for (int i = 0; i < 20; i++)
            {
                
                Saida += "Aluno " + (i+1) + ": " + "média: " + (medias[i]/3).ToString("N2") + "\n";           
            }
            MessageBox.Show(Saida);




        }

        private void btnContChars_Click(object sender, EventArgs e)
        {
           
            FrmExibicaoNomes frm = new FrmExibicaoNomes();
            frm.Show();
        }
    }
}

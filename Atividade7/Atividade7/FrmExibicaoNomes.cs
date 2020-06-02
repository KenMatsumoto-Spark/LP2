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

namespace Atividade7
{
    public partial class FrmExibicaoNomes : Form
    {
        public FrmExibicaoNomes()
        {
            InitializeComponent();
        }
        int[] qntChars = new int[4];
        string[] nomes = new string[4];
        private void btnExe_Click(object sender, EventArgs e)
        {
            string nome;
            string[] nomesSemEspaco = new string[4];
            int[] qntChars = new int[4];
            for (int i = 0; i < 4; i++)
            {
                nome = Interaction.InputBox("Nome(" + (i + 1) + "): ");
                nomes[i] = nome;
                nome.Replace(" ", "");
                qntChars[i] = nome.Length;
            }
            listBox1.BeginUpdate();
            for (int i = 0; i < 4; i++)
            {
                listBox1.Items.Add("o nome " + nomes[i] + " tem " + qntChars[i] + " caracteres\n");
            }

            listBox1.EndUpdate();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_Projeto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int ano = int.Parse(anoText.Text);
            string marca = marcaText.Text;
            string modelo = modeloText.Text;
            double preço = double.Parse(preçoText.Text);
            double velocidade = double.Parse(velocidadeText.Text); 
        }
    }
}

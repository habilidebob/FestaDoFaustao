using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FestaDoFaustao
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            lblDiaAtual.Text = DateTime.Now.ToString("dd/MM/yyyy");
            //pibFaustao.Image = Image.FromFile(@"C:\Users\estevao.roliveira\Pictures\f1.jpg");
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {

            int idade = Convert.ToInt32(nudIdade.Value);
            if (nudIdade.Value.ToString().Length == 0)
            {
                btnLimpar.PerformClick();
            }
            else if (idade >= 18)
            {
                lblResultado.Text = "Pode entrar!";
                lblResultado.ForeColor = Color.Green;
                // Mudar a img para um recurso do projeto:
                pibFaustao.Image = Properties.Resources.f2;
            }
            else
            {
                lblResultado.Text = "Não pode entrar!";
                lblResultado.ForeColor = Color.Red;
                // Mudar a img para um recurso do projeto:
                pibFaustao.Image = Properties.Resources.f1;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            nudIdade.Value = 0;

            lblResultado.Text = "Será que você pode entrar?";
            lblResultado.ForeColor = Color.Black;

            pibFaustao.Image = Properties.Resources.f0;
        }
    }
}

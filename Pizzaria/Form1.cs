using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzaria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboSabores.Items.Add("Mussarela");
            cboSabores.Items.Add("Palmito");
            cboSabores.Items.Add("Atum");
            cboSabores.Items.Add("Calabresa");
            cboSabores.Items.Add("Baiana");
            cboSabores.Items.Add("Catupiry com Bacon");

            cboSabores.SelectedIndex = 0;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            cboSabores.SelectedIndex = 0;
            cboSabores.Focus();
            chkAzeitona.Checked = false;
            chkCebola.Checked = false;
            chkChampignon.Checked = false; 
            rdbSemBorda.Checked = true;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            string strSabor;
            string strPedido = null;

            strSabor = cboSabores.Text;
            if (string.IsNullOrEmpty(cboSabores.Text))
            {
                MessageBox.Show("Selecione um sabor de pizza!", "Pizzaria",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboSabores.Focus();
                return;
            }
            switch (strSabor)
            {
                case "Mussarela":
                    strPedido = "Mussarela";
                    break;
                case "Palmito":
                    strPedido = "Palmito";
                    break;
                case "Atum":
                    strPedido = "Atum";
                    break;
                case "Calabresa":
                    strPedido = "Calabresa";
                    break;
                case "Baiana":
                    strPedido = "Baiana";
                    break;
                case "Catupiry com Bacon":
                    strPedido = "Catupiry com Bacon";
                    break;
            }
            if (chkAzeitona.Checked)
            {
                strPedido = strPedido + " com Azeitonas";
            }
            if (chkCebola.Checked)
            {
                strPedido = strPedido + " com Cebolas";
            }
            if (chkChampignon.Checked)
            {
                strPedido = strPedido + " com Champignons";
            }
            if (rdbComBorda.Checked)
            {
                strPedido = strPedido + " com borda recheada";
            }
            else if(rdbComBordaCheddar.Checked)
            {
                strPedido = strPedido + " com borda recheada de cheddar";
            }
            else
            {
                strPedido = strPedido + " sem borda recheada";
            }
            MessageBox.Show(strPedido, "Pizzaria",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

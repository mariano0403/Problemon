using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teleono
{
    public partial class Form1 : Form
    {
        private const float PrecioVerb = 5000;
        private const float PrecioFury = 8000;
        private const float PrecioKingst = 6500;
        double Importetotal = 0;
        int Cantidad = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void CboCuotas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtVerb.Text = PrecioVerb.ToString();
            txtKingst.Text = PrecioKingst.ToString();
            txtFury.Text = PrecioFury.ToString();
            CboCuotas.Items.Add("1");
            CboCuotas.Items.Add("3");
            CboCuotas.Items.Add("6");
            CboCuotas.Items.Add("12");
            CboMarcas.Items.Add(label1.Text);
            CboMarcas.Items.Add(label2.Text);
            CboMarcas.Items.Add(label3.Text);
            rdbContado.Checked = true;
            rdbCrédito.Checked = false;
            CboCuotas.Enabled = false;
            btnAgregar.Enabled = false;
        }

        private void rdbCrédito_CheckedChanged(object sender, EventArgs e)
        {
            CboCuotas.Enabled = true;
            CboCuotas.SelectedIndex = -1;
        }

        private void rdbContado_CheckedChanged(object sender, EventArgs e)
        {
            CboCuotas.Enabled = false;
            

        }

        private void btnValorizar_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void numCantidad_ValueChanged(object sender, EventArgs e)
        {
           
            if (numCantidad.Value >0)
            {

                btnAgregar.Enabled = true;
                Cantidad = int.Parse(numCantidad.Value.ToString());
            }
            else
            {

                btnAgregar.Enabled = false;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            switch (CboMarcas.SelectedIndex)
            {
                case 0:
                    Importetotal = Importetotal + double.Parse(txtVerb.Text) * Cantidad;
                 
                    break;
                case 1:
                    Importetotal = Importetotal + double.Parse(txtKingst.Text) * Cantidad;
                    break;

                default:
                    Importetotal = Importetotal + double.Parse(txtFury.Text) * Cantidad;

                    break;
            }
            numCantidad.Value = 0;
            CboMarcas.SelectedIndex = -1;
        }
    }
}


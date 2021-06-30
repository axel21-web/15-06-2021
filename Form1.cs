using Examen_IIParcial.Poco;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_IIParcial
{
    public partial class Form1 : Form
    {
        public List<FN> fn { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnFNE_Click(object sender, EventArgs e)
        {

        }

        private void BtnPR_Click(object sender, EventArgs e)
        {

        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            ValidateProducto(out decimal inversion, out decimal plazo, out double taza, out decimal inflacion, out decimal vs);

            FN f = new FN
            {
                Inversion = inversion,
                Plazo = plazo,
                Taza = taza,
                Inflacion = inflacion,
                VS = vs,
            };
            fn.Add(f);
            MessageBox.Show("Producto agregado satisfactoriamente");

            dgvTabla.DataSource = null;
            dgvTabla.DataSource = fn;
            dgvTabla.Refresh();
            Close();
        }

        private void ValidateProducto(out decimal inversion, out decimal plazo, out double taza, out decimal inflacion, out decimal vs)
        {
            if (!decimal.TryParse(txtInversion.Text, out decimal inv))
            {
                throw new ArgumentException($"El valor \"{txtInversion.Text}\" es invalido!");
            }
            inversion = inv;
            if (!decimal.TryParse(txtPlazo.Text, out decimal pla))
            {
                throw new ArgumentException($"El valor \"{txtPlazo.Text}\" es invalido!");
            }
            plazo = pla;
            if (!double.TryParse(txtTaza.Text, out double t))
            {
                throw new ArgumentException($"El valor \"{txtTaza.Text}\" es invalido!");
            }
            taza = t;
            if (!decimal.TryParse(txtInflacion.Text, out decimal inf))
            {
                throw new ArgumentException($"El valor \"{txtInflacion.Text}\" es invalido!");
            }
            inflacion = inf;
            if (!decimal.TryParse(txtVS.Text, out decimal Vs))
            {
                throw new ArgumentException($"El valor \"{txtVS.Text}\" es invalido!");
            }
            vs = Vs;

        }


    }
}

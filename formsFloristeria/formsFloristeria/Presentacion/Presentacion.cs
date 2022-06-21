using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using formsFloristeria.Model;

namespace formsFloristeria.Presentacion
{
    public partial class Presentacion : Form
    {
        public Presentacion()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (FloristeriaParcialEntities db = new FloristeriaParcialEntities())
            {
                Flores flor = new Flores();
                flor.nombreFlor = textBox1.Text;
                flor.cantidad = int.Parse(textBox2.Text);
                flor.precio = decimal.Parse(textBox3.Text);
                flor.estado = int.Parse(textBox4.Text);

                db.Flores.Add(flor);
                db.SaveChanges();
                MessageBox.Show("Su registro se ha almacenado");
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}

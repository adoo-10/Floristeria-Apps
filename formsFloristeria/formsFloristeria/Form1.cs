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

namespace formsFloristeria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Presentacion.Presentacion Agregar = new Presentacion.Presentacion();
            Agregar.ShowDialog();
            Refrescar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Refrescar();
        }

        private void Refrescar()
        {
            using (FloristeriaParcialEntities db = new FloristeriaParcialEntities())
            {
                var lst = from d in db.Flores
                          select d;
                dataGridView1.DataSource = lst.ToList();


            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class PrincipalVista : Form
    {
        public PrincipalVista()
        {
            InitializeComponent();
            AbrirNuevaVista(new InicioVista());
        }

        /// <summary>
        /// Abre una nueva Vista dentro del formulario principal, si ya existe una, la borra.
        /// </summary>
        /// <param name="FormularioHijo">Vista a abrir.</param>
        private void AbrirNuevaVista(Form FormularioHijo)
        {
            if (this.splitContainer1.Panel2.Controls.Count > 0)
                this.splitContainer1.Panel2.Controls.RemoveAt(0);

            Form fh = FormularioHijo;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;

            this.splitContainer1.Panel2.Controls.Add(fh);
            this.splitContainer1.Panel2.Tag = fh;

            fh.Show();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            AbrirNuevaVista(new InicioVista());
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            AbrirNuevaVista(new ProductosVista());
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirNuevaVista(new ClientesVista());
        }
    }
}

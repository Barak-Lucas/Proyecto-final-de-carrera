using L2BE;
using L3BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L1GUI.Forms.PopUps
{
    public partial class FormInteraccionModificar : Form
    {
        InteraccionBE interaccionModif;
        InteraccionBLL bllInteraccion;
        Action ActionRefrescarDGV;

        public FormInteraccionModificar(int idModif, Action actionRefrescarDGV)
        {
            InitializeComponent();
            bllInteraccion = new InteraccionBLL();
            this.interaccionModif = bllInteraccion.BuscarInteraccion(idModif);
            this.ActionRefrescarDGV = actionRefrescarDGV;
        }

        private void FormInteraccionModificar_Load(object sender, EventArgs e)
        {
            ConfigurarComponentes();
        }

        private void ConfigurarComponentes()
        {

            try
            {
                if (interaccionModif != null)
                {
                    txtContacto.Text = interaccionModif.Contacto;
                    txtNombreApellido.Text = interaccionModif.Interesado;
                    txtDetalle.Text = interaccionModif.Detalles;
                }
                else
                {
                    MessageBox.Show("No se encontró la interacción a modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtContacto.Text.Length == 0)
                {
                    MessageBox.Show("El campo 'Contacto' no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txtNombreApellido.Text.Length == 0)
                {
                    MessageBox.Show("El campo 'Nombre/Apellido' no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                interaccionModif.Contacto = txtContacto.Text;
                interaccionModif.Interesado = txtNombreApellido.Text;
                interaccionModif.Detalles = txtDetalle.Text;
                bllInteraccion.Modificar(interaccionModif);
                MessageBox.Show("Interacción modificada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActionRefrescarDGV?.Invoke();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

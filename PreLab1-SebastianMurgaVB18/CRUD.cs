using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PreLab1_SebastianMurgaVB18
{
    public partial class CRUD : Form
    {

        static int fila; //Variable permanente y estática
        //Se usa en eliminar
        public CRUD()
        {
            InitializeComponent();
        }
        //Método Limpiar
        void limpiar()//Método Limpiar
        {
            //Se limpian todas las cajas de texto
            txtnombre.Text = "";
            txtapellido.Text = "";
            txtcodigo.Text = "";
            txtgrado.Text = "";
            txtseccion.Text = "";
            txttelefono.Text = "";
            txtmatricula.Text = "";
            txtciclo.Text = "";
            txtmaestro.Text = "";
            txtedad.Text = "";
            txtprimer.Text = "";
            txtnombre.Focus();
            //Indica donde debe enfocarse el cursor
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Lleva a la ventana de Créditos
            Creditos SI = new Creditos();
            SI.ShowDialog();
            //Debe cerrarse la ventana para continuar
        }

        private void CRUD_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            //Clase para recolectar todos los datos
            //Los datos de los TextBox
            object[] agregarDatos =
            {
                txtnombre.Text,
                txtapellido.Text,
                txtcodigo.Text,
                txtgrado.Text,
                txtseccion.Text,
                txttelefono.Text,
                txtmatricula.Text,
                txtciclo.Text,
                txtmaestro.Text,
                txtedad.Text,
                txtprimer.Text,
            };

            //Agregar estos datos al datagridview
            DATAGRID.Rows.Add(agregarDatos);

            //Ventana que confirma el registro
            MessageBox.Show("Alumno registrado", "PreLaboratorio");

            //Método limpieza
            limpiar();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try //Se prueba si está seleccionado un alumno
            {   
                //Comprobar la fila seleccionada, su indice
                if (fila >= 0)
                {
                    //Se remueve la fila seleccionada
                    DATAGRID.Rows.RemoveAt(fila);
                    //Ventana informativa
                    MessageBox.Show("Alumno eliminado", "PreLaboratorio");
                }

                else //Si no existiera alumno que eliminar
                    MessageBox.Show("No hay alumno", "PreLaboratorio");

            }
            catch (Exception)//Si no hay alumno seleccionado
            {
                //Ventana informativa
                MessageBox.Show("No hay alumno seleccionado", "PreLaboratorio");
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            limpiar();//Solo se llama al método limpiar
        }
    }
}

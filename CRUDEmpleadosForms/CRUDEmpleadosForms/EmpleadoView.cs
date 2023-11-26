using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CRUDEmpleadosForms
{
    public partial class EmpleadoView : Form
    {
        public List<string> Departamentos { get; set; } = new List<string>();
        public EmpleadoView()
        {
            InitializeComponent();           
            InitBlock();
        }
        // los eventos 
        public event EventHandler<Empleado> NuevoEmpleadoAgregado;
        public event EventHandler<Empleado> EmpleadoParaBorrar;
        public void Load()
        {
            comboBox1.DataSource = Departamentos;
        }
        private void InitBlock()
        {
            textBoxNombre.ReadOnly = true;
            textBoxDNI.ReadOnly = true;
            textBoxPuesto.ReadOnly = true;
            textBoxCorreo.ReadOnly = true;
            textBoxTelefono.ReadOnly = true;

        }
        public void CargarEmpleado(Empleado SelectedEmpleado)
        {
            textBoxNombre.Text = SelectedEmpleado.Nombre;
            textBoxDNI.Text = SelectedEmpleado.Dni;
            textBoxPuesto.Text = SelectedEmpleado.Puesto;
            textBoxCorreo.Text = SelectedEmpleado.Correo;
            textBoxTelefono.Text = SelectedEmpleado.Telefono;
            switch (SelectedEmpleado.Departamento.Nombre)
            {
                case EnumDepartamentos.RRHH:
                    comboBox1.SelectedIndex = 0;
                    break;
                case EnumDepartamentos.Administracion:
                    comboBox1.SelectedIndex = 1;
                    break;
                case EnumDepartamentos.Mantenimiento:
                    comboBox1.SelectedIndex = 2;
                    break;
                case EnumDepartamentos.Logistica:
                    comboBox1.SelectedIndex = 3;
                    break;
                case EnumDepartamentos.Marketing:
                    comboBox1.SelectedIndex = 4;
                    break;
                case EnumDepartamentos.Comercial:
                    comboBox1.SelectedIndex = 5;
                    break;
                case EnumDepartamentos.Finanzas:
                    comboBox1.SelectedIndex = 6;
                    break;
                case EnumDepartamentos.Masillas:
                    comboBox1.SelectedIndex = 7;
                    break;
                case EnumDepartamentos.Compras:
                    comboBox1.SelectedIndex = 8;
                    break;
                case EnumDepartamentos.Direccion:
                    comboBox1.SelectedIndex = 9;
                    break;
            };
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxDNI_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxCorreo_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxTelefono_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxPuesto_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxPuesto.ReadOnly = false;
            textBoxNombre.ReadOnly = false;
            textBoxDNI.ReadOnly = false;
            textBoxTelefono.ReadOnly = false;
            textBoxCorreo.ReadOnly = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            // Muestra un cuadro de diálogo de confirmación
            DialogResult result = MessageBox.Show("¿Estás seguro de que deseas borrar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Verifica la respuesta del usuario
            if (result == DialogResult.Yes)
            {
                EnumDepartamentos departamentofiltrado = EnumDepartamentos.Todos;
                // Intenta convertir el string en un valor de EnumDepartamentos
                if (Enum.TryParse(comboBox1.Text, out EnumDepartamentos departamentoEnum))
                {
                    departamentofiltrado = departamentoEnum;
                }
                Empleado nuevoMasilla = new Empleado(
                                                        dni: textBoxDNI.Text,
                                                        nombre: textBoxNombre.Text,
                                                        correo: textBoxCorreo.Text,
                                                        telefono: textBoxTelefono.Text,
                                                        puesto: textBoxPuesto.Text,
                                                        departamento: new Departamento(departamentofiltrado));
                EmpleadoParaBorrar?.Invoke(this, nuevoMasilla);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EnumDepartamentos departamentofiltrado = EnumDepartamentos.Todos;
            // Intenta convertir el string en un valor de EnumDepartamentos
            if (Enum.TryParse(comboBox1.Text, out EnumDepartamentos departamentoEnum))
            {
                departamentofiltrado = departamentoEnum;
            }
            Empleado nuevoMasilla = new Empleado(
                                                    dni: textBoxDNI.Text,
                                                    nombre: textBoxNombre.Text,
                                                    correo: textBoxCorreo.Text,
                                                    telefono: textBoxTelefono.Text,
                                                    puesto: textBoxPuesto.Text,
                                                    departamento: new Departamento(departamentofiltrado));
            NuevoEmpleadoAgregado?.Invoke(this, nuevoMasilla);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

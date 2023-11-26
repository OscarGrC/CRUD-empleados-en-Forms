namespace CRUDEmpleadosForms;

public partial class Principal : Form
{
    public List<string> Departamentos { get; set; } = new List<string>();
    public EmpleadoView empleadoView;

    public Principal(EmpleadoView empleadoView)
    {
        this.empleadoView = empleadoView;
        InitializeComponent();
        empleadoView.NuevoEmpleadoAgregado += EmpleadoView_NuevoEmpleadoAgregado;
        empleadoView.EmpleadoParaBorrar += EmpleadoView_EmpleadoParaBorrar;

    }

    public event EventHandler InitDepBox;
    public event EventHandler<string> FindEmpleadoByDNI;
    public event EventHandler<string> FindEmpleadoByDepartamento;
    public event EventHandler<Empleado> NuevoEmpleadoAgregado;
    public event EventHandler<Empleado> EmpleadoParaBorrar;
    public event EventHandler Order66;
    public event EventHandler InitlistEmpleados;
    public event EventHandler Guardar;
    public event EventHandler GuardarComo;
    public event EventHandler<int> EmpleadoSeleccionado;


    private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
    {

    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void listView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (listView1.SelectedIndices.Count > 0)
        {
            int selectedIndex = listView1.SelectedIndices[0];
            EmpleadoSeleccionado?.Invoke(this, selectedIndex);
            empleadoView.ShowDialog();
        }
    }

    private void Principal_Load(object sender, EventArgs e)
    {
        InitDepBox?.Invoke(this, e);
        comboBox1.DataSource = Departamentos;
        empleadoView.Departamentos = Departamentos;
        empleadoView.Departamentos.RemoveAt(0);
        empleadoView.Load();
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (comboBox1.Text != "Todos")
        {
        MessageBox.Show("Filtrando por: "+comboBox1.Text);
        }
        FindEmpleadoByDepartamento?.Invoke(this, comboBox1.SelectedText);
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
        FindEmpleadoByDNI?.Invoke(this, textBox1.Text);
    }
    public void Actualist(List<Empleado> empleados)
    {
        listView1.View = View.Details;
        //un poco ñapa lo se el borrar y crear cada vez que actualiza la lista pero los init me
        //dieron problemas sorry
        listView1.Columns.Clear();
        listView1.Columns.Add("DNI");
        listView1.Columns.Add("Nombre");
        listView1.Columns.Add("Correo");
        listView1.Columns.Add("Teléfono");
        listView1.Columns.Add("Puesto");
        listView1.Columns.Add("Departamento");
        listView1.Items.Clear();

        foreach (Empleado empleado in empleados)
        {
            ListViewItem item = new ListViewItem(empleado.Dni);
            item.SubItems.Add(empleado.Nombre);
            item.SubItems.Add(empleado.Correo);
            item.SubItems.Add(empleado.Telefono);
            item.SubItems.Add(empleado.Puesto);
            item.SubItems.Add(empleado.Departamento.Nombre.ToString());

            listView1.Items.Add(item);
        }
        foreach (ColumnHeader column in listView1.Columns)
        {
            column.Width = -2;
        }
    }

    private void button1_Click(object sender, EventArgs e)
    {
        empleadoView.Departamentos = Departamentos;
        empleadoView.ShowDialog();
    }
    private void EmpleadoView_NuevoEmpleadoAgregado(object sender, Empleado nuevoEmpleado)
    {
        NuevoEmpleadoAgregado?.Invoke(this, nuevoEmpleado);
    }
    private void EmpleadoView_EmpleadoParaBorrar(object sender, Empleado nuevoEmpleado)
    {
        EmpleadoParaBorrar?.Invoke(this, nuevoEmpleado);
    }

    private void order66ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Order66?.Invoke(this, e);
    }

    private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
    {
        InitlistEmpleados?.Invoke(this, e);

    }

    private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Guardar?.Invoke(this, e);
    }

    private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
    {
        GuardarComo?.Invoke(this, e);
    }
}



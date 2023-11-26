using System.Reflection;

namespace CRUDEmpleadosForms;

internal class PresenterEmpleadosImp
{
    private Principal view;
    private RepositoryImp repositorio;
    private List<Empleado> Empleados;
    public List<string> Departamentos { get; set; } = new List<string>();

    public PresenterEmpleadosImp(Principal view, RepositoryImp repositorio)
    {
        this.view = view;
        this.repositorio = repositorio;
        Empleados = repositorio.findAllEmpleados();
       

        // Atachamos los manejadores de eventos
        view.InitlistEmpleados += Initlist;
        view.InitDepBox += InitDepBox;
        view.FindEmpleadoByDNI += FindByDNI;
        view.FindEmpleadoByDepartamento += FindEmpleadoByDepartamento;
        view.NuevoEmpleadoAgregado += CreateEmpleado;
        view.EmpleadoParaBorrar += DeleteEmpleadoByDNI;
        view.Order66 += DeleteAllEmpleados;
        view.Guardar += Guardar;
        view.GuardarComo += GuardarComo;
        view.EmpleadoSeleccionado += SelectEmpleado;
    }

    private void Initlist(object sender, EventArgs e)
    {
        var contenido = string.Empty;
        using (OpenFileDialog openFileDialog = new OpenFileDialog())
        {
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openFileDialog.Filter = "CSV files (*.csv)|*.csv| Json files (*.json)|*.json| All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var stream = openFileDialog.OpenFile();
                using (StreamReader reader = new StreamReader(stream))
                {
                    contenido = reader.ReadToEnd();
                    Empleados = repositorio.OpenNewlist(Path.GetDirectoryName(openFileDialog.FileName)+
                                                        System.IO.Path.DirectorySeparatorChar +
                                                        Path.GetFileName(openFileDialog.FileName));
                }

                view.Actualist(Empleados);
            }
        }
    }
    private void Guardar(object sender, EventArgs e)
    {
        repositorio.saveAllEmpleados();
    }
    private void GuardarComo(object sender, EventArgs e)
    {
        using (SaveFileDialog saveFileDialog = new SaveFileDialog())
        {
            saveFileDialog.Filter = "Csv|*.csv|Todos los archivos|*.*";
            saveFileDialog.Title = "Guardar como";
            
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string Ruta = saveFileDialog.InitialDirectory + saveFileDialog.FileName;
                MessageBox.Show("trato de guardar en:" + Ruta);
                repositorio.SaveAllEn(Ruta);
            }
        }
    }
    private void InitDepBox(object sender, EventArgs e)
    {
        foreach (EnumDepartamentos valor in Enum.GetValues(typeof(EnumDepartamentos)))
        {
            Departamentos.Add(valor.ToString());

        }
        view.Departamentos = Departamentos;
    }

    public List<Empleado> FindAllEmpleados()
    {
       Empleados = repositorio.findAllEmpleados();
       return Empleados;
        
    }

    public void FindByDNI(object sender, string nuevoDni)
    {
        Empleados = repositorio.findEmpleadoByDNI(nuevoDni);
        view.Actualist(Empleados);
    }

    public void FindEmpleadoByDepartamento(object sender, string departamento)
    {
        EnumDepartamentos departamentofiltrado = EnumDepartamentos.Todos;
        // Intenta convertir el string en un valor de EnumDepartamentos
        if (Enum.TryParse(departamento, out EnumDepartamentos departamentoEnum))
        {
            departamentofiltrado = departamentoEnum;
        }
        view.Actualist(repositorio.findEmpleadoByDepartamento(new Departamento(departamentofiltrado)));
    }


    public void CreateEmpleado(object sender, Empleado nuevoEmpleado)
    {
        repositorio.createEmpleado(nuevoEmpleado);
        FindAllEmpleados();
        view.Actualist(Empleados);
    }

    public void DeleteEmpleadoByDNI(object sender, Empleado BorrarEmpleado)
    { 
        repositorio.deleteEmpleadoByDNI(BorrarEmpleado.Dni);
        FindAllEmpleados();
        view.Actualist(Empleados);
    }

    public void DeleteAllEmpleados(object sender, EventArgs e)
    {
        repositorio.DeleteAllEmpleados();
        FindAllEmpleados();
        view.Actualist(Empleados);
    }

    public void SaveAllEmpleados(object sender, EventArgs e)
    {
        repositorio.saveAllEmpleados();
    }

    public void SelectEmpleado(object sender, int indice)
    {
        view.empleadoView.CargarEmpleado(Empleados[indice]);
    }
}

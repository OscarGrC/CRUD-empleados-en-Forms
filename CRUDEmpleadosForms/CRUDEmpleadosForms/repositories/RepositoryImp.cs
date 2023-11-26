using System.Net;

namespace CRUDEmpleadosForms;
public class RepositoryImp 
{
    private StorageImp database;
    private List<Empleado> listaEmpleados;

    public RepositoryImp(StorageImp db)
    {
        database = db;
        listaEmpleados = db.LoadDataCSVEmpleados().ToList();
    }
    public List<Empleado> findAllEmpleados()
    {
        return listaEmpleados;
    }
    public List<Empleado> findEmpleadoByDNI(string dni)
    {
        return listaEmpleados.Where(empleado => empleado.Dni.Contains(dni)).ToList();
    }
    public List<Empleado> findEmpleadoByDepartamento(Departamento departamento)
    {
        if(departamento.Nombre== EnumDepartamentos.Todos) { return listaEmpleados;}
        return listaEmpleados.FindAll(Empleado => Empleado.Departamento.Nombre == departamento.Nombre);
    }
    public Empleado saveEmpleado(Empleado empleado)
    {
        if (listaEmpleados.Any(e => e.Dni == empleado.Dni))
        {
            // Si ya existe, llamar a la función upDateEmpleado
            upDateEmpleado(empleado);
        }
        else
        {
            // Si no existe, agregar el nuevo empleado a la lista
            listaEmpleados.Add(empleado);
        }
        return empleado;
    }

    public Empleado? deleteEmpleadoByDNI(string dni)
    {
        var empleado = listaEmpleados.FirstOrDefault(emp => emp.Dni == dni);
        if (empleado == null)
        {
            MessageBox.Show("Trabajador no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        else
        {
            listaEmpleados.Remove(empleado);
            MessageBox.Show("Trabajador borrado", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
        }
        return empleado;
    }
    public void DeleteAllEmpleados()
    {

        database.DeleteAll();
        listaEmpleados = new List<Empleado>();
    }
    public void saveAllEmpleados()
    {
        database.SaveDataCSVEmpleados(listaEmpleados);
    }
    public void SaveAllEn(string Ruta)
    {
        database.Path = Ruta;
        database.SaveDataCSVEmpleados(listaEmpleados);
    }
    public Empleado createEmpleado(Empleado empleado)
    {
        var empleadoOriginal = listaEmpleados.FirstOrDefault(emp => emp.Dni == empleado.Dni);
        if (empleadoOriginal != null)
        {
            listaEmpleados.Remove(empleadoOriginal);
        }
        listaEmpleados.Add(empleado);
        return empleado;
    }
    public Empleado upDateEmpleado(Empleado empleado)
    {
        deleteEmpleadoByDNI(empleado.Dni);
        saveEmpleado(empleado);
        return empleado;
    }
    public List<Empleado> OpenNewlist(string path)
    {
       database.Path = path;  
       return database.LoadDataCSVEmpleados();
        
    }
}






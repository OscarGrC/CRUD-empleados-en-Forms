
public class Empleado
{
    // Propiedades
    public string Dni { get; set; }
    public string Nombre { get; set; }
    public string Correo { get; set; }
    public string Telefono { get; set; }
    public string Puesto { get; set; }
    public Departamento Departamento { get; set; }

    // Constructor
    public Empleado(string dni, string nombre, string correo, string telefono, string puesto, Departamento departamento)
    {
        Dni = dni;
        Nombre = nombre;
        Correo = correo;
        Telefono = telefono;
        Puesto = puesto;
        Departamento = departamento;
    }

    // Método para presentarse
    public void Presentarse()
    {
        Console.WriteLine($@"
            Hola, soy {Nombre}, trabajo en el departamento {Departamento.Nombre} como {Puesto}.
            Mi teléfono es {Telefono}, mi correo es {Correo} y mi DNI es {Dni}.
        ");
    }
}


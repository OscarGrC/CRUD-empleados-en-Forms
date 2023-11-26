public class Departamento
{
    public EnumDepartamentos Nombre { get; set; }

    // Constructor que toma un argumento EnumDepartamentos
    public Departamento(EnumDepartamentos nombre)
    {
        Nombre = nombre;
    }
}

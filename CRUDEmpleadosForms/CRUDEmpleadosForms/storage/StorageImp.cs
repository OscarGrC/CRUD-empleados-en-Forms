namespace CRUDEmpleadosForms;
public class StorageImp 
{
   private static string Prepath = $"{System.AppDomain.CurrentDomain.BaseDirectory}";
   private static int Recorte = Prepath.Length - 25;
   private static string Resultado = Prepath.Substring(0, Recorte);
   private static string Defaultpath = $"{Resultado}" +
                  "storage" + System.IO.Path.DirectorySeparatorChar +
                  "Personal.csv";
    public String Path = Defaultpath; 
    public List<Empleado> SaveDataCSVEmpleados(List<Empleado> data)
    {
        if (!System.IO.File.Exists(Path))
        {
            System.IO.File.Create(Path).Close();
        }

        string salidaPrologo = "Dni,Nombre,Correo,tlf,Puesto,Departamento \n";
        string salida = "";

        foreach (Empleado empleado in data)
        {
            salida += $"{empleado.Dni};{empleado.Nombre};{empleado.Correo};{empleado.Telefono};{empleado.Puesto};" +
                      $"{empleado.Departamento.Nombre}\n";
        }

        using (System.IO.StreamWriter file = new System.IO.StreamWriter(Path))
        {
            file.Write(salidaPrologo + salida);
        }

        Console.WriteLine($"CSV guardado en {Path}");
        return data;
    }

    public List<Empleado> LoadDataCSVEmpleados()
    {
        
        if (!System.IO.File.Exists(Path))
        {
            MessageBox.Show(Path);
            return new List<Empleado>();
        }

        List<Empleado> listaEmpleados = new List<Empleado>();

        using (System.IO.StreamReader file = new System.IO.StreamReader(Path))
        {
            string line;
            bool firstLine = true;

            while ((line = file.ReadLine()) != null)
            {
                if (firstLine)
                {
                    firstLine = false;
                    continue; // Ignora la primera línea (encabezado)
                }

                string[] columnas = line.Split(';');

                Empleado empleado = new Empleado(
                    columnas[0], // dni
                    columnas[1], // nombre
                    columnas[2], // correo
                    columnas[3], // telefono
                    columnas[4], // puesto
                     new Departamento(
                     (EnumDepartamentos)Enum.Parse(typeof(EnumDepartamentos), columnas[5])
                     ) // departamento 
                );


                listaEmpleados.Add(empleado);
            }
        }
        return listaEmpleados;
    }
    public List<Empleado> DeleteAll()
    {
        List<Empleado> listavacia = new List<Empleado>();
        return  SaveDataCSVEmpleados(listavacia);
    }
    
}
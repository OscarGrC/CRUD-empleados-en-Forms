public interface IPresenterEmpleados
{

    List<Empleado> FindAllEmpleados();
    Empleado? FindEmpleadoByDNI();
    List<Empleado> FindEmpleadoByDepartamento();
    Empleado? DeleteEmpleadoByDNI();
    void DeleteAllEmpleados();
    void SaveAllEmpleados();
    Empleado CreateEmpleado();
    Empleado UpDateEmpleado();
}

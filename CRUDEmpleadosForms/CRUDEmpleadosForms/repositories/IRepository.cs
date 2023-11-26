public interface IRepository
{

    List<Empleado> findAllEmpleados();
    Empleado? findEmpleadoByDNI(string dni);
    List<Empleado> findEmpleadoByDepartamento(Departamento departamento);
    Empleado saveEmpleado(Empleado empleado);
    Empleado? deleteEmpleadoByDNI(string dni);
    void deleteAllEmpleados();
    void saveAllEmpleados();
    Empleado createEmpleado(Empleado empleado);
    Empleado upDateEmpleado(Empleado empleado);
}

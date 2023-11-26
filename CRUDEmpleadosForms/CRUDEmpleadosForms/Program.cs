namespace CRUDEmpleadosForms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            EmpleadoView empleadoView = new();
            Principal principal = new(empleadoView);
            StorageImp storage = new ();
            RepositoryImp repository = new(storage);
            PresenterEmpleadosImp present = new(principal, repository);
            Application.Run(principal);
        }
    }
}


     

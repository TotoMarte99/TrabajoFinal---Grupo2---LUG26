namespace TrabajoFinal___Grupo2___LUG26
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

            // Primero el ingreso. Si no se loguea (cancela o agota los 3 intentos) la aplicación termina.
            using (FrmLogin login = new FrmLogin())
            {
                if (login.ShowDialog() != DialogResult.OK)
                    return;
            }

            Application.Run(new FrmPrincipal());
        }
    }
}

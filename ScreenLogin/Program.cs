using ScreenLogin.Data;
using ScreenLogin.Services;

namespace ScreenLogin
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

            var context = new DataContext();
            var service = new UsuarioService(context);
            Application.Run(new Form_Login(service));

        }
    }
}
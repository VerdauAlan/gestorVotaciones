namespace GestorVotaciones_server
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            MenuInicial menuInicial = new MenuInicial();

            Application.Run(menuInicial);
        }
    }
}
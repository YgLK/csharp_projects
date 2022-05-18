namespace ModelSystemRPG
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
            // commented for tests
            //Application.Run(new Menu());

            // TESTS
            //Application.Run(new Catalog());
            Application.Run(new Menu());
        }
    }
}
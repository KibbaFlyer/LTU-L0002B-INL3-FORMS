namespace PersonRegistrerare
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
            // Vi b�rjar med att starta v�lkomstformul�ret
            Application.Run(new WelcomeForm());
        }
    }
}
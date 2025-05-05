namespace CarListApp
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
            // Application.EnableVisualStyles();
            // Application.SetCompatibleTextRenderingDefault(false);
            // ApplicationConfiguration.Initialize();
            
            
            // show the login form first after logging in through Form1 or Restistering. 
            LoginForm loginForm = new LoginForm();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                // Then open the main application form (Form1)
                Application.Run(new Form1());
            }

        }
    }
}
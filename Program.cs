namespace UnofficialUGSCLIUI
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var mainFormView = new frmUGSCLIUI();
            _ = new MainFormLogic(mainFormView);
        }
    }
}
namespace LabTask1
{
    internal static class Program
    {
       
        [STAThread]
        static void Main()
        {// see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}
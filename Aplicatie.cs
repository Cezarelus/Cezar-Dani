namespace Pinci_Catalog
{
    internal static class Aplicatie
    {
     
        [STAThread]
        static void Main()
        {
           
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}
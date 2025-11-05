using System.Xml.Linq;

namespace lab8
{
    internal static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}

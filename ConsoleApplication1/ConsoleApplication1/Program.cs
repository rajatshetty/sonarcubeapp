using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int myvariable = 0;

            Sonar sonar = new Sonar();

            sonar.Welcom();

            CSharp csharp = new CSharp();

            csharp.SetDetails("4.0", "Asp.Net MVC");

            csharp.GetDetails();

            Console.ReadKey();
        }
    }

    public class Sonar

    {
        public void Welcom()
        {
            Console.WriteLine("Welcom to Sonar Qube"); Console.WriteLine("We will analyze .NET projects here...");
        }
    }

    public class CSharp
    {
        string Version;

        string Technology;

        public void GetDetails()

        {

            Console.WriteLine("version : " + Version);

            Console.WriteLine("Technology : " + Technology);

        }

        public void SetDetails(string version, string technology)
        {

            Version = version; Technology = technology;

        }

    }
}

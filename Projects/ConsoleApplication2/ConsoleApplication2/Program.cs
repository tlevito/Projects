using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Microsoft.Practices.Unity;

namespace ConsoleSolutionUnity
{



    class Program
    {

        static void Main(string[] args)
        {

            IUnityContainer unitycontainer = new UnityContainer();

            unitycontainer.RegisterType<IUniversity, University>();

            Student stu = unitycontainer.Resolve<Student>();
            Console.WriteLine("");
            Console.WriteLine("What is your Type Code ? Eng or Bus? an empty string will exit.");
            string read = Console.ReadLine();

            do
            {
                Console.WriteLine(stu.DisplayResult(read));
                read = Console.ReadLine();
            } while (read != "");

        }



    }
}
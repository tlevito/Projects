using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Microsoft.Practices.Unity;

namespace ConsoleSolutionUnity
{


    public interface IUniversity
    {
        string ShowResult(string x);
    }

    public class University : IUniversity
    {
        public string ShowResult(string x)
        {
            if (x == "Eng")
            return ("You are in the Engineering program.");
            else if (x== "Bus")
            return("You are in the Business program.");
            else
            return ("You have not selected a program type.");
        }
    }
}

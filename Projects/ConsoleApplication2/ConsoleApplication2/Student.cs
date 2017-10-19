using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;

namespace ConsoleSolutionUnity
{
    public interface IStudent
    {
    }
    public class Student : IStudent
    {
        private IUniversity _University;
        //[Dependency]
        //public IUniversity University
        //{
        //    get { return _University; }
        //    set { _University = value; }
        //}

        //Dependency Injection by constructor
        [InjectionConstructor]
        public Student(IUniversity tmpUniversity)
        {
            _University = tmpUniversity;
        }

        //// Dependency Injection by method
        //[InjectionMethod]
        //public void SetObject(IUniversity tmpUniversity)
        //{
        //    _University = tmpUniversity;
        //}  

        public string DisplayResult(string ProgType)
        {
            return _University.ShowResult(ProgType);
        }
    }
}

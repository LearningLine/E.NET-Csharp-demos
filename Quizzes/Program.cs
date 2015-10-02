using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A;
using B;
namespace Quizzes
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Test();
            }
            catch (Exception e)
            {
                Debug.Write("something happened " + e);
                throw e; // BAD
                throw;
            }
        }

        private static void Test()
        {
            throw new NotImplementedException();
        }
    }

    interface ITest
    {
        void MyMethod();
        int Length { get; set; }
    }
}

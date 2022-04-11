using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMSForLitwareOrganization
{
    internal class LitwareLib
    {

        static void Main(string[] args)
        {
            Employee emp = new Employee();
            //Employee emp = new Employee(101,"kishan kumar",25025.00);
            emp.Method1(101);
            emp.Method2("kishan kumar");
            emp.Method3();    //this method contains all three implemented methods
            //emp.MethodforHRA();
            //emp.MethodForGrossSalary();
            //emp.CalculateSalary();
        }
    }
}

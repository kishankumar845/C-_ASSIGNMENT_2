using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMSForLitwareOrganization
{
    internal class LitwareLib : IPrintable
    {

        public void LoginForLitwareOrg() //Overridden methods of IPrinatable Interface 
        {
            Console.WriteLine("Please Login Using EmployeeId and EmployeeName");
        }
        public void LogoutfromLitwareOrg() //Overridden methods of IPrinatable Interface 
        {
            Console.WriteLine("your LoginSession Expired");
        }

        static void Main(string[] args)
        {
            LitwareLib lit = new LitwareLib();
            lit.LoginForLitwareOrg();
            int TotalEmployeeCount = 10;
            for(int i=1;i<=TotalEmployeeCount;i++)
            {
                Employee emp = new Employee();
                emp.Method1(101);
                emp.Method2("kishan kumar");
                emp.Method3();
            }
            lit.LogoutfromLitwareOrg();
            
            //Employee emp = new Employee(101,"kishan kumar",25025.00);

            /*emp.Method1(101);
            emp.Method2("kishan kumar");
            emp.Method3(); */   //this method contains all three implemented methods


            //emp.MethodforHRA();
            //emp.MethodForGrossSalary();
            //emp.CalculateSalary();
        }
       
    }
}

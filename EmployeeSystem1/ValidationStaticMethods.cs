using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSystem1
{
    public static class ValidationStaticMethods
    {
        public static void AnotherTransaction(ref char anotherTran, ref int trans)
        {
            Console.WriteLine("Do you want another transaction(Y/N) ?");
            char.TryParse(Console.ReadLine(), out anotherTran);
            if (anotherTran == 'y' || anotherTran == 'Y')
            {
                Console.WriteLine("Please choose the next Transaction : ");
                ValidationStaticMethods.InputIntValidation(ref trans);
            }

        }
        public static void InputIntValidation(ref int id)
        {
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("Invalid Number , Please try again ");
            }
        }
    }
   
}

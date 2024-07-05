using System;
using System.Collections.Generic;
using EmployeeMangmentApp;

namespace EmployeeSystem1
{
    public class Salary 
    {
       
        public float SalaryPerMonth { get; set; }
        public int GetRaised { get; set; }
        public float Bonuses { get; set; }
        public Salary()
        {
            
        }
        public Salary(float salary)
        {
            this.SalaryPerMonth = salary;
            
        }
        public void UpdateSalary()
        {
            Console.WriteLine("===================Update Salary===================");
            Console.WriteLine("Please enter the id");
            int id = 0;
            ValidationStaticMethods.InputIntValidation(ref id);
            float NewSalary = 0;
            float.TryParse(Console.ReadLine(), out NewSalary);
            this.SalaryPerMonth = NewSalary;
            Console.WriteLine("==============Salary has benn updated==============");
        }
        public void AnnualRaise()
        {
            Console.WriteLine("===================Annual Raise===================");
            Console.WriteLine("Please enter the id");
            int id = 0;
            ValidationStaticMethods.InputIntValidation(ref id);
            int raise = 0;
            int.TryParse(Console.ReadLine(), out raise);
            this.GetRaised = raise;
            Console.WriteLine("=========Annual Raise Has been added=========");

        }
        public void GetBonuse()
        {
            Console.WriteLine("===================Bonuse===================");
            Console.WriteLine("Please enter the id");
            int id = 0;
            ValidationStaticMethods.InputIntValidation(ref id);
            float bonues = 0;
            float.TryParse(Console.ReadLine(), out bonues);
            this.Bonuses = bonues;
            Console.WriteLine("=========Bonus H]has been added=========");
        }
        public float SalaryPerYear()
        {
            return SalaryPerMonth * 12;
        }
        public float DayDeduction()
        {
            return SalaryPerMonth * 0.035f;
        }
        public double NumOfDaysDeduction(Byte num)
        {
            return DayDeduction() * num;
        }


    }
}

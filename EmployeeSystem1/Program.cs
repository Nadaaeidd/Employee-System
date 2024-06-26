using System;
using System.Collections.Generic;

namespace EmployeeMangmentApp
{
    internal class Program
    {
        class Employees
        {

            public int id { get; set; }
            public char gender { get; set; }
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string email { get; set; }
            public string phone { get; set; }
            public string status { get; set; }
            public string department { get; set; }
            public string age { get; set; }
            public DateTime startDate { get; set; }


            public Employees(int id, char gender, string firstName, string lasttName, string age, string email, string phone, string status, string department, DateTime startDate)
            {
                this.id = id;
                this.gender = gender;
                this.firstName = firstName;
                this.lastName = lasttName;
                this.age = age;
                this.email = email;
                this.phone = phone;
                this.status = status;
                this.department = department;
                this.startDate = startDate;
            }
        }
        class TheStaff
        {
            List<Employees> employees;
            public TheStaff()
            {
                employees = new List<Employees>();
            }
            public void AddEmployee()
            {
                Console.WriteLine("===================Add Employer===================");
                Console.Write("Enter Id :");
                int id = 0;
                InputIntValidation(ref id);

                Console.Write("Enter FirstName :");
                string firstName = Console.ReadLine();

                Console.Write("Enter LastName :");
                string lastName = Console.ReadLine();

                Console.Write("Enter Age :");
                string age = Console.ReadLine();

                Console.Write("Enter Gender (M/f) :");
                char gender = char.Parse(Console.ReadLine());

                Console.Write("Enter Department :");
                string department = Console.ReadLine();

                Console.Write("Enter Email  :");
                string email = Console.ReadLine();

                Console.Write("Enter Phone :");
                string phone = Console.ReadLine();

                Console.Write("Enter Status :");
                string status = Console.ReadLine();

                Console.Write("Enter joining Date (yyyy-mm-dd) : ");
                string StringData = Console.ReadLine();
                DateTime joiningData;
                DateTime.TryParse(StringData, out joiningData);


                employees.Add(new Employees(id, gender, firstName, lastName, age, email, phone, status, department, joiningData));

                Console.WriteLine("===========Employee added successfully!===========");


            }

            public void UpdateEmployee()
            {
                Console.WriteLine("=================Update Employee =================");
                Console.WriteLine("Enter the id : ");

                int id = 0;
                InputIntValidation(ref id);
                Employees EmployeeToUpdate = employees.Find(emp => emp.id == id);

                if (EmployeeToUpdate != null)
                {
                    int choiceToUpdateint = 0;
                    Console.WriteLine("choice to update : \n1) Id\n2)Firstname\n3)Lastname\n4)Age\n5)Depatment\n6)Gender\n7)Email\n8)Phone\n9)Status\n10)Joining Date");
                    char answer = 'y';
                    do
                    {
                        InputIntValidation(ref choiceToUpdateint);

                        switch (choiceToUpdateint)
                        {
                            case 1:
                                {
                                    Console.Write("Enter new ID : ");
                                    int newId = int.Parse(Console.ReadLine());
                                    EmployeeToUpdate.id = newId;
                                    ChangeAnotherCell(ref answer);
                                    break;
                                }

                            case 2:
                                {
                                    Console.Write("Enter new firstname : ");
                                    string newName = Console.ReadLine();
                                    EmployeeToUpdate.firstName = newName;
                                    ChangeAnotherCell(ref answer);
                                    break;
                                }

                            case 3:
                                {
                                    Console.Write("Enter new lastname : ");
                                    string newLastname = Console.ReadLine();
                                    EmployeeToUpdate.lastName = newLastname;
                                    ChangeAnotherCell(ref answer);
                                    break;
                                }

                            case 4:
                                {
                                    Console.Write("Enter new age : ");
                                    string newAge = Console.ReadLine();
                                    EmployeeToUpdate.age = newAge;
                                    ChangeAnotherCell(ref answer);
                                    break;
                                }
                            case 5:
                                {
                                    Console.Write("Enter new department : ");
                                    string dep = Console.ReadLine();
                                    EmployeeToUpdate.department = dep;
                                    ChangeAnotherCell(ref answer);
                                    break;
                                }
                            case 6:
                                {
                                    Console.Write("Enter new Gender : ");
                                    char newgender = char.Parse(Console.ReadLine());
                                    EmployeeToUpdate.gender = newgender;
                                    ChangeAnotherCell(ref answer);
                                    break;
                                }
                            case 7:
                                {
                                    Console.Write("Enter new Email : ");
                                    string newEmail = Console.ReadLine();
                                    EmployeeToUpdate.email = newEmail;
                                    ChangeAnotherCell(ref answer);
                                    break;
                                }
                            case 8:
                                {
                                    Console.Write("Enter new phone : ");
                                    string newPhone = Console.ReadLine();
                                    EmployeeToUpdate.phone = newPhone;
                                    ChangeAnotherCell(ref answer);
                                    break;
                                }
                            case 9:
                                {
                                    Console.Write("Enter new Status : ");
                                    string newStatus = Console.ReadLine();
                                    EmployeeToUpdate.status = newStatus;
                                    ChangeAnotherCell(ref answer);
                                    break;
                                }
                            case 10:
                                {
                                    Console.Write("Enter new Joining Date (yyyy-mm-dd) : ");
                                    string newData = Console.ReadLine();
                                    DateTime.TryParse(newData, out var date);
                                    EmployeeToUpdate.startDate = date;
                                    ChangeAnotherCell(ref answer);
                                    break;
                                }
                            default:
                                {
                                    Console.WriteLine("Invalid choice,try again");
                                    break;
                                }
                        }

                    } while (answer == 'y' || answer == 'Y');

                }
                else
                {
                    Console.WriteLine("Employee not found");
                }
                Console.WriteLine("=================Employee Updated================");
            }
            public void ChangeAnotherCell(ref char ans)
            {
                Console.WriteLine("Do you want to change another cell");
                char.TryParse(Console.ReadLine(), out ans);
                Console.WriteLine((ans == 'y'||ans=='Y') ? "Please choice number from the list " : " ");
            }
            public void InputIntValidation(ref int id)
            {
                while (!int.TryParse(Console.ReadLine(), out id))
                {
                    Console.WriteLine("Invalid Id , Please try again ");
                }
            }


            public void PrintSpecificEmployee()
            {
                int id = 0;
                Console.WriteLine("===================Print Employee===================");
                Console.Write("Enter Id : ");
                InputIntValidation(ref id);
                Employees employeeToPrint = employees.Find(em => em.id == id);

                Console.WriteLine($"=================== {employeeToPrint.firstName} {employeeToPrint.lastName}'s Info ===================");
                Console.WriteLine($"Firstname: {employeeToPrint.firstName}");
                Console.WriteLine($"Lastname: {employeeToPrint.lastName}");
                Console.WriteLine($"Age: {employeeToPrint.age}");
                Console.WriteLine($"Gender: {employeeToPrint.gender}");
                Console.WriteLine($"Department: {employeeToPrint.department}");
                Console.WriteLine($"phone: {employeeToPrint.phone}");
                Console.WriteLine($"Email: {employeeToPrint.email}");
                Console.WriteLine($"Status: {employeeToPrint.status}");

                Console.WriteLine("========================================================");

            }

            public void PrintAllEmployees()
            {
                foreach (Employees emp in employees)
                {
                    Console.WriteLine($"=================== {emp.firstName} {emp.lastName}'s Info ===================");
                    Console.WriteLine($"Firstname: {emp.firstName}");
                    Console.WriteLine($"Lastname: {emp.lastName}");
                    Console.WriteLine($"Age: {emp.age}");
                    Console.WriteLine($"Gender: {emp.gender}");
                    Console.WriteLine($"Department: {emp.department}");
                    Console.WriteLine($"phone: {emp.phone}");
                    Console.WriteLine($"Email: {emp.email}");
                    Console.WriteLine($"Status: {emp.status}");

                    Console.WriteLine("========================================================");

                }
            }
            public void RemoveEmployee()
            {
                Console.WriteLine("======================Removing Employee======================");
                Console.Write("Please Enter The Id :");
                int id = 0;
                InputIntValidation(ref id);
                Employees employeeToRemove = employees.Find(em => em.id == id);
                employees.Remove(employeeToRemove);

                Console.WriteLine("======================Employee has been removed======================");

            }
            public void AnotherTransactionValidation(ref char anotherTran, ref int trans)
            {
                Console.WriteLine("Do you want another transaction(Y/N) ?");
                char.TryParse(Console.ReadLine(), out anotherTran);
                if (anotherTran == 'y' || anotherTran == 'Y') ;
                {
                    Console.WriteLine("Please choice the next Transaction : ");
                    InputIntValidation(ref trans);
                }

            }
        }

        static void Main(string[] args)
        {
            TheStaff st = new TheStaff();
            Console.WriteLine("Choice The Transaction :");
            Console.WriteLine("1)Add Employee\n2)Update Employee\n3)Remove Employee\n4)Print Specific Employee\n5)Print All Employees\n6)Exit");
            int tranNum = 0;
            char anotherTran = 'y';
            st.InputIntValidation(ref tranNum);
            do
            {
                switch (tranNum)
                {
                    case 1:
                        st.AddEmployee();
                        st.AnotherTransactionValidation(ref anotherTran, ref tranNum);

                        break;
                    case 2:
                        st.UpdateEmployee();
                        st.AnotherTransactionValidation(ref anotherTran, ref tranNum);
                        break;
                    case 3:
                        st.RemoveEmployee();
                        st.AnotherTransactionValidation(ref anotherTran, ref tranNum);
                        break;
                    case 4:
                        st.PrintSpecificEmployee();
                        st.AnotherTransactionValidation(ref anotherTran, ref tranNum);
                        break;
                    case 5:
                        st.PrintAllEmployees();
                        st.AnotherTransactionValidation(ref anotherTran, ref tranNum);
                        break;
                    case 6:
                        Console.WriteLine("Exit...");
                        
                        
                        break;
                }
            } while (anotherTran == 'y'|| anotherTran == 'Y');

            Console.ReadKey();

        }
    }
}

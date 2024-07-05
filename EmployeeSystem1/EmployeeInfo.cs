using System;

namespace EmployeeSystem1
{
    internal class EmployeeInfo
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



        public EmployeeInfo(int id, char gender, string firstName, string lasttName, string age, string email, string phone, string status, string department, DateTime startDate)
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
    
}


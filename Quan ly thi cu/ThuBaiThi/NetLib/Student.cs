using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace NetLib
{
    [Serializable]
    public class Student
    {
        public string MSSV { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get { return LastName + " " + FirstName; } }
        public Student()
        {

        }

        public Student(string mssv, string firstName, string lastName)
        {
            MSSV = mssv;
            FirstName = firstName;
            LastName = lastName;
        }
        public Student(DataRow row)
        {
            MSSV = row["MSSV"].ToString();
            LastName = row["HoDem"].ToString();
            FirstName = row["Ten"].ToString();
        }
    }
}

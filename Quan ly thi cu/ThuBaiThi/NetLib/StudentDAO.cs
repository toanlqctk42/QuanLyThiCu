using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetLib
{
	public class StudentDAO
	{
		private StudentDAO() { }

		private static StudentDAO _instance;
		public static StudentDAO Instance
		{
			get
			{
				if (_instance == null)
				{
					_instance = new StudentDAO();
				}
				return _instance;
			}
		}

		public List<Student> GetStudents()
		{
			List<Student> students = new List<Student>();
			string query = "select MSSV , HoDem , Ten from StudentSQL";

			DataTable table = DataProvider.Instance.ExecuteQuery(query);

			foreach (DataRow row in table.Rows)
			{
				Student student = new Student(row);
				students.Add(student);
			}

			return students;
		}
	}
}

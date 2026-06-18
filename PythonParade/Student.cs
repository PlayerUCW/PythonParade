using System;

namespace PythonParade
{
	[Serializable]
	class Student
	{
		private string _name;
		private string _surname;
		private string _patronym;

		public string Name
		{
			get { return _name; }
			set
			{
				string name = value.Trim();
				if (name == string.Empty) throw new ArgumentException("why student name empty");
				_name = name;
			}
		}

		public string Surname
		{
			get { return _surname; }
			set
			{
				string surname = value.Trim();
				if (surname == string.Empty) throw new ArgumentException("why student surname empty");
				_surname = surname;
			}
		}

		public string Patronym
		{
			get { return _patronym; }
			set
			{
				string patronym = value.Trim();
				_patronym = patronym;
			}
		}

		public Student(string name, string surname, string patronym = "")
		{
			Name = name;
			Surname = surname;
			Patronym = patronym;
		}

		private static bool Equals(Student left, Student right)
		{
			if ((left is null) || (right is null))
				return false;
			return
				(left.Name == right.Name) &&
				(left.Surname == right.Surname) &&
				(left.Patronym == right.Patronym);
		}

		public static bool operator ==(Student left, Student right)
		{
			return Equals(left, right);
		}

		public static bool operator !=(Student left, Student right)
		{
			return !Equals(left, right);
		}
	}
}
using System;
using System.Windows.Forms;

namespace PythonParade
{
	public enum FullNameFormat
	{
		SurnameNamePatronym,
		SurnameName
	}

	[Serializable]
	public class Student
	{
		private string _surname;
		private string _name;
		private string _patronym;

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

		public string Patronym
		{
			get { return _patronym; }
			set
			{
				string patronym = value.Trim();
				_patronym = patronym;
			}
		}

		public Student(string surname, string name, string patronym = "")
		{
			Surname = surname;
			Name = name;
			Patronym = patronym;
		}

		private static bool Equals(Student left, Student right)
		{
			if ((left is null) || (right is null))
				return false;
			return
				(left.Surname == right.Surname) &&
				(left.Name == right.Name) &&
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

		public string GetFullName(FullNameFormat format = FullNameFormat.SurnameNamePatronym)
		{
			switch (format)
			{
				default:
				case (FullNameFormat.SurnameNamePatronym):
				{
					return $"{Surname} {Name} {Patronym}";
				}
				case (FullNameFormat.SurnameName):
				{
					return $"{Surname} {Name}";
				}
			}
		}

		public ListViewItem GetListViewItem(FullNameFormat format = FullNameFormat.SurnameNamePatronym)
		{
			ListViewItem item = new ListViewItem();
			switch (format)
			{
				default:
				case (FullNameFormat.SurnameNamePatronym):
				{
					item.Text = Surname;
					item.SubItems.Add(Name);
					item.SubItems.Add(Patronym);
					break;
				}
				case (FullNameFormat.SurnameName):
				{
					item.Text = Surname;
					item.SubItems.Add(Name);
					break;
				}
			}
			return item;
		}
	}
}
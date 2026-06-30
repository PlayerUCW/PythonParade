using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.Json.Serialization;
using System.Windows.Forms;

namespace PythonParade
{
	public enum ProjectStatus
	{
		OK,
		Updated,
		Invalid
	}

	[Serializable]
	public class Project
	{
		private static Dictionary<ProjectStatus, Color> _statusColors = new Dictionary<ProjectStatus, Color>
		{
			{ProjectStatus.OK, Color.DarkGreen},
			{ProjectStatus.Updated, Color.DarkBlue},
			{ProjectStatus.Invalid, Color.DarkRed}
		};
		private static Dictionary<ProjectStatus, string> _statusTexts = new Dictionary<ProjectStatus, string>
		{
			{ProjectStatus.OK, "ОК"},
			{ProjectStatus.Updated, "На проверке"},
			{ProjectStatus.Invalid, "Доработка"}
		};

		private string _name;
		private string _description;
		private string _gitHubLink;
		[JsonInclude]
		public List<Student> _authors = new List<Student>();
		private ProjectStatus _status;
		private string _issues;
		private string _filename;

		public string Name
		{
			get { return _name; }
			set
			{
				string name = value.Trim();
				if (name == string.Empty) throw new ArgumentException("why project name empty");
				_name = name;
			}
		}

		public string GitHubLink
		{
			get { return _gitHubLink; }
			set
			{
				string link = value.Trim();
				if (link == string.Empty) throw new ArgumentException("why github link empty");
				_gitHubLink = link;
			}
		}

		public string Description
		{
			get { return _description; }
			set
			{
				_description = value;
			}
		}

		public ProjectStatus Status
		{
			get { return _status; }
			set { _status = value; }
		}

		public string Issues
		{
			get { return _issues; }
			set
			{
				_issues = value;
			}
		}

		public string Filename
		{
			get { return _filename; }
			set
			{
				string filename = value.Trim();
				if (filename == string.Empty) throw new ArgumentException("why filename empty");
				_filename = filename;
			}
		}

		public bool AddAuthor(Student student)
		{
			foreach (Student other in _authors)
			{
				if (student == other) return false;
			}
			_authors.Add(student);
			return true;
		}

		public Project(string name, string gitHubLink, string filename, string desc = "")
		{
			Name = name;
			GitHubLink = gitHubLink;
			Description = desc;
			Status = ProjectStatus.Updated;
			Issues = "";
			Filename = filename;
		}

		// jsonserializer is utterly horrible
		[JsonConstructor]
		public Project()
		{

		}

		public string AuthorsText(FullNameFormat format = FullNameFormat.SurnameNamePatronym)
		{
			List<string> fullNames = new List<string>();
			foreach (Student student in _authors)
			{
				if (student == null) continue;
				fullNames.Add(student.GetFullName(format));
			}
			return string.Join("\n", fullNames);
		}

		public string StatusText()
		{
			return _statusTexts[Status];
		}

		public Color StatusColor()
		{
			return _statusColors[Status];
		}

		public ListViewItem GetListViewItem()
		{
			ListViewItem item = new ListViewItem();
			item.Text = Name;
			item.SubItems.Add(this.StatusText());
			item.Tag = this;
			return item;
		}

		public List<ListViewItem> GetAuthorsListViewItems()
		{
			List<ListViewItem> list = new List<ListViewItem>();
			foreach (Student author in _authors)
			{
				list.Add(author.GetListViewItem());
			}
			return list;
		}
	}
}
using System;
using System.Collections.Generic;

namespace PythonParade
{
	enum ProjectStatus
	{
		OK,
		Updated,
		Invalid
	}

	[Serializable]
	class Project
	{
		private string _name;
		private string _description;
		private string _githubLink;
		private List<Student> _authors;
		private ProjectStatus _status;
		private string _issues;

		public string Name
		{
			get { return _name; }
			private set
			{
				string name = value.Trim();
				if (name == string.Empty) throw new ArgumentException("why project name empty");
				_name = name;
			}
		}

		public string GitHubLink
		{
			get { return _githubLink; }
			private set
			{
				string link = value.Trim();
				if (link == string.Empty) throw new ArgumentException("why github link empty");
				_githubLink = link;
			}
		}

		public string Description
		{
			get { return _description; }
			private set
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
			private set
			{
				_issues = value;
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

		public Project(string name, string githubLink, string desc = "")
		{
			Name = name;
			GitHubLink = githubLink;
			Description = desc;
		}
	}
}
using System;
using System.Windows.Forms;

namespace PythonParade
{
	public partial class AppChoiceForm : Form
	{
		public AppChoiceForm()
		{
			InitializeComponent();
		}

		private void buttonProjects_Click(object sender, EventArgs e)
		{
			ProjectsForm projectsForm = new ProjectsForm();
			projectsForm.Show();
		}

		private void buttonEditor_Click(object sender, EventArgs e)
		{
			EditorForm editorForm = new EditorForm();
			editorForm.Show();
		}

		private void buttonVoting_Click(object sender, EventArgs e)
		{
			
		}

		private void buttonAdmin_Click(object sender, EventArgs e)
		{

		}
	}
}

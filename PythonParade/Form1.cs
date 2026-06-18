using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PythonParade
{
	public partial class AppChoiceForm : Form
	{
		public AppChoiceForm()
		{
			InitializeComponent();
			buttonVoting.Enabled = false;
			buttonAdmin.Enabled = false;
		}

		private void buttonProjects_Click(object sender, EventArgs e)
		{
			ProjectsForm projectsForm = new ProjectsForm();
			projectsForm.Show();
		}
	}
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace PythonParade
{
	public partial class ProjectsForm : Form
	{
		List<Project> projects = new List<Project>();

		public ProjectsForm()
		{
			InitializeComponent();
			LoadProjects();
			UpdateProjects();
			UndisplayProject();
		}

		private void LoadProjects()
		{
			projects.Clear();
			foreach (string filename in Directory.GetFiles(Program.ProjectDirectoryFull))
			{
				StreamReader sr = new StreamReader(filename);
				string json = sr.ReadLine();
				MessageBox.Show(json);
				projects.Add(JsonSerializer.Deserialize<Project>(json));
				sr.Close();
			}
		}

		private void LoadPlaceholderProjects()
		{
			Project test = new Project("Test", "https://example.com", "test.json", "Это - проект-заглушка\r\n1\r\n2\r\n3\r\n4\r\n5\r\n6\r\n7\r\n8\r\n9");
			test.AddAuthor(new Student("Аванов", "Аван", "Аванович"));
			test.AddAuthor(new Student("Басильева", "Басилиса", "Басильевна"));
			test.AddAuthor(new Student("Вавлов", "Вавел", "Вавлович"));
			Project test2 = new Project("Test2", "https://example.com", "test2.json", "Это - проект-заглушка 2\r\n1\r\n2\r\n3\r\n4\r\n5\r\n6\r\n7\r\n8\r\n9");
			test2.AddAuthor(new Student("Аванов", "Аван", "Аванович"));
			test2.AddAuthor(new Student("Басильева", "Басилиса", "Басильевна"));
			test2.AddAuthor(new Student("Вавлов", "Вавел", "Вавлович"));
			projects.Add(test);
			projects.Add(test2);
		}

		private void UpdateProjects()
		{
			listViewProjects.Items.Clear();
			foreach (Project project in projects)
			{
				listViewProjects.Items.Add(project.GetListViewItem());
			}
			listViewProjects.SelectedItems.Clear();
		}

		private void DisplayProject()
		{
			if (listViewProjects.SelectedItems.Count < 1)
			{
				throw new Exception("nothing to display");
			}
			Project selectedProject = listViewProjects.SelectedItems[0].Tag as Project;

			lAuthors.Show();
			lGitHubLink.Show();
			lStatus.Show();

			labelAuthors.Show();
			linkLabelGitHub.Show();
			labelStatus.Show();

			buttonEdit.Enabled = true;

			labelName.Text = selectedProject.Name;
			labelAuthors.Text = selectedProject.AuthorsText(FullNameFormat.SurnameNamePatronym);
			labelDescription.Text = selectedProject.Description;
			linkLabelGitHub.Text = selectedProject.GitHubLink;
			labelStatus.Text = selectedProject.StatusText();
			labelStatus.ForeColor = selectedProject.StatusColor();

			if (selectedProject.Issues != "")
			{
				lIssues.Show();
				labelIssues.Show();
				labelIssues.Text = selectedProject.Issues;
			}
			else
			{
				lIssues.Hide();
				labelIssues.Hide();
			}
		}

		private void UndisplayProject()
		{
			lAuthors.Hide();
			lGitHubLink.Hide();
			lStatus.Hide();
			lIssues.Hide();

			labelAuthors.Hide();
			linkLabelGitHub.Hide();
			labelStatus.Hide();
			labelIssues.Hide();

			buttonEdit.Enabled = false;

			labelName.Text = "Выберите проект";
			labelDescription.Text = "Здесь появится информация о выбранном проекте";
		}

		private void listViewProjects_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (listViewProjects.SelectedItems.Count > 0)
			{
				DisplayProject();
			}
			else
			{
				UndisplayProject();
			}
		}

		private void buttonDeselect_Click(object sender, EventArgs e)
		{
			listViewProjects.SelectedItems.Clear();
		}

		private void buttonReload_Click(object sender, EventArgs e)
		{
			UndisplayProject();
			LoadProjects();
			UpdateProjects();
		}

		private void buttonNew_Click(object sender, EventArgs e)
		{
			EditorForm editorForm = new EditorForm();
			editorForm.Show();
		}

		private void buttonEdit_Click(object sender, EventArgs e)
		{
			if (listViewProjects.SelectedItems.Count > 0)
			{
				Project selectedProject = listViewProjects.SelectedItems[0].Tag as Project;
				EditorForm editorForm = new EditorForm(selectedProject);
				editorForm.Show();
			}
			else
			{
				throw new Exception("nothing to edit");
			}
		}

		private void linkLabelGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			ProcessStartInfo sInfo = new ProcessStartInfo(linkLabelGitHub.Text);
			Process.Start(sInfo);
		}
	}
}

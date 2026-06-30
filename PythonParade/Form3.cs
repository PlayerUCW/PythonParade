using System;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace PythonParade
{
	public partial class EditorForm : Form
	{
		string _savingIssuesText = string.Empty;

		public EditorForm(Project project = null)
		{
			InitializeComponent();
			DeselectAuthor();
			if (project != null)
			{
				LoadProject(project);
			}
		}

		private void UpdateSavingIssues()
		{
			labelSavingIssues.Text = _savingIssuesText;
		}

		private void LoadProject(Project project)
		{
			if (project == null) return;
			UnhighlightInfo();
			listViewAuthors.Items.Clear();

			textBoxProjectName.Text = project.Name;
			textBoxProjectDescription.Text = project.Description;
			textBoxProjectGitHubLink.Text = project.GitHubLink;
			foreach (ListViewItem item in project.GetAuthorsListViewItems())
			{
				listViewAuthors.Items.Add(item);
			}
			textBoxFilename.Text = project.Filename;
			labelIssues.Text = project.Issues;
		}

		private void UnhighlightInfo()
		{
			textBoxProjectName.BackColor = System.Drawing.SystemColors.Window;
			textBoxProjectGitHubLink.BackColor = System.Drawing.SystemColors.Window;
			textBoxFilename.BackColor = System.Drawing.SystemColors.Window;
		}

		private void UnhighlightAuthor()
		{
			textBoxAuthorSurname.BackColor = System.Drawing.SystemColors.Window;
			textBoxAuthorName.BackColor = System.Drawing.SystemColors.Window;
			textBoxAuthorPatronym.BackColor = System.Drawing.SystemColors.Window;
		}

		private void SelectAuthor()
		{
			ListViewItem selected = listViewAuthors.SelectedItems[0];

			textBoxAuthorSurname.Text = selected.SubItems[0].Text;
			textBoxAuthorName.Text = selected.SubItems[1].Text;
			textBoxAuthorPatronym.Text = selected.SubItems[2].Text;

			buttonAuthorDelete.Enabled = true;
			buttonAuthorApply.Text = "Изменить";
		}

		private void DeselectAuthor()
		{
			textBoxAuthorSurname.Text = string.Empty;
			textBoxAuthorName.Text = string.Empty;
			textBoxAuthorPatronym.Text = string.Empty;

			buttonAuthorDelete.Enabled = false;
			buttonAuthorApply.Text = "Добавить";
		}

		private bool ValidateAuthor()
		{
			UnhighlightAuthor();

			string surname = textBoxAuthorSurname.Text.Trim();
			string name = textBoxAuthorName.Text.Trim();

			bool surnameCorrect = surname != string.Empty;
			bool nameCorrect = name != string.Empty;

			if (!surnameCorrect)
			{
				textBoxAuthorSurname.BackColor = System.Drawing.Color.LightPink;
			}
			if (!nameCorrect)
			{
				textBoxAuthorName.BackColor = System.Drawing.Color.LightPink;
			}

			return surnameCorrect && nameCorrect;
		}

		private bool ValidateInfo()
		{
			UnhighlightInfo();
			_savingIssuesText = string.Empty;

			string name = textBoxProjectName.Text.Trim();
			string gitHubLink = textBoxProjectGitHubLink.Text.Trim();
			string filename = textBoxFilename.Text.Trim();

			bool nameCorrect = name != string.Empty;
			bool gitHubLinkCorrect = gitHubLink != string.Empty;
			bool filenameCorrect = filename != string.Empty;

			if (!nameCorrect)
			{
				textBoxProjectName.BackColor = System.Drawing.Color.LightPink;
				_savingIssuesText += "- Название проекта не должно быть пустым\r\n";
			}
			if (!gitHubLinkCorrect)
			{
				textBoxProjectGitHubLink.BackColor = System.Drawing.Color.LightPink;
				_savingIssuesText += "- Ссылка на GitHub-репозиторий не должна быть пустой\r\n";
			}
			if (!filenameCorrect)
			{
				if (!GetFilenameFromSaveFileDialog())
				{
					textBoxFilename.BackColor = System.Drawing.Color.LightPink;
					_savingIssuesText += "- Имя файла для сохранения не должно быть пустым\r\n";
				}
				else
				{
					filenameCorrect = true;
				}
			}

			UpdateSavingIssues();
			return nameCorrect && gitHubLinkCorrect && filenameCorrect;
		}

		private bool GetFilenameFromSaveFileDialog()
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.InitialDirectory = Program.ProjectDirectoryFull;
			saveFileDialog.Filter = "Файлы проектов|*.json";
			DialogResult result = saveFileDialog.ShowDialog();
			if (result == DialogResult.OK)
			{
				string[] fullFilename = saveFileDialog.FileName.Split('\\');
				textBoxFilename.Text = fullFilename[fullFilename.Length - 1];
				return true;
			}
			else
			{
				return false;
			}
		}

		private void listViewAuthors_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (listViewAuthors.SelectedItems.Count > 0)
			{
				SelectAuthor();
			}
			else
			{
				DeselectAuthor();
			}
			UnhighlightAuthor();
		}

		private void buttonAuthorApply_Click(object sender, EventArgs e)
		{
			if (!ValidateAuthor())
			{
				toolStripStatusLabel.Text = "Имя или фамилия автора не указаны";
				return;
			}
			string surname = textBoxAuthorSurname.Text.Trim();
			string name = textBoxAuthorName.Text.Trim();
			string patronym = textBoxAuthorPatronym.Text.Trim();
			ListViewItem item;
			if (listViewAuthors.SelectedItems.Count > 0)
			{
				item = listViewAuthors.SelectedItems[0];
				item.SubItems[0].Text = surname;
				item.SubItems[1].Text = name;
				item.SubItems[2].Text = patronym;
				toolStripStatusLabel.Text = "ФИО автора обновлены";
			}
			else
			{
				item = new ListViewItem();
				item.Text = surname;
				item.SubItems.Add(name);
				item.SubItems.Add(patronym);
				listViewAuthors.Items.Add(item);
				item.Selected = true;
				toolStripStatusLabel.Text = "Автор добавлен";
			}
		}

		private void buttonAuthorDelete_Click(object sender, EventArgs e)
		{
			if (listViewAuthors.SelectedItems.Count > 0)
			{
				listViewAuthors.Items.Remove(listViewAuthors.SelectedItems[0]);
			}
			else
			{
				throw new Exception("nothing to delete");
			}
		}

		private void buttonSave_Click(object sender, EventArgs e)
		{
			if (!ValidateInfo())
			{
				toolStripStatusLabel.Text = "Не удалось сохранить проект - см. Требуемые правки";
				return;
			}
			string name = textBoxProjectName.Text.Trim();
			string gitHubLink = textBoxProjectGitHubLink.Text.Trim();
			string filename = textBoxFilename.Text.Trim();
			string description = textBoxProjectDescription.Text.Trim();

			Project project = new Project(name, gitHubLink, filename, description);
			foreach (ListViewItem item in listViewAuthors.Items)
			{
				project.AddAuthor(new Student(
					item.SubItems[0].Text,
					item.SubItems[1].Text,
					item.SubItems[2].Text
				));
			}
			if (!checkBoxIssues.Checked)
			{
				project.Issues = labelIssues.Text;
			}

			string fullFilename = Program.ProjectDirectoryFull + filename;
			StreamWriter sw = new StreamWriter(fullFilename);
			sw.WriteLine(JsonSerializer.Serialize(project));
			sw.Close();
			toolStripStatusLabel.Text = "Проект сохранён";

			LoadProject(project);
		}

		private void buttonSelectFilename_Click(object sender, EventArgs e)
		{
			GetFilenameFromSaveFileDialog();
		}
	}
}

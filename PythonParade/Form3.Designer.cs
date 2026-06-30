namespace PythonParade
{
	partial class EditorForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStripMain = new System.Windows.Forms.MenuStrip();
			this.statusStripMain = new System.Windows.Forms.StatusStrip();
			this.layoutInfo = new System.Windows.Forms.TableLayoutPanel();
			this.textBoxProjectGitHubLink = new System.Windows.Forms.TextBox();
			this.lProjectGitHubLink = new System.Windows.Forms.Label();
			this.textBoxProjectDescription = new System.Windows.Forms.TextBox();
			this.lProjectDescription = new System.Windows.Forms.Label();
			this.lProjectName = new System.Windows.Forms.Label();
			this.textBoxProjectName = new System.Windows.Forms.TextBox();
			this.layoutIssues = new System.Windows.Forms.TableLayoutPanel();
			this.labelSavingIssues = new System.Windows.Forms.Label();
			this.labelIssues = new System.Windows.Forms.Label();
			this.lIssues = new System.Windows.Forms.Label();
			this.checkBoxIssues = new System.Windows.Forms.CheckBox();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.splitter2 = new System.Windows.Forms.Splitter();
			this.layoutAuthors = new System.Windows.Forms.TableLayoutPanel();
			this.buttonSave = new System.Windows.Forms.Button();
			this.buttonSelectFilename = new System.Windows.Forms.Button();
			this.textBoxFilename = new System.Windows.Forms.TextBox();
			this.lFilename = new System.Windows.Forms.Label();
			this.buttonAuthorDelete = new System.Windows.Forms.Button();
			this.buttonAuthorApply = new System.Windows.Forms.Button();
			this.textBoxAuthorPatronym = new System.Windows.Forms.TextBox();
			this.textBoxAuthorName = new System.Windows.Forms.TextBox();
			this.textBoxAuthorSurname = new System.Windows.Forms.TextBox();
			this.lAuthorPatronym = new System.Windows.Forms.Label();
			this.lAuthorName = new System.Windows.Forms.Label();
			this.lAuthorSurname = new System.Windows.Forms.Label();
			this.lAuthors = new System.Windows.Forms.Label();
			this.listViewAuthors = new System.Windows.Forms.ListView();
			this.colHeaderSurname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colHeaderPatronym = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.buttonAuthorReset = new System.Windows.Forms.Button();
			this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.statusStripMain.SuspendLayout();
			this.layoutInfo.SuspendLayout();
			this.layoutIssues.SuspendLayout();
			this.layoutAuthors.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStripMain
			// 
			this.menuStripMain.Location = new System.Drawing.Point(0, 0);
			this.menuStripMain.Name = "menuStripMain";
			this.menuStripMain.Size = new System.Drawing.Size(800, 24);
			this.menuStripMain.TabIndex = 0;
			this.menuStripMain.Text = "menuStrip1";
			// 
			// statusStripMain
			// 
			this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
			this.statusStripMain.Location = new System.Drawing.Point(0, 428);
			this.statusStripMain.Name = "statusStripMain";
			this.statusStripMain.Size = new System.Drawing.Size(800, 22);
			this.statusStripMain.TabIndex = 1;
			this.statusStripMain.Text = "statusStrip1";
			// 
			// layoutInfo
			// 
			this.layoutInfo.ColumnCount = 1;
			this.layoutInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.layoutInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.layoutInfo.Controls.Add(this.textBoxProjectGitHubLink, 0, 5);
			this.layoutInfo.Controls.Add(this.lProjectGitHubLink, 0, 4);
			this.layoutInfo.Controls.Add(this.textBoxProjectDescription, 0, 3);
			this.layoutInfo.Controls.Add(this.lProjectDescription, 0, 2);
			this.layoutInfo.Controls.Add(this.lProjectName, 0, 0);
			this.layoutInfo.Controls.Add(this.textBoxProjectName, 0, 1);
			this.layoutInfo.Dock = System.Windows.Forms.DockStyle.Left;
			this.layoutInfo.Location = new System.Drawing.Point(0, 24);
			this.layoutInfo.Name = "layoutInfo";
			this.layoutInfo.RowCount = 6;
			this.layoutInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.layoutInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.layoutInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.layoutInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.layoutInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.layoutInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.layoutInfo.Size = new System.Drawing.Size(250, 404);
			this.layoutInfo.TabIndex = 2;
			// 
			// textBoxProjectGitHubLink
			// 
			this.textBoxProjectGitHubLink.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxProjectGitHubLink.Location = new System.Drawing.Point(3, 382);
			this.textBoxProjectGitHubLink.Name = "textBoxProjectGitHubLink";
			this.textBoxProjectGitHubLink.Size = new System.Drawing.Size(244, 20);
			this.textBoxProjectGitHubLink.TabIndex = 5;
			// 
			// lProjectGitHubLink
			// 
			this.lProjectGitHubLink.AutoSize = true;
			this.lProjectGitHubLink.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lProjectGitHubLink.Location = new System.Drawing.Point(3, 359);
			this.lProjectGitHubLink.Name = "lProjectGitHubLink";
			this.lProjectGitHubLink.Size = new System.Drawing.Size(244, 20);
			this.lProjectGitHubLink.TabIndex = 4;
			this.lProjectGitHubLink.Text = "Ссылка на GitHub-репозиторий:";
			this.lProjectGitHubLink.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// textBoxProjectDescription
			// 
			this.textBoxProjectDescription.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxProjectDescription.Location = new System.Drawing.Point(3, 68);
			this.textBoxProjectDescription.Multiline = true;
			this.textBoxProjectDescription.Name = "textBoxProjectDescription";
			this.textBoxProjectDescription.Size = new System.Drawing.Size(244, 288);
			this.textBoxProjectDescription.TabIndex = 3;
			// 
			// lProjectDescription
			// 
			this.lProjectDescription.AutoSize = true;
			this.lProjectDescription.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lProjectDescription.Location = new System.Drawing.Point(3, 45);
			this.lProjectDescription.Name = "lProjectDescription";
			this.lProjectDescription.Size = new System.Drawing.Size(244, 20);
			this.lProjectDescription.TabIndex = 2;
			this.lProjectDescription.Text = "Описание:";
			this.lProjectDescription.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// lProjectName
			// 
			this.lProjectName.AutoSize = true;
			this.lProjectName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lProjectName.Location = new System.Drawing.Point(3, 0);
			this.lProjectName.Name = "lProjectName";
			this.lProjectName.Size = new System.Drawing.Size(244, 20);
			this.lProjectName.TabIndex = 0;
			this.lProjectName.Text = "Название:";
			this.lProjectName.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// textBoxProjectName
			// 
			this.textBoxProjectName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxProjectName.Location = new System.Drawing.Point(3, 23);
			this.textBoxProjectName.Name = "textBoxProjectName";
			this.textBoxProjectName.Size = new System.Drawing.Size(244, 20);
			this.textBoxProjectName.TabIndex = 1;
			// 
			// layoutIssues
			// 
			this.layoutIssues.ColumnCount = 1;
			this.layoutIssues.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.layoutIssues.Controls.Add(this.labelSavingIssues, 0, 2);
			this.layoutIssues.Controls.Add(this.labelIssues, 0, 1);
			this.layoutIssues.Controls.Add(this.lIssues, 0, 0);
			this.layoutIssues.Controls.Add(this.checkBoxIssues, 0, 3);
			this.layoutIssues.Dock = System.Windows.Forms.DockStyle.Right;
			this.layoutIssues.Location = new System.Drawing.Point(600, 24);
			this.layoutIssues.Name = "layoutIssues";
			this.layoutIssues.RowCount = 4;
			this.layoutIssues.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.layoutIssues.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.layoutIssues.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.layoutIssues.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.layoutIssues.Size = new System.Drawing.Size(200, 404);
			this.layoutIssues.TabIndex = 3;
			// 
			// labelSavingIssues
			// 
			this.labelSavingIssues.AutoSize = true;
			this.layoutIssues.SetColumnSpan(this.labelSavingIssues, 3);
			this.labelSavingIssues.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelSavingIssues.Location = new System.Drawing.Point(3, 199);
			this.labelSavingIssues.Name = "labelSavingIssues";
			this.labelSavingIssues.Size = new System.Drawing.Size(194, 179);
			this.labelSavingIssues.TabIndex = 4;
			this.labelSavingIssues.Text = "...";
			// 
			// labelIssues
			// 
			this.labelIssues.AutoSize = true;
			this.layoutIssues.SetColumnSpan(this.labelIssues, 3);
			this.labelIssues.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelIssues.Location = new System.Drawing.Point(3, 20);
			this.labelIssues.Name = "labelIssues";
			this.labelIssues.Size = new System.Drawing.Size(194, 179);
			this.labelIssues.TabIndex = 3;
			this.labelIssues.Text = "...";
			// 
			// lIssues
			// 
			this.lIssues.AutoSize = true;
			this.layoutIssues.SetColumnSpan(this.lIssues, 3);
			this.lIssues.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lIssues.Location = new System.Drawing.Point(3, 0);
			this.lIssues.Name = "lIssues";
			this.lIssues.Size = new System.Drawing.Size(194, 20);
			this.lIssues.TabIndex = 2;
			this.lIssues.Text = "Требуемые правки:";
			this.lIssues.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// checkBoxIssues
			// 
			this.checkBoxIssues.AutoSize = true;
			this.checkBoxIssues.Checked = true;
			this.checkBoxIssues.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxIssues.Dock = System.Windows.Forms.DockStyle.Fill;
			this.checkBoxIssues.Location = new System.Drawing.Point(3, 381);
			this.checkBoxIssues.Name = "checkBoxIssues";
			this.checkBoxIssues.Size = new System.Drawing.Size(194, 20);
			this.checkBoxIssues.TabIndex = 5;
			this.checkBoxIssues.Text = "Правки выполнены";
			this.checkBoxIssues.UseVisualStyleBackColor = true;
			// 
			// splitter1
			// 
			this.splitter1.BackColor = System.Drawing.SystemColors.ControlLight;
			this.splitter1.Location = new System.Drawing.Point(250, 24);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(3, 404);
			this.splitter1.TabIndex = 4;
			this.splitter1.TabStop = false;
			// 
			// splitter2
			// 
			this.splitter2.BackColor = System.Drawing.SystemColors.ControlLight;
			this.splitter2.Dock = System.Windows.Forms.DockStyle.Right;
			this.splitter2.Location = new System.Drawing.Point(597, 24);
			this.splitter2.Name = "splitter2";
			this.splitter2.Size = new System.Drawing.Size(3, 404);
			this.splitter2.TabIndex = 5;
			this.splitter2.TabStop = false;
			// 
			// layoutAuthors
			// 
			this.layoutAuthors.ColumnCount = 3;
			this.layoutAuthors.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.layoutAuthors.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.layoutAuthors.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.layoutAuthors.Controls.Add(this.buttonSave, 0, 7);
			this.layoutAuthors.Controls.Add(this.buttonSelectFilename, 2, 6);
			this.layoutAuthors.Controls.Add(this.textBoxFilename, 0, 6);
			this.layoutAuthors.Controls.Add(this.lFilename, 0, 5);
			this.layoutAuthors.Controls.Add(this.buttonAuthorDelete, 2, 4);
			this.layoutAuthors.Controls.Add(this.buttonAuthorApply, 1, 4);
			this.layoutAuthors.Controls.Add(this.textBoxAuthorPatronym, 2, 3);
			this.layoutAuthors.Controls.Add(this.textBoxAuthorName, 1, 3);
			this.layoutAuthors.Controls.Add(this.textBoxAuthorSurname, 0, 3);
			this.layoutAuthors.Controls.Add(this.lAuthorPatronym, 2, 2);
			this.layoutAuthors.Controls.Add(this.lAuthorName, 1, 2);
			this.layoutAuthors.Controls.Add(this.lAuthorSurname, 0, 2);
			this.layoutAuthors.Controls.Add(this.lAuthors, 0, 0);
			this.layoutAuthors.Controls.Add(this.listViewAuthors, 0, 1);
			this.layoutAuthors.Controls.Add(this.buttonAuthorReset, 0, 4);
			this.layoutAuthors.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutAuthors.Location = new System.Drawing.Point(253, 24);
			this.layoutAuthors.Name = "layoutAuthors";
			this.layoutAuthors.RowCount = 8;
			this.layoutAuthors.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.layoutAuthors.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.layoutAuthors.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.layoutAuthors.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.layoutAuthors.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.layoutAuthors.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
			this.layoutAuthors.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.layoutAuthors.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
			this.layoutAuthors.Size = new System.Drawing.Size(344, 404);
			this.layoutAuthors.TabIndex = 6;
			// 
			// buttonSave
			// 
			this.layoutAuthors.SetColumnSpan(this.buttonSave, 3);
			this.buttonSave.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonSave.Location = new System.Drawing.Point(3, 362);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(338, 39);
			this.buttonSave.TabIndex = 15;
			this.buttonSave.Text = "Сохранить проект";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// buttonSelectFilename
			// 
			this.buttonSelectFilename.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonSelectFilename.Location = new System.Drawing.Point(231, 332);
			this.buttonSelectFilename.Name = "buttonSelectFilename";
			this.buttonSelectFilename.Size = new System.Drawing.Size(110, 24);
			this.buttonSelectFilename.TabIndex = 14;
			this.buttonSelectFilename.Text = "Выбрать файл...";
			this.buttonSelectFilename.UseVisualStyleBackColor = true;
			this.buttonSelectFilename.Click += new System.EventHandler(this.buttonSelectFilename_Click);
			// 
			// textBoxFilename
			// 
			this.layoutAuthors.SetColumnSpan(this.textBoxFilename, 2);
			this.textBoxFilename.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxFilename.Location = new System.Drawing.Point(3, 332);
			this.textBoxFilename.Name = "textBoxFilename";
			this.textBoxFilename.Size = new System.Drawing.Size(222, 20);
			this.textBoxFilename.TabIndex = 13;
			// 
			// lFilename
			// 
			this.lFilename.AutoSize = true;
			this.layoutAuthors.SetColumnSpan(this.lFilename, 3);
			this.lFilename.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lFilename.Location = new System.Drawing.Point(3, 269);
			this.lFilename.Name = "lFilename";
			this.lFilename.Size = new System.Drawing.Size(338, 60);
			this.lFilename.TabIndex = 12;
			this.lFilename.Text = "Сохранить как:";
			this.lFilename.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// buttonAuthorDelete
			// 
			this.buttonAuthorDelete.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonAuthorDelete.Location = new System.Drawing.Point(231, 242);
			this.buttonAuthorDelete.Name = "buttonAuthorDelete";
			this.buttonAuthorDelete.Size = new System.Drawing.Size(110, 24);
			this.buttonAuthorDelete.TabIndex = 11;
			this.buttonAuthorDelete.Text = "Удалить";
			this.buttonAuthorDelete.UseVisualStyleBackColor = true;
			this.buttonAuthorDelete.Click += new System.EventHandler(this.buttonAuthorDelete_Click);
			// 
			// buttonAuthorApply
			// 
			this.buttonAuthorApply.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonAuthorApply.Location = new System.Drawing.Point(117, 242);
			this.buttonAuthorApply.Name = "buttonAuthorApply";
			this.buttonAuthorApply.Size = new System.Drawing.Size(108, 24);
			this.buttonAuthorApply.TabIndex = 10;
			this.buttonAuthorApply.Text = "...";
			this.buttonAuthorApply.UseVisualStyleBackColor = true;
			this.buttonAuthorApply.Click += new System.EventHandler(this.buttonAuthorApply_Click);
			// 
			// textBoxAuthorPatronym
			// 
			this.textBoxAuthorPatronym.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxAuthorPatronym.Location = new System.Drawing.Point(231, 217);
			this.textBoxAuthorPatronym.Name = "textBoxAuthorPatronym";
			this.textBoxAuthorPatronym.Size = new System.Drawing.Size(110, 20);
			this.textBoxAuthorPatronym.TabIndex = 8;
			// 
			// textBoxAuthorName
			// 
			this.textBoxAuthorName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxAuthorName.Location = new System.Drawing.Point(117, 217);
			this.textBoxAuthorName.Name = "textBoxAuthorName";
			this.textBoxAuthorName.Size = new System.Drawing.Size(108, 20);
			this.textBoxAuthorName.TabIndex = 7;
			// 
			// textBoxAuthorSurname
			// 
			this.textBoxAuthorSurname.BackColor = System.Drawing.SystemColors.Window;
			this.textBoxAuthorSurname.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxAuthorSurname.Location = new System.Drawing.Point(3, 217);
			this.textBoxAuthorSurname.Name = "textBoxAuthorSurname";
			this.textBoxAuthorSurname.Size = new System.Drawing.Size(108, 20);
			this.textBoxAuthorSurname.TabIndex = 6;
			// 
			// lAuthorPatronym
			// 
			this.lAuthorPatronym.AutoSize = true;
			this.lAuthorPatronym.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lAuthorPatronym.Location = new System.Drawing.Point(231, 194);
			this.lAuthorPatronym.Name = "lAuthorPatronym";
			this.lAuthorPatronym.Size = new System.Drawing.Size(110, 20);
			this.lAuthorPatronym.TabIndex = 5;
			this.lAuthorPatronym.Text = "Отчество";
			this.lAuthorPatronym.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// lAuthorName
			// 
			this.lAuthorName.AutoSize = true;
			this.lAuthorName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lAuthorName.Location = new System.Drawing.Point(117, 194);
			this.lAuthorName.Name = "lAuthorName";
			this.lAuthorName.Size = new System.Drawing.Size(108, 20);
			this.lAuthorName.TabIndex = 4;
			this.lAuthorName.Text = "Имя";
			this.lAuthorName.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// lAuthorSurname
			// 
			this.lAuthorSurname.AutoSize = true;
			this.lAuthorSurname.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lAuthorSurname.Location = new System.Drawing.Point(3, 194);
			this.lAuthorSurname.Name = "lAuthorSurname";
			this.lAuthorSurname.Size = new System.Drawing.Size(108, 20);
			this.lAuthorSurname.TabIndex = 3;
			this.lAuthorSurname.Text = "Фамилия";
			this.lAuthorSurname.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// lAuthors
			// 
			this.lAuthors.AutoSize = true;
			this.layoutAuthors.SetColumnSpan(this.lAuthors, 3);
			this.lAuthors.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lAuthors.Location = new System.Drawing.Point(3, 0);
			this.lAuthors.Name = "lAuthors";
			this.lAuthors.Size = new System.Drawing.Size(338, 20);
			this.lAuthors.TabIndex = 1;
			this.lAuthors.Text = "Авторы:";
			this.lAuthors.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// listViewAuthors
			// 
			this.listViewAuthors.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colHeaderSurname,
            this.colHeaderName,
            this.colHeaderPatronym});
			this.layoutAuthors.SetColumnSpan(this.listViewAuthors, 3);
			this.listViewAuthors.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listViewAuthors.FullRowSelect = true;
			this.listViewAuthors.HideSelection = false;
			this.listViewAuthors.Location = new System.Drawing.Point(3, 23);
			this.listViewAuthors.MultiSelect = false;
			this.listViewAuthors.Name = "listViewAuthors";
			this.listViewAuthors.Size = new System.Drawing.Size(338, 168);
			this.listViewAuthors.TabIndex = 2;
			this.listViewAuthors.UseCompatibleStateImageBehavior = false;
			this.listViewAuthors.View = System.Windows.Forms.View.Details;
			this.listViewAuthors.SelectedIndexChanged += new System.EventHandler(this.listViewAuthors_SelectedIndexChanged);
			// 
			// colHeaderSurname
			// 
			this.colHeaderSurname.Text = "Фамилия";
			this.colHeaderSurname.Width = 110;
			// 
			// colHeaderName
			// 
			this.colHeaderName.Text = "Имя";
			this.colHeaderName.Width = 110;
			// 
			// colHeaderPatronym
			// 
			this.colHeaderPatronym.Text = "Отчество";
			this.colHeaderPatronym.Width = 110;
			// 
			// buttonAuthorReset
			// 
			this.buttonAuthorReset.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonAuthorReset.Location = new System.Drawing.Point(3, 242);
			this.buttonAuthorReset.Name = "buttonAuthorReset";
			this.buttonAuthorReset.Size = new System.Drawing.Size(108, 24);
			this.buttonAuthorReset.TabIndex = 9;
			this.buttonAuthorReset.Text = "Сбросить";
			this.buttonAuthorReset.UseVisualStyleBackColor = true;
			this.buttonAuthorReset.Click += new System.EventHandler(this.listViewAuthors_SelectedIndexChanged);
			// 
			// toolStripStatusLabel
			// 
			this.toolStripStatusLabel.Name = "toolStripStatusLabel";
			this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
			// 
			// EditorForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.layoutAuthors);
			this.Controls.Add(this.splitter2);
			this.Controls.Add(this.splitter1);
			this.Controls.Add(this.layoutIssues);
			this.Controls.Add(this.layoutInfo);
			this.Controls.Add(this.statusStripMain);
			this.Controls.Add(this.menuStripMain);
			this.MainMenuStrip = this.menuStripMain;
			this.Name = "EditorForm";
			this.Text = "Python-парад | Редактор проекта";
			this.statusStripMain.ResumeLayout(false);
			this.statusStripMain.PerformLayout();
			this.layoutInfo.ResumeLayout(false);
			this.layoutInfo.PerformLayout();
			this.layoutIssues.ResumeLayout(false);
			this.layoutIssues.PerformLayout();
			this.layoutAuthors.ResumeLayout(false);
			this.layoutAuthors.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStripMain;
		private System.Windows.Forms.StatusStrip statusStripMain;
		private System.Windows.Forms.TableLayoutPanel layoutInfo;
		private System.Windows.Forms.TableLayoutPanel layoutIssues;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.Splitter splitter2;
		private System.Windows.Forms.TableLayoutPanel layoutAuthors;
		private System.Windows.Forms.Label lProjectDescription;
		private System.Windows.Forms.Label lProjectName;
		private System.Windows.Forms.TextBox textBoxProjectName;
		private System.Windows.Forms.Label lProjectGitHubLink;
		private System.Windows.Forms.TextBox textBoxProjectDescription;
		private System.Windows.Forms.TextBox textBoxProjectGitHubLink;
		private System.Windows.Forms.Label lAuthors;
		private System.Windows.Forms.ListView listViewAuthors;
		private System.Windows.Forms.ColumnHeader colHeaderSurname;
		private System.Windows.Forms.ColumnHeader colHeaderName;
		private System.Windows.Forms.ColumnHeader colHeaderPatronym;
		private System.Windows.Forms.Label lAuthorPatronym;
		private System.Windows.Forms.Label lAuthorName;
		private System.Windows.Forms.Label lAuthorSurname;
		private System.Windows.Forms.Button buttonAuthorApply;
		private System.Windows.Forms.TextBox textBoxAuthorPatronym;
		private System.Windows.Forms.TextBox textBoxAuthorName;
		private System.Windows.Forms.TextBox textBoxAuthorSurname;
		private System.Windows.Forms.Button buttonAuthorReset;
		private System.Windows.Forms.Button buttonAuthorDelete;
		private System.Windows.Forms.Label lIssues;
		private System.Windows.Forms.Label lFilename;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.Button buttonSelectFilename;
		private System.Windows.Forms.TextBox textBoxFilename;
		private System.Windows.Forms.Label labelSavingIssues;
		private System.Windows.Forms.Label labelIssues;
		private System.Windows.Forms.CheckBox checkBoxIssues;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
	}
}
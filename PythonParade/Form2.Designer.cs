namespace PythonParade
{
	partial class ProjectsForm
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
			this.layoutProjects = new System.Windows.Forms.TableLayoutPanel();
			this.buttonReload = new System.Windows.Forms.Button();
			this.buttonDeselect = new System.Windows.Forms.Button();
			this.listViewProjects = new System.Windows.Forms.ListView();
			this.colHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colHeaderStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.layoutIssues = new System.Windows.Forms.TableLayoutPanel();
			this.buttonNew = new System.Windows.Forms.Button();
			this.labelIssues = new System.Windows.Forms.Label();
			this.lIssues = new System.Windows.Forms.Label();
			this.labelStatus = new System.Windows.Forms.Label();
			this.lStatus = new System.Windows.Forms.Label();
			this.buttonEdit = new System.Windows.Forms.Button();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.splitter2 = new System.Windows.Forms.Splitter();
			this.layoutInfo = new System.Windows.Forms.TableLayoutPanel();
			this.lGitHubLink = new System.Windows.Forms.Label();
			this.labelDescription = new System.Windows.Forms.Label();
			this.labelAuthors = new System.Windows.Forms.Label();
			this.labelName = new System.Windows.Forms.Label();
			this.lAuthors = new System.Windows.Forms.Label();
			this.linkLabelGitHub = new System.Windows.Forms.LinkLabel();
			this.layoutProjects.SuspendLayout();
			this.layoutIssues.SuspendLayout();
			this.layoutInfo.SuspendLayout();
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
			// layoutProjects
			// 
			this.layoutProjects.ColumnCount = 1;
			this.layoutProjects.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.layoutProjects.Controls.Add(this.buttonReload, 0, 2);
			this.layoutProjects.Controls.Add(this.buttonDeselect, 0, 1);
			this.layoutProjects.Controls.Add(this.listViewProjects, 0, 0);
			this.layoutProjects.Dock = System.Windows.Forms.DockStyle.Left;
			this.layoutProjects.Location = new System.Drawing.Point(0, 24);
			this.layoutProjects.Name = "layoutProjects";
			this.layoutProjects.RowCount = 3;
			this.layoutProjects.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.layoutProjects.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.layoutProjects.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.layoutProjects.Size = new System.Drawing.Size(250, 426);
			this.layoutProjects.TabIndex = 1;
			// 
			// buttonReload
			// 
			this.buttonReload.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonReload.Location = new System.Drawing.Point(3, 399);
			this.buttonReload.Name = "buttonReload";
			this.buttonReload.Size = new System.Drawing.Size(244, 24);
			this.buttonReload.TabIndex = 8;
			this.buttonReload.Text = "Обновить список";
			this.buttonReload.UseVisualStyleBackColor = true;
			this.buttonReload.Click += new System.EventHandler(this.buttonReload_Click);
			// 
			// buttonDeselect
			// 
			this.buttonDeselect.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonDeselect.Location = new System.Drawing.Point(3, 369);
			this.buttonDeselect.Name = "buttonDeselect";
			this.buttonDeselect.Size = new System.Drawing.Size(244, 24);
			this.buttonDeselect.TabIndex = 7;
			this.buttonDeselect.Text = "Сбросить выбор";
			this.buttonDeselect.UseVisualStyleBackColor = true;
			this.buttonDeselect.Click += new System.EventHandler(this.buttonDeselect_Click);
			// 
			// listViewProjects
			// 
			this.listViewProjects.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colHeaderName,
            this.colHeaderStatus});
			this.listViewProjects.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listViewProjects.FullRowSelect = true;
			this.listViewProjects.HideSelection = false;
			this.listViewProjects.Location = new System.Drawing.Point(3, 3);
			this.listViewProjects.MultiSelect = false;
			this.listViewProjects.Name = "listViewProjects";
			this.listViewProjects.Size = new System.Drawing.Size(244, 360);
			this.listViewProjects.TabIndex = 0;
			this.listViewProjects.UseCompatibleStateImageBehavior = false;
			this.listViewProjects.View = System.Windows.Forms.View.Details;
			this.listViewProjects.SelectedIndexChanged += new System.EventHandler(this.listViewProjects_SelectedIndexChanged);
			// 
			// colHeaderName
			// 
			this.colHeaderName.Text = "Название";
			this.colHeaderName.Width = 150;
			// 
			// colHeaderStatus
			// 
			this.colHeaderStatus.Text = "Статус";
			this.colHeaderStatus.Width = 90;
			// 
			// layoutIssues
			// 
			this.layoutIssues.ColumnCount = 1;
			this.layoutIssues.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.layoutIssues.Controls.Add(this.buttonNew, 0, 5);
			this.layoutIssues.Controls.Add(this.labelIssues, 0, 3);
			this.layoutIssues.Controls.Add(this.lIssues, 0, 2);
			this.layoutIssues.Controls.Add(this.labelStatus, 0, 1);
			this.layoutIssues.Controls.Add(this.lStatus, 0, 0);
			this.layoutIssues.Controls.Add(this.buttonEdit, 0, 4);
			this.layoutIssues.Dock = System.Windows.Forms.DockStyle.Right;
			this.layoutIssues.Location = new System.Drawing.Point(550, 24);
			this.layoutIssues.Name = "layoutIssues";
			this.layoutIssues.RowCount = 6;
			this.layoutIssues.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.layoutIssues.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.layoutIssues.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.layoutIssues.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.layoutIssues.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.layoutIssues.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.layoutIssues.Size = new System.Drawing.Size(250, 426);
			this.layoutIssues.TabIndex = 2;
			// 
			// buttonNew
			// 
			this.buttonNew.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonNew.Location = new System.Drawing.Point(3, 399);
			this.buttonNew.Name = "buttonNew";
			this.buttonNew.Size = new System.Drawing.Size(244, 24);
			this.buttonNew.TabIndex = 7;
			this.buttonNew.Text = "Новый проект,,,";
			this.buttonNew.UseVisualStyleBackColor = true;
			this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
			// 
			// labelIssues
			// 
			this.labelIssues.AutoSize = true;
			this.labelIssues.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelIssues.Location = new System.Drawing.Point(3, 60);
			this.labelIssues.Name = "labelIssues";
			this.labelIssues.Size = new System.Drawing.Size(244, 306);
			this.labelIssues.TabIndex = 5;
			this.labelIssues.Text = "...";
			// 
			// lIssues
			// 
			this.lIssues.AutoSize = true;
			this.lIssues.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lIssues.Location = new System.Drawing.Point(3, 40);
			this.lIssues.Name = "lIssues";
			this.lIssues.Size = new System.Drawing.Size(244, 20);
			this.lIssues.TabIndex = 4;
			this.lIssues.Text = "Требуемые правки:";
			this.lIssues.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// labelStatus
			// 
			this.labelStatus.AutoSize = true;
			this.labelStatus.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelStatus.Location = new System.Drawing.Point(3, 20);
			this.labelStatus.Name = "labelStatus";
			this.labelStatus.Size = new System.Drawing.Size(244, 20);
			this.labelStatus.TabIndex = 3;
			this.labelStatus.Text = "...";
			this.labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lStatus
			// 
			this.lStatus.AutoSize = true;
			this.lStatus.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lStatus.Location = new System.Drawing.Point(3, 0);
			this.lStatus.Name = "lStatus";
			this.lStatus.Size = new System.Drawing.Size(244, 20);
			this.lStatus.TabIndex = 2;
			this.lStatus.Text = "Статус:";
			this.lStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// buttonEdit
			// 
			this.buttonEdit.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonEdit.Location = new System.Drawing.Point(3, 369);
			this.buttonEdit.Name = "buttonEdit";
			this.buttonEdit.Size = new System.Drawing.Size(244, 24);
			this.buttonEdit.TabIndex = 6;
			this.buttonEdit.Text = "Редактировать,,,";
			this.buttonEdit.UseVisualStyleBackColor = true;
			this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
			// 
			// splitter1
			// 
			this.splitter1.BackColor = System.Drawing.SystemColors.ControlLight;
			this.splitter1.Location = new System.Drawing.Point(250, 24);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(3, 426);
			this.splitter1.TabIndex = 3;
			this.splitter1.TabStop = false;
			// 
			// splitter2
			// 
			this.splitter2.BackColor = System.Drawing.SystemColors.ControlLight;
			this.splitter2.Dock = System.Windows.Forms.DockStyle.Right;
			this.splitter2.Location = new System.Drawing.Point(547, 24);
			this.splitter2.Name = "splitter2";
			this.splitter2.Size = new System.Drawing.Size(3, 426);
			this.splitter2.TabIndex = 4;
			this.splitter2.TabStop = false;
			// 
			// layoutInfo
			// 
			this.layoutInfo.ColumnCount = 1;
			this.layoutInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.layoutInfo.Controls.Add(this.lGitHubLink, 0, 4);
			this.layoutInfo.Controls.Add(this.labelDescription, 0, 3);
			this.layoutInfo.Controls.Add(this.labelAuthors, 0, 2);
			this.layoutInfo.Controls.Add(this.labelName, 0, 0);
			this.layoutInfo.Controls.Add(this.lAuthors, 0, 1);
			this.layoutInfo.Controls.Add(this.linkLabelGitHub, 0, 5);
			this.layoutInfo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutInfo.Location = new System.Drawing.Point(253, 24);
			this.layoutInfo.Name = "layoutInfo";
			this.layoutInfo.RowCount = 6;
			this.layoutInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.layoutInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.layoutInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
			this.layoutInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.layoutInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.layoutInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.layoutInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.layoutInfo.Size = new System.Drawing.Size(294, 426);
			this.layoutInfo.TabIndex = 5;
			// 
			// lGitHubLink
			// 
			this.lGitHubLink.AutoSize = true;
			this.lGitHubLink.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lGitHubLink.Location = new System.Drawing.Point(3, 386);
			this.lGitHubLink.Name = "lGitHubLink";
			this.lGitHubLink.Size = new System.Drawing.Size(288, 20);
			this.lGitHubLink.TabIndex = 4;
			this.lGitHubLink.Text = "Ссылка на GitHub-репозиторий:";
			// 
			// labelDescription
			// 
			this.labelDescription.AutoSize = true;
			this.labelDescription.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelDescription.Location = new System.Drawing.Point(3, 120);
			this.labelDescription.Name = "labelDescription";
			this.labelDescription.Size = new System.Drawing.Size(288, 266);
			this.labelDescription.TabIndex = 3;
			this.labelDescription.Text = "...";
			// 
			// labelAuthors
			// 
			this.labelAuthors.AutoSize = true;
			this.labelAuthors.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelAuthors.Location = new System.Drawing.Point(3, 60);
			this.labelAuthors.Name = "labelAuthors";
			this.labelAuthors.Size = new System.Drawing.Size(288, 60);
			this.labelAuthors.TabIndex = 2;
			this.labelAuthors.Text = "...";
			// 
			// labelName
			// 
			this.labelName.AutoSize = true;
			this.labelName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelName.Location = new System.Drawing.Point(3, 0);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(288, 40);
			this.labelName.TabIndex = 0;
			this.labelName.Text = "...";
			this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lAuthors
			// 
			this.lAuthors.AutoSize = true;
			this.lAuthors.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lAuthors.Location = new System.Drawing.Point(3, 40);
			this.lAuthors.Name = "lAuthors";
			this.lAuthors.Size = new System.Drawing.Size(288, 20);
			this.lAuthors.TabIndex = 1;
			this.lAuthors.Text = "Авторы:";
			// 
			// linkLabelGitHub
			// 
			this.linkLabelGitHub.AutoSize = true;
			this.linkLabelGitHub.Dock = System.Windows.Forms.DockStyle.Fill;
			this.linkLabelGitHub.Location = new System.Drawing.Point(3, 406);
			this.linkLabelGitHub.Name = "linkLabelGitHub";
			this.linkLabelGitHub.Size = new System.Drawing.Size(288, 20);
			this.linkLabelGitHub.TabIndex = 5;
			this.linkLabelGitHub.TabStop = true;
			this.linkLabelGitHub.Text = "...";
			this.linkLabelGitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelGitHub_LinkClicked);
			// 
			// ProjectsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.layoutInfo);
			this.Controls.Add(this.splitter2);
			this.Controls.Add(this.splitter1);
			this.Controls.Add(this.layoutIssues);
			this.Controls.Add(this.layoutProjects);
			this.Controls.Add(this.menuStripMain);
			this.MainMenuStrip = this.menuStripMain;
			this.Name = "ProjectsForm";
			this.Text = "Python-парад | Проекты";
			this.layoutProjects.ResumeLayout(false);
			this.layoutIssues.ResumeLayout(false);
			this.layoutIssues.PerformLayout();
			this.layoutInfo.ResumeLayout(false);
			this.layoutInfo.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStripMain;
		private System.Windows.Forms.TableLayoutPanel layoutProjects;
		private System.Windows.Forms.TableLayoutPanel layoutIssues;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.Splitter splitter2;
		private System.Windows.Forms.TableLayoutPanel layoutInfo;
		private System.Windows.Forms.ListView listViewProjects;
		private System.Windows.Forms.ColumnHeader colHeaderName;
		private System.Windows.Forms.ColumnHeader colHeaderStatus;
		private System.Windows.Forms.Label labelAuthors;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.Label lAuthors;
		private System.Windows.Forms.Label labelStatus;
		private System.Windows.Forms.Label lStatus;
		private System.Windows.Forms.Label lGitHubLink;
		private System.Windows.Forms.Label labelDescription;
		private System.Windows.Forms.LinkLabel linkLabelGitHub;
		private System.Windows.Forms.Label labelIssues;
		private System.Windows.Forms.Label lIssues;
		private System.Windows.Forms.Button buttonNew;
		private System.Windows.Forms.Button buttonEdit;
		private System.Windows.Forms.Button buttonReload;
		private System.Windows.Forms.Button buttonDeselect;
	}
}
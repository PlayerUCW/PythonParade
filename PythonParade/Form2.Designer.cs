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
			this.listViewProjects = new System.Windows.Forms.ListView();
			this.NameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.StatusCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SuspendLayout();
			// 
			// listViewProjects
			// 
			this.listViewProjects.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameCol,
            this.StatusCol});
			this.listViewProjects.Dock = System.Windows.Forms.DockStyle.Left;
			this.listViewProjects.HideSelection = false;
			this.listViewProjects.Location = new System.Drawing.Point(0, 0);
			this.listViewProjects.Name = "listViewProjects";
			this.listViewProjects.Size = new System.Drawing.Size(240, 450);
			this.listViewProjects.TabIndex = 0;
			this.listViewProjects.UseCompatibleStateImageBehavior = false;
			this.listViewProjects.View = System.Windows.Forms.View.Details;
			// 
			// NameCol
			// 
			this.NameCol.Text = "Название";
			this.NameCol.Width = 150;
			// 
			// StatusCol
			// 
			this.StatusCol.Text = "Статус";
			this.StatusCol.Width = 90;
			// 
			// ProjectsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.listViewProjects);
			this.Name = "ProjectsForm";
			this.Text = "Python-парад | Проекты";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListView listViewProjects;
		private System.Windows.Forms.ColumnHeader NameCol;
		private System.Windows.Forms.ColumnHeader StatusCol;
	}
}
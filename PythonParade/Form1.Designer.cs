namespace PythonParade
{
	partial class AppChoiceForm
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.MainLayout = new System.Windows.Forms.TableLayoutPanel();
			this.buttonAdmin = new System.Windows.Forms.Button();
			this.buttonVoting = new System.Windows.Forms.Button();
			this.buttonProjects = new System.Windows.Forms.Button();
			this.buttonEditor = new System.Windows.Forms.Button();
			this.MainLayout.SuspendLayout();
			this.SuspendLayout();
			// 
			// MainLayout
			// 
			this.MainLayout.ColumnCount = 4;
			this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.MainLayout.Controls.Add(this.buttonAdmin, 3, 0);
			this.MainLayout.Controls.Add(this.buttonVoting, 2, 0);
			this.MainLayout.Controls.Add(this.buttonProjects, 0, 0);
			this.MainLayout.Controls.Add(this.buttonEditor, 1, 0);
			this.MainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			this.MainLayout.Location = new System.Drawing.Point(0, 0);
			this.MainLayout.Name = "MainLayout";
			this.MainLayout.RowCount = 1;
			this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.MainLayout.Size = new System.Drawing.Size(400, 100);
			this.MainLayout.TabIndex = 0;
			// 
			// buttonAdmin
			// 
			this.buttonAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonAdmin.Location = new System.Drawing.Point(303, 3);
			this.buttonAdmin.Name = "buttonAdmin";
			this.buttonAdmin.Size = new System.Drawing.Size(94, 94);
			this.buttonAdmin.TabIndex = 2;
			this.buttonAdmin.Text = "Управление";
			this.buttonAdmin.UseVisualStyleBackColor = true;
			this.buttonAdmin.Click += new System.EventHandler(this.buttonAdmin_Click);
			// 
			// buttonVoting
			// 
			this.buttonVoting.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonVoting.Location = new System.Drawing.Point(203, 3);
			this.buttonVoting.Name = "buttonVoting";
			this.buttonVoting.Size = new System.Drawing.Size(94, 94);
			this.buttonVoting.TabIndex = 1;
			this.buttonVoting.Text = "Голосование";
			this.buttonVoting.UseVisualStyleBackColor = true;
			this.buttonVoting.Click += new System.EventHandler(this.buttonVoting_Click);
			// 
			// buttonProjects
			// 
			this.buttonProjects.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonProjects.Location = new System.Drawing.Point(3, 3);
			this.buttonProjects.Name = "buttonProjects";
			this.buttonProjects.Size = new System.Drawing.Size(94, 94);
			this.buttonProjects.TabIndex = 0;
			this.buttonProjects.Text = "Проекты";
			this.buttonProjects.UseVisualStyleBackColor = true;
			this.buttonProjects.Click += new System.EventHandler(this.buttonProjects_Click);
			// 
			// buttonEditor
			// 
			this.buttonEditor.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonEditor.Location = new System.Drawing.Point(103, 3);
			this.buttonEditor.Name = "buttonEditor";
			this.buttonEditor.Size = new System.Drawing.Size(94, 94);
			this.buttonEditor.TabIndex = 3;
			this.buttonEditor.Text = "Редактор";
			this.buttonEditor.UseVisualStyleBackColor = true;
			this.buttonEditor.Click += new System.EventHandler(this.buttonEditor_Click);
			// 
			// AppChoiceForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(400, 100);
			this.Controls.Add(this.MainLayout);
			this.Name = "AppChoiceForm";
			this.Text = "Python-парад | Выбор приложения";
			this.MainLayout.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel MainLayout;
		private System.Windows.Forms.Button buttonAdmin;
		private System.Windows.Forms.Button buttonVoting;
		private System.Windows.Forms.Button buttonProjects;
		private System.Windows.Forms.Button buttonEditor;
	}
}


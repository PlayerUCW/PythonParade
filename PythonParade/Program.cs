using System;
using System.IO;
using System.Windows.Forms;

namespace PythonParade
{
	static class Program
	{
		static string _projectDirectoryFull = Directory.GetCurrentDirectory() + "\\Data\\Projects\\";

		public static string ProjectDirectoryFull
		{
			get { return _projectDirectoryFull; }
		}
		/// <summary>
		/// Главная точка входа для приложения.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			//Application.Run(new AppChoiceForm());
			Application.Run(new ProjectsForm());
		}
	}
}

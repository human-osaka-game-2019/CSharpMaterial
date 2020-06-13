using System;
using System.Windows.Forms;
using WinFormSample.Presentation;

namespace WinFormsSample {
	static class EntryPoint {
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			Application.SetHighDpiMode(HighDpiMode.SystemAware);
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new FrmMenu());
		}
	}
}


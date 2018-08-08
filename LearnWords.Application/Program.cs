using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ExcelLibrary;
using LearnWords.Domain;

namespace LearnWords.App {
	static class Program {

		private static readonly WordStorage Storage = new WordStorage();

		private static readonly string WordStorageFile = $"{Directory.GetCurrentDirectory()}\\words.json";

		private static readonly string ImportPath = $"{Directory.GetCurrentDirectory()}\\Import";

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		private static void Main() {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.ApplicationExit += OnApplicationExit;
			Storage.Read(WordStorageFile);
			Storage.ExtendDictionary(Import(ImportPath));
			var form = new frmMain(Storage);
			Application.Run(form);
		}

		private static List<Word> Import(string path) {
			var words = new List<Word>();
			if (Directory.Exists(path)) {
				var extensions = new List<string> { ".xlsx" };
				var files = Directory
					.GetFiles(path, "*.*", SearchOption.AllDirectories)
					.Where(s => extensions.Contains(Path.GetExtension(s)));
				foreach (var file in files) {
					using (var excel = new ExcelMaster(file, 1)) {
						var reader = new GoogleWordImporter(excel);
						words.AddRange(reader.Import());
					}
				}
			}
			return words;
		}

		private static void OnApplicationExit(object sender, EventArgs e) {
			try {
				Storage.Save(WordStorageFile);
			} catch {
				// ignored
			}
		}
	}

}

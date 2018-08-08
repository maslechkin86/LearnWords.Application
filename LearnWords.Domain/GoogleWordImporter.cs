using System;
using System.Collections.Generic;
using ExcelLibrary;

namespace LearnWords.Domain {

	public class GoogleWordImporter {

		private const int ColLanguageFrom = 1;

		private const int ColLanguageTo = 2;

		private const int ColTextFrom = 3;

		private const int ColTextTo = 4;

		private readonly IExcelMaster _excelMaster;

		public GoogleWordImporter(IExcelMaster excelMaster) {
			_excelMaster = excelMaster;
		}

		public List<Word> Import() {
			var words = new List<Word>();
			bool dataExists;
			var rowIndex = 1;
			do {
				var translation = new Word {
					LanguageFrom = _excelMaster.GetCellDisplayValue(rowIndex, ColLanguageFrom)?.ToString(),
					LanguageTo = _excelMaster.GetCellDisplayValue(rowIndex, ColLanguageTo)?.ToString(),
					TextFrom = _excelMaster.GetCellDisplayValue(rowIndex, ColTextFrom)?.ToString(),
					TextTo = _excelMaster.GetCellDisplayValue(rowIndex, ColTextTo)?.ToString(),
					Level = LearningLevel.New,
					ModifiedOn = DateTime.MinValue
				};
				translation.Id = HashHelper.GetHashString(translation.TextFrom + translation.TextTo);
				dataExists = !string.IsNullOrEmpty(translation.LanguageFrom);
				if (dataExists) {
					words.Add(translation);
				}
				rowIndex++;
			} while (dataExists);
			return words;
		}
	}

}

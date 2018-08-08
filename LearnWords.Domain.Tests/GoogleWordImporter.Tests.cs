using System.Collections.Generic;
using ExcelLibrary;
using FluentAssertions;
using NSubstitute;
using Xunit;

namespace LearnWords.Domain.Tests {

	public class GoogleWordImporterTestCase {

		[Fact]
		public void Import_ReturnsExpectedCollection_WhenCall() {
			// Arrange
			const int colLanguageFrom = 1;
			const int colLanguageTo = 2;
			const int colTextFrom = 3;
			const int colTextTo = 4;
			const string eng = "eng";
			const string rus = "rus";
			var excel = Substitute.For<IExcelMaster>();
			excel.GetCellDisplayValue(1, colLanguageFrom).Returns(eng);
			excel.GetCellDisplayValue(1, colLanguageTo).Returns(rus);
			excel.GetCellDisplayValue(1, colTextFrom).Returns("apple");
			excel.GetCellDisplayValue(1, colTextTo).Returns("yabluko");
			excel.GetCellDisplayValue(2, colLanguageFrom).Returns(eng);
			excel.GetCellDisplayValue(2, colLanguageTo).Returns(rus);
			excel.GetCellDisplayValue(2, colTextFrom).Returns("house");
			excel.GetCellDisplayValue(2, colTextTo).Returns("dom");
			excel.GetCellDisplayValue(3, colLanguageFrom).Returns(null);
			excel.GetCellDisplayValue(3, colLanguageTo).Returns(null);
			excel.GetCellDisplayValue(3, colTextFrom).Returns(null);
			excel.GetCellDisplayValue(3, colTextTo).Returns(null);

			// Act
			List<Word> list;
			using(var excelMaster = excel) {
				var reader = new GoogleWordImporter(excelMaster);
				list = reader.Import();
			}

			// Act
			list.Should().HaveCount(2);
			list.Should().OnlyContain(x => x.LanguageFrom == eng);
			list.Should().OnlyContain(x => x.LanguageTo == rus);
		}

	}

}

using System.Collections.Generic;

namespace LearnWords.Domain {
	public interface IExerciseView {

		List<Word> Words { get; set; }

		List<WordStatistic> WordStatistics { get; set; }

		ExerciseStatistic GeneralStatistic { get; set; }

		LearnFormNextButtonMode NextButtonMode { get; set; }

		bool TranslationCorrect { get; set; }

		int TipCharsCounter { get; set; }

		bool CanShowTip { set; }

		int CurrentWord { get; set; }

		string TranslateFromLanguage { get; set; }

		string TranslateToLanguage { get; set; }

		string TranslateWord { get; set; }

		string Answer { get; set; }

		List<string> CorrectAnswers { get; set; }

		bool CorrectResultVisibility { get; set; }

		bool IsAnswereCorrect { get; set; }

		void Close();

	}

}

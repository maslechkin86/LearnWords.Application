namespace LearnWords.Domain {

	public class WordStatistic {

		public string Id { get; set; }

		public int TranslationId { get; set; }

		public int CorrectCount { get; set; }

		public int CorrectWithTipCount { get; set; }

		public int WrongCount { get; set; }

		public int Count => CorrectCount + CorrectWithTipCount + WrongCount;

	}
}

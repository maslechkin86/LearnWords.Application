namespace LearnWords.Domain {
	public class ExerciseStatistic {

		public int WordId { get; set; }

		public int CorrectCount { get; set; }

		public int CorrectWithTipCount { get; set; }

		public int WrongCount { get; set; }

		public int Count => CorrectCount + CorrectWithTipCount + WrongCount;

	}
}

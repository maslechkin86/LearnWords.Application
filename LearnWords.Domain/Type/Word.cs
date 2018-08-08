using System;

namespace LearnWords.Domain {

	public class Word {

		public string Id { get; set; }

		public string LanguageFrom { get; set; }

		public string LanguageTo { get; set; }

		public string TextFrom { get; set; }

		public string TextTo { get; set; }

		public LearningLevel Level { get; set; }

		public DateTime ModifiedOn { get; set; }

	}
}

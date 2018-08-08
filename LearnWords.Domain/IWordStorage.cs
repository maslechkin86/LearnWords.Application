using System.Collections.Generic;

namespace LearnWords.Domain {
	public interface IWordStorage {

		List<Word> Words { get; }

	}
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace LearnWords.Domain {

	public class ExercisePlanner {

		private readonly List<Word> _words;

		public int NewPrcent => 20;

		public int WorkingPrcent => 40;

		public int DonePrcent => 30;

		public int CompletePrcent => 10;

		public ExercisePlanner(List<Word> words) {
			_words = words;
		}

		private void ExtendByRandomWords(ICollection<Word> result, ICollection<Word> source, int totalCount, int amount) {
			for (var i = 0; i < amount; i++) {
				if (result.Count >= totalCount) {
					break;
				}
				if (source.Any()) {
					var word = source.Random();
					result.Add(word);
					source.Remove(word);
				} else {
					break;
				}
			}
		}

		public List<Word> GetWords(int amount) {
			var result = new List<Word>();
			var newWords = _words
				.Where(x => x.Level == LearningLevel.Error || x.Level == LearningLevel.New).ToList();
			var workingWords = _words
				.Where(x => x.Level == LearningLevel.Working).ToList();
			var doneWords = _words
				.Where(x => x.Level == LearningLevel.DoneOnce && x.ModifiedOn < DateTime.Now.AddDays(-7)).ToList();
			var doneFreshWords = _words
				.Where(x => x.Level == LearningLevel.DoneOnce && x.ModifiedOn >= DateTime.Now.AddDays(-7)).ToList();
			var completedWords = _words
				.Where(x => x.Level == LearningLevel.Complete).ToList();
			do {
				ExtendByRandomWords(result, newWords, amount, amount * NewPrcent / 100);
				ExtendByRandomWords(result, workingWords, amount, amount * WorkingPrcent / 100);
				ExtendByRandomWords(result, doneWords, amount, amount * DonePrcent / 100);
				ExtendByRandomWords(result, completedWords, amount, amount * CompletePrcent / 100);
				var leftWordsCount = newWords.Count + workingWords.Count + doneWords.Count + completedWords.Count;
				if (leftWordsCount == 0) {
					break;
				}
				if (doneWords.Count == 0) {
					completedWords.AddRange(doneFreshWords);
				}
			} while (result.Count < amount);
			return result;
		}

	}
}

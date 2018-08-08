using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace LearnWords.Domain {
	public class LearnWordService {

		protected readonly IExerciseView View;

		public LearnWordService(IExerciseView view, List<Word> words) {
			View = view;
			View.Words = words;
			Initialized();
		}

		private string RemoveInfinitives(string source) {
			const string pattern = @"(to[^\w])";
			const string replacement = "";
			var rgx = new Regex(pattern);
			var result = rgx.Replace(source, replacement);
			return result;
		}

		private string Normalize(string source) {
			var result = source.Trim().ToLower();
			return result;
		}

		private List<string> GetAnswers(string source) {
			source = RemoveInfinitives(source);
			var text = source.ToLower().Replace(")", "").Replace(",", ";").Replace("(", ";");
			var answers = text.Split(';');
			return answers.Select(Normalize).ToList();
		}

		private void LoadWord(Word word, ExerciseMode mode = ExerciseMode.FromEng) {
			string answer;
			string task;
			var currentMode = mode;
			if (currentMode == ExerciseMode.Mix) {
				var random = new Random();
				var number = random.Next(0, 2);
				currentMode = (ExerciseMode) number;
			}
			if (currentMode == ExerciseMode.FromEng) {
				answer = word.TextTo;
				task = word.TextFrom;
			} else {
				answer = word.TextFrom;
				task = word.TextTo;
			}
			View.Answer = string.Empty;
			View.CorrectResultVisibility = false;
			View.CorrectAnswers = GetAnswers(answer);
			View.TranslateFromLanguage = word.LanguageFrom;
			View.TranslateToLanguage = word.LanguageTo;
			View.TranslateWord = Normalize(task);
			View.CanShowTip = true;
			View.TipCharsCounter = 0;
			View.NextButtonMode = LearnFormNextButtonMode.Submit;
		}

		public void Initialized() {
			if(View.Words.Any()) {
				View.WordStatistics = new List<WordStatistic>();
				View.GeneralStatistic = new ExerciseStatistic();
				var translation = View.Words[View.CurrentWord];
				LoadWord(translation);
			}
		}

		public void NextWord() {
			if(View.NextButtonMode == LearnFormNextButtonMode.Submit) {
				View.IsAnswereCorrect = View.CorrectAnswers.Contains(RemoveInfinitives(View.Answer.ToLower().Trim()));
				View.CorrectResultVisibility = true;
				var id = View.Words[View.CurrentWord].Id;
				var statistic = View.WordStatistics.FirstOrDefault(x => x.Id == id);
				if(statistic == null) {
					statistic = new WordStatistic { Id = id };
					View.WordStatistics.Add(statistic);
				}
				if(View.IsAnswereCorrect && View.TipCharsCounter == 0) {
					statistic.CorrectCount++;
					View.GeneralStatistic.CorrectCount++;
				} else if(View.IsAnswereCorrect) {
					statistic.CorrectWithTipCount++;
					View.GeneralStatistic.CorrectWithTipCount++;
				} else {
					statistic.WrongCount++;
					View.GeneralStatistic.WrongCount++;
				}
				UpdateLevel(View.Words[View.CurrentWord], View.IsAnswereCorrect, View.TipCharsCounter > 0);
				View.NextButtonMode = LearnFormNextButtonMode.Next;
				return;
			}
			if(View.CurrentWord < View.Words.Count - 1) {
				View.CurrentWord++;
				LoadWord(View.Words[View.CurrentWord]);
			} else {
				View.Close();
			}
		}

		private void UpdateLevel(Word word, bool isCorrect, bool useTip) {
			if(word.Level == LearningLevel.New || word.Level == LearningLevel.Error) {
				word.Level = isCorrect ? LearningLevel.Working : LearningLevel.Error;
				word.ModifiedOn = DateTime.Now;
			} else if(word.Level == LearningLevel.Working && isCorrect && !useTip) {
				word.Level = LearningLevel.DoneOnce;
				word.ModifiedOn = DateTime.Now;
			} else if(word.Level == LearningLevel.DoneOnce && isCorrect && !useTip) {
				word.Level = LearningLevel.Complete;
				word.ModifiedOn = DateTime.Now;
			} else if(word.Level == LearningLevel.Complete && isCorrect && useTip) {
				word.Level = LearningLevel.Working;
				word.ModifiedOn = DateTime.Now;
			} else if(!isCorrect) {
				word.Level = LearningLevel.Error;
				word.ModifiedOn = DateTime.Now;
			}
		}

		public void ShowTip() {
			if(View.CurrentWord < View.Words.Count) {
				var translation = View.Words[View.CurrentWord];
				if(View.TipCharsCounter < translation.TextTo.Length) {
					View.TipCharsCounter++;
					View.Answer = translation.TextTo.Substring(0, View.TipCharsCounter);
				} /*else if (_form.TipCharsCounter == word.TextTo.Length) {
					
				}*/
				View.CanShowTip = (View.TipCharsCounter < translation.TextTo.Length);
			}
		}
	}

}

using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace LearnWords.Domain {

	public class WordStorage : IWordStorage {

		public List<Word> Words { get; private set; } = new List<Word>();

		protected virtual bool IsSourceExist(string path) {
			return File.Exists(path);
		}

		protected virtual string ReadAllSource(string path) {
			return File.ReadAllText(path);
		}

		protected virtual void SaveSource(string path, string data) {
			File.WriteAllText(path, data);
		}

		public void ExtendDictionary(List<Word> words) {
			foreach(var newWord in words) {
				var word = Words.FirstOrDefault(x => x.TextFrom == newWord.TextFrom);
				if(word == null) {
					Words.Add(newWord);
				} else {
					word.LanguageFrom = newWord.LanguageFrom;
					word.LanguageTo = newWord.LanguageTo;
					word.TextTo = newWord.TextTo;
				}
			}
		}

		public void Read(string path) {
			if (IsSourceExist(path)) {
				var json = ReadAllSource(path);
				Words = JsonConvert.DeserializeObject<List<Word>>(json);
			}
		}

		public void Save(string path) {
			var json = JsonConvert.SerializeObject(Words.ToArray());
			SaveSource(path, json);
		}

	}

}

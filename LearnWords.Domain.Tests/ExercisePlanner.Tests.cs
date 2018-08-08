using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Xunit;

namespace LearnWords.Domain.Tests {

	public class ExercisePlannerTestCase {

		protected ExercisePlanner Planner;

		protected List<Word> Words;

		protected int WordId;

		public ExercisePlannerTestCase() {
			Words = new List<Word>();
			Planner = new ExercisePlanner(Words);
			WordId = 0;
		}

		private void AddWord(int count, LearningLevel level) {
			for (var i = 0; i < count; i++) {
				Words.Add(new Word {Id = WordId.ToString(), Level = level});
				WordId++;
			}
		}

		private bool IsCollectionContainsDuplicates(List<Word> words) {
			var list = words.Select(_ => _.Id).ToList();
			return list.Count != list.Distinct().Count();
		}

		[Fact]
		public void GetWords_ReturnExpectedCollection_IfAllWordsIsNew() {
			// Arrange
			AddWord(10, LearningLevel.New);
			const int wordInExercise = 10;

			// Act
			var result = Planner.GetWords(wordInExercise);

			// Assert
			result.Should().HaveCount(wordInExercise);
			IsCollectionContainsDuplicates(result).Should().BeFalse("collection shouldn't contains duplicates");
			result.ShouldBeEquivalentTo(Words);
		}

		[Fact]
		public void GetWords_ReturnCollectionWithExpectedProportionOfLevels_IfExistsWordsWithAllLevels() {
			// Arrange
			AddWord(4, LearningLevel.New);
			AddWord(4, LearningLevel.Error);
			AddWord(8, LearningLevel.Working);
			AddWord(6, LearningLevel.DoneOnce);
			AddWord(2, LearningLevel.Complete);
			const int wordInExercise = 10;

			// Act
			var result = Planner.GetWords(wordInExercise);

			// Assert
			result.Should().HaveCount(wordInExercise);
			IsCollectionContainsDuplicates(result).Should().BeFalse("collection shouldn't contains duplicates");
			var newItems = result.Where(_ => _.Level == LearningLevel.New || _.Level == LearningLevel.Error);
			newItems.Should().HaveCount(2);
			var workingItems = result.Where(_ => _.Level == LearningLevel.Working);
			workingItems.Should().HaveCount(4);
			var doneItems = result.Where(_ => _.Level == LearningLevel.DoneOnce);
			doneItems.Should().HaveCount(3);
			var completedItems = result.Where(_ => _.Level == LearningLevel.Complete);
			completedItems.Should().HaveCount(1);
		}

		[Fact]
		public void GetWords_ReturnCollectionWithExpectedProportionOfLevels_IfNoWordsWithNewOrErrorLevels() {
			// Arrange
			AddWord(12, LearningLevel.Working);
			AddWord(6, LearningLevel.DoneOnce);
			AddWord(2, LearningLevel.Complete);
			const int wordInExercise = 10;

			// Act
			var result = Planner.GetWords(wordInExercise);

			// Assert
			result.Should().HaveCount(wordInExercise);
			IsCollectionContainsDuplicates(result).Should().BeFalse("collection shouldn't contains duplicates");
			var workingItems = result.Where(_ => _.Level == LearningLevel.Working);
			workingItems.Should().HaveCount(6);
			var doneItems = result.Where(_ => _.Level == LearningLevel.DoneOnce);
			doneItems.Should().HaveCount(3);
			var completedItems = result.Where(_ => _.Level == LearningLevel.Complete);
			completedItems.Should().HaveCount(1);
		}

		[Fact]
		public void GetWords_ReturnCollectionWithExpectedProportionOfLevels_IfNoWordsWithNewOrErrorOrWorkingLevels() {
			// Arrange
			AddWord(15, LearningLevel.DoneOnce);
			AddWord(5, LearningLevel.Complete);
			const int wordInExercise = 10;

			// Act
			var result = Planner.GetWords(wordInExercise);

			// Assert
			result.Should().HaveCount(wordInExercise);
			IsCollectionContainsDuplicates(result).Should().BeFalse("collection shouldn't contains duplicates");
			var doneItems = result.Where(_ => _.Level == LearningLevel.DoneOnce);
			doneItems.Should().HaveCount(8);
			var completedItems = result.Where(_ => _.Level == LearningLevel.Complete);
			completedItems.Should().HaveCount(2);
		}

		[Fact]
		public void GetWords_ReturnAllCollection_IfNotEnaughWords() {
			// Arrange
			AddWord(4, LearningLevel.New);
			AddWord(4, LearningLevel.Error);
			AddWord(8, LearningLevel.Working);
			AddWord(6, LearningLevel.DoneOnce);
			AddWord(2, LearningLevel.Complete);
			const int wordInExercise = 100;

			// Act
			var result = Planner.GetWords(wordInExercise);

			// Assert
			result.Should().HaveCount(Words.Count);
			IsCollectionContainsDuplicates(result).Should().BeFalse("collection shouldn't contains duplicates");
			result.ShouldBeEquivalentTo(Words);
		}

		[Fact]
		public void GetWords_ReturnEmptyCollection_IfWordsCollectionIsEmpty() {
			// Arrange
			const int wordInExercise = 10;

			// Act
			var result = Planner.GetWords(wordInExercise);

			// Assert
			result.Should().BeEmpty();
		}

		[Fact]
		public void Procent_Return100Procent_IfSumAllProcent() {
			// Arrange
			const int expectedProcentSum = 100;

			// Act
			var result = Planner.CompletePrcent+Planner.DonePrcent+ Planner.NewPrcent+ Planner.WorkingPrcent;

			// Assert
			result.Should().Be(expectedProcentSum);
		}

	}
}

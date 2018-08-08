using System.Collections.Generic;
using FluentAssertions;
using NSubstitute;
using Xunit;

namespace LearnWords.Domain.Tests {

	public class LearnWordServiceTestCase {

		[Fact]
		public void NextWord_AnswereIsCorrect_WhenAnswereWithoutInfinitive() {
			// Arrange
			var view = Substitute.For<IExerciseView>();
			var words = new List<Word> {
				new Word {TextFrom = "vchytu", TextTo = "to learn"}
			};
			var service = new LearnWordService(view, words);
			view.Answer.Returns("learn");

			// Act
			service.NextWord();

			// Assert
			view.IsAnswereCorrect.Should().BeTrue();
		}

		[Fact]
		public void NextWord_AnswereIsCorrect_WhenAnswereWithInfinitive() {
			// Arrange
			var view = Substitute.For<IExerciseView>();
			var words = new List<Word> {
				new Word {TextFrom = "vchytu", TextTo = "to learn"}
			};
			var service = new LearnWordService(view, words);
			view.Answer.Returns("to learn");

			// Act
			service.NextWord();

			// Assert
			view.IsAnswereCorrect.Should().BeTrue();
		}

		[Fact]
		public void NextWord_AnswereIsCorrect_WhenAnswereSimilarToInfinitive() {
			// Arrange
			var view = Substitute.For<IExerciseView>();
			var words = new List<Word> {
				new Word {TextFrom = "night", TextTo = "tonight"}
			};
			var service = new LearnWordService(view, words);
			view.Answer.Returns("tonight");

			// Act
			service.NextWord();

			// Assert
			view.IsAnswereCorrect.Should().BeTrue();
		}

		[Fact]
		public void NextWord_DoNotRemoveTo_WhenWordIsFinishedInTo() {
			// Arrange
			var view = Substitute.For<IExerciseView>();
			var words = new List<Word> {
				new Word {TextFrom = "ity na", TextTo = "go to"}
			};
			var service = new LearnWordService(view, words);
			view.Answer.Returns("go to");

			// Act
			service.NextWord();

			// Assert
			view.IsAnswereCorrect.Should().BeTrue();
		}

		[Theory]
		[InlineData("answer1 ", "answer1")]
		[InlineData(" answer1", "answer1")]
		[InlineData("ANSWER1", "answer1")]
		[InlineData("answer1", " answer1")]
		[InlineData("answer1", "answer1 ")]
		public void NextWord_ResultIsCorrect_WhenUserPutCorrectAnswer(string answer, string userAnswer) {
			// Arrange
			var view = Substitute.For<IExerciseView>();
			var words = new List<Word> {
				new Word {TextFrom = "worde1", TextTo = answer}
			};
			var service = new LearnWordService(view, words);
			view.Answer.Returns(userAnswer);

			// Act
			service.NextWord();

			// Assert
			view.IsAnswereCorrect.Should().BeTrue();
		}

		[Theory]
		[InlineData("answer1; answer2", "answer1")]
		[InlineData("answer1; answer2", "answer2")]
		public void NextWord_ResultIsCorrect_WhenUserPutCorrectOneOfTheAnsweres(string answer, string userAnswer) {
			// Arrange
			var view = Substitute.For<IExerciseView>();
			var words = new List<Word> {
				new Word {TextFrom = "worde1", TextTo = answer}
			};
			var service = new LearnWordService(view, words);
			view.Answer.Returns(userAnswer);

			// Act
			service.NextWord();

			// Assert
			view.IsAnswereCorrect.Should().BeTrue();
		}

	}
}

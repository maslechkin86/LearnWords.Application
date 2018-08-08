using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using LearnWords.Domain;

namespace LearnWords.App {
	public partial class frmExercise : Form, IExerciseView {

		protected readonly LearnWordService Service;

		public frmExercise(List<Word> words) {
			InitializeComponent();
			Service = new LearnWordService(this, words);
		}

		private LearnFormNextButtonMode _nextButtonMode;

		public LearnFormNextButtonMode NextButtonMode {
			get {
				return _nextButtonMode;
			}
			set {
				_nextButtonMode = value;
				btnNext.Text = _nextButtonMode == LearnFormNextButtonMode.Submit ? "Submit" : "Next";
			}
		}

		public bool TranslationCorrect { get; set; }

		public List<Word> Words { get; set; }

		public List<WordStatistic> WordStatistics { get; set; }

		public ExerciseStatistic GeneralStatistic { get; set; }

		public int TipCharsCounter { get; set; }

		public bool CanShowTip { set { btnTip.Enabled = value; } }

		public int CurrentWord { get; set; }

		private string _translateFromLanguage;

		public string TranslateFromLanguage {
			get {
				return _translateFromLanguage;
			}
			set {
				_translateFromLanguage = value;
				lblTranslateFrom.Text = $"Translate from '{_translateFromLanguage}'";
			}
		}

		private string _translateToLanguage;

		public string TranslateToLanguage {
			get {
				return _translateToLanguage;
			}
			set {
				_translateToLanguage = value;
				lblTranslateTo.Text = $"Translate to '{_translateToLanguage}'";
			}
		}

		public string TranslateWord {
			get { return txtTextFrom.Text; }
			set { txtTextFrom.Text = value; }
		}

		public string Answer {
			get { return txtAnswer.Text; }
			set { txtAnswer.Text = value; }
		}

		public List<string> _correctAnswers;

		public List<string> CorrectAnswers {
			get {
				return _correctAnswers;
			}
			set {
				_correctAnswers = value;
				lblCorrectAnswere.Text = string.Join(", ", _correctAnswers);
			}
		}

		public bool CorrectResultVisibility {
			get { return lblCorrectAnswere.Visible; }
			set { lblCorrectAnswere.Visible = value; }
		}

		private bool _isResultCorrect;

		public bool IsAnswereCorrect {
			get { return _isResultCorrect; }
			set {
				_isResultCorrect = value;
				lblCorrectAnswere.ForeColor = _isResultCorrect ? Color.Green : Color.Red;
			}
		}

		private void btnNext_Click(object sender, EventArgs e) {
			Service.NextWord();
		}

		private void btnTip_Click(object sender, EventArgs e) {
			Service.ShowTip();
		}

	}
}

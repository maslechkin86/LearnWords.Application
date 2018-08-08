using System;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Media;
using LearnWords.App;
using LiveCharts;
using LiveCharts.Wpf;
using Color = System.Drawing.Color;

namespace LearnWords.Domain {
	public partial class frmMain : Form {

		private readonly IWordStorage _storage;

		public frmMain(IWordStorage storage) {
			_storage = storage;
			InitializeComponent();
			UpdateData();
		}

		public void UpdateData() {
			var words = _storage.Words;
			txtWordsCount.Text = words.Count.ToString();
			var completedWordsCount = words.Count(_ => _.Level == LearningLevel.Complete);
			txtCompleted.Text = completedWordsCount.ToString();
			var doneOnceWordsCount = words.Count(_ => _.Level == LearningLevel.DoneOnce);
			txtDoneOnce.Text = doneOnceWordsCount.ToString();
			var workingWordsCount = words.Count(_ => _.Level == LearningLevel.Working);
			txtWorking.Text = workingWordsCount.ToString();
			var errorWordsCount = words.Count(_ => _.Level == LearningLevel.Error);
			txtWrong.Text = errorWordsCount.ToString();
			var newWordsCount = words.Count(_ => _.Level == LearningLevel.New);
			txtNew.Text = newWordsCount.ToString();
			SetFontColor(txtCompleted, Color.Green);
			SetFontColor(txtDoneOnce, Color.DeepSkyBlue);
			SetFontColor(txtWorking, Color.Gold);
			SetFontColor(txtWrong, Color.Red);
			SetFontColor(txtNew, Color.BlueViolet);
			cartesianChart1.Series = new SeriesCollection {
				new StackedColumnSeries {
					Values = new ChartValues<double> {newWordsCount},
					StackMode = StackMode.Values,
					DataLabels = true,
					Title = "New",
					Fill = new SolidColorBrush(System.Windows.Media.Color.FromRgb(204, 0, 204))
				},
				new StackedColumnSeries {
					Values = new ChartValues<double> {errorWordsCount},
					StackMode = StackMode.Values,
					DataLabels = true,
					Title = "Error",
					Fill = new SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 0, 0))
				},
				new StackedColumnSeries {
					Values = new ChartValues<double> {workingWordsCount},
					StackMode = StackMode.Values,
					DataLabels = true,
					Title = "Working",
					Fill = new SolidColorBrush(System.Windows.Media.Color.FromRgb(204, 153, 0))
				},
				new StackedColumnSeries {
					Values = new ChartValues<double> {doneOnceWordsCount},
					StackMode = StackMode.Values,
					DataLabels = true,
					Title = "Done",
					Fill = new SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 102, 255))
				},
				new StackedColumnSeries {
					Values = new ChartValues<double> {completedWordsCount},
					StackMode = StackMode.Values,
					DataLabels = true,
					Title = "Completed",
					Fill = new SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 102, 0))
				}
			};
			cartesianChart1.AxisX = new AxesCollection {
				new Axis {
					Title = "",
					Labels = new[] {"Words"},
					Separator = DefaultAxes.CleanSeparator
				}
			};
		}

		private void SetFontColor(TextBox box, Color color) {
			box.BackColor = box.BackColor;
			box.ForeColor = color;
		}

		private void btnExercise_Click(object sender, EventArgs e) {
			var selector = new ExercisePlanner(_storage.Words);
			var form = new frmExercise(selector.GetWords(10));
			form.ShowDialog();
			UpdateData();
		}

	}
}

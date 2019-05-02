using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using Muslims.Annotations;
using Muslims.Models;
using Muslims.Parser;

namespace Muslims.ViewModel
{
	internal class NamazTimesViewModel : INotifyPropertyChanged
	{
		#region Delegates and events
		public event PropertyChangedEventHandler PropertyChanged;
		#endregion

		#region Data
		#region Fields
		private ObservableCollection<NamazTimesRow> _namazTimes;
		private string _date;
		private string _firstNamaz;
		private string _secondNamaz;
		private string _thirdNamaz;
		private string _fourthNamaz;
		private string _fifthNamaz;
		private string _sixthNamaz;
		#endregion
		#endregion

		#region .ctor
		public NamazTimesViewModel()
		{
			var parser = new NamazTimeParser();
			NamazTimesRow namazToday = parser.GetTodayNamazTimes();
			_date = namazToday.Day + "." + namazToday.Mouth;
			_firstNamaz = namazToday.FirstNamaz;
			_secondNamaz = namazToday.SecondNamaz;
			_thirdNamaz = namazToday.ThirdNamaz;
			_fourthNamaz = namazToday.FourthNamaz;
			_fifthNamaz = namazToday.FifthNamaz;
			_sixthNamaz = namazToday.SixthNamaz;

		}
		#endregion

		#region Properties
		public string Date
		{
			get => _date;
			set
			{
				_date = value;
				OnPropertyChanged(nameof(Date));
			}
		}

		public string FirstNamaz
		{
			get => _firstNamaz;
			set
			{
				_firstNamaz = value;
				OnPropertyChanged(nameof(FirstNamaz));
			}
		}

		public string SecondNamaz
		{
			get => _secondNamaz;
			set
			{
				_secondNamaz = value;
				OnPropertyChanged(nameof(SecondNamaz));
			}
		}

		public string ThirdNamaz
		{
			get => _thirdNamaz;
			set
			{
				_thirdNamaz = value;
				OnPropertyChanged(nameof(ThirdNamaz));
			}
		}

		public string FourthNamaz
		{
			get => _fourthNamaz;
			set
			{
				_fourthNamaz = value;
				OnPropertyChanged(nameof(FourthNamaz));
			}
		}
		
		public string FifthNamaz
		{
			get => _fifthNamaz;
			set
			{
				_fifthNamaz = value;
				OnPropertyChanged(nameof(FifthNamaz));
			}
		}

		public string SixthNamaz
		{
			get => _sixthNamaz;
			set
			{
				_sixthNamaz = value;
				OnPropertyChanged(nameof(SixthNamaz));
			}
		}
		#endregion

		#region Overridable
		[NotifyPropertyChangedInvocator]
		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
		#endregion
	}
}

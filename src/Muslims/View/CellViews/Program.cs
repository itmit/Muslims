namespace Muslims.View.CellViews
{
	/// <summary>
	/// Представляет одну колонку из таблицы проведения намазов, в течении дня.
	/// </summary>
	internal class NamazTimeRow
	{
		#region Properties
		/// <summary>
		/// Возвращает или устанавливает  день проведения намазов.
		/// </summary>
		public int Day
		{
			get;
			set;
		}

		/// <summary>
		/// Возвращает или устанавливает время пятого намаза.
		/// </summary>
		public string FifthNamaz
		{
			get;
			set;
		}

		/// <summary>
		/// Возвращает или устанавливает время первого намаза.
		/// </summary>
		public string FirstNamaz
		{
			get;
			set;
		}

		/// <summary>
		/// Возвращает или устанавливает время четвертого намаза.
		/// </summary>
		public string FourthNamaz
		{
			get;
			set;
		}

		/// <summary>
		/// Возвращает или устанавливает месяц в котром проводятся намазы.
		/// </summary>
		public int Mouth
		{
			get;
			set;
		}

		/// <summary>
		/// Возвращает или устанавливает время второго намаза.
		/// </summary>
		public string SecondNamaz
		{
			get;
			set;
		}

		/// <summary>
		/// Возвращает или устанавливает время шестого намаза.
		/// </summary>
		public string SixthNamaz
		{
			get;
			set;
		}

		/// <summary>
		/// Возвращает или устанавливает время третьего намаза.
		/// </summary>
		public string ThirdNamaz
		{
			get;
			set;
		}
		#endregion
	}
}

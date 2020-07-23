using System;
using Muslims.Annotations;
using Xamarin.Forms;

namespace Muslims.Models
{
	public class MenuItem
	{
		private Type _pageType;

		public MenuItem(Type pageType) => PageType = pageType;
		public MenuItem(Action executeOpen) => OpenExecute = executeOpen;

		public string ImageSource
		{
			get;
			set;
		}

		public Type PageType
		{
			get => _pageType;
			private set
			{
				if (!typeof(Page).IsAssignableFrom(value))
				{
					throw new InvalidOperationException($"{value.Name} is not a page.");
				}
				_pageType = value;
			}
		}

		public Action OpenExecute
		{
			get;
		}

		public string Title
		{
			get;
			set;
		}
	}
}

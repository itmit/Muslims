using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Muslims.Annotations;
using Muslims.View;
using Muslims.View.Gallery;
using Muslims.View.Library;
using Muslims.View.Namaz;
using Muslims.View.News;
using Xamarin.Essentials;
using Xamarin.Forms;
using MenuItem = Muslims.Models.MenuItem;

namespace Muslims.ViewModel
{
	public class MenuViewModel : INotifyPropertyChanged
	{
		private const string KoranUri = "http://play.google.com/store/apps/details?id=com.pakdata.QuranMajeed";

		private ObservableCollection<MenuItem> _menuItems = new ObservableCollection<MenuItem>
		{
			new MenuItem(typeof(AboutPage))
			{
				Title = "О НАС",
				ImageSource = "ic_1.png"
			},
			new MenuItem(typeof(NamazPage))
			{
				Title = "НАМАЗ",
				ImageSource = "ic_2.png"
			},
			new MenuItem(typeof(NewsPage))
			{
				Title = "НОВОСТИ",
				ImageSource = "ic_3.png"
			},
			new MenuItem(() => Browser.OpenAsync(KoranUri, BrowserLaunchMode.SystemPreferred))
			{
				Title = "КОРАН",
				ImageSource = "ic_4.png"
			},
			new MenuItem(typeof(LibraryPage))
			{
				Title = "БИБЛИОТЕКА",
				ImageSource = "ic_5.png"
			},
			new MenuItem(typeof(PhotoPage))
			{
				Title = "ФОТО",
				ImageSource = "ic_6.png"
			},
			new MenuItem(typeof(Contacts))
			{
				Title = "КОНТАКТЫ",
				ImageSource = "ic_7.png"
			}
		};
		private MenuItem _selectedItem;

		public ObservableCollection<MenuItem> MenuItems
		{
			get => _menuItems;
			set
			{
				_menuItems = value;
				OnPropertyChanged(nameof(MenuItems));
			}
		}

		public MenuItem SelectedItem
		{
			get => _selectedItem;
			set
			{
				if (value == null)
				{
					return;
				}
				_selectedItem = value;

				if (Application.Current.MainPage is MasterDetailPage mainPage)
				{
					if (value.PageType != null)
					{
						mainPage.Detail = new NavigationPage((Page)Activator.CreateInstance(value.PageType));
					}
					else
					{
						value.OpenExecute.Invoke();
					}
				}

				OnPropertyChanged(nameof(SelectedItem));
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		[NotifyPropertyChangedInvocator]
		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}

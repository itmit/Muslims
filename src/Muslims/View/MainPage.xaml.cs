using System.Collections.Generic;
using Android.Content;
using Android.Net;
using Muslims.View;
using Plugin.Connectivity;
using Xamarin.Forms;
using Application = Android.App.Application;

namespace Muslims
{
	public partial class MainPage : MasterDetailPage
	{
		#region .ctor
		public MainPage()
		{
			InitializeComponent();
			Init();
		}
		#endregion

		#region Public
		public void Init()
		{
			var menu = new List<Menu>
			{
				new Menu
				{
					MenuID = "1",
					MenuTitle = "О НАС",
					ImagePath = "ic_1.png"
				},
				new Menu
				{
					MenuID = "2",
					MenuTitle = "НАМАЗ",
					ImagePath = "ic_2.png"
				},
				new Menu
				{
					MenuID = "3",
					MenuTitle = "НОВОСТИ",
					ImagePath = "ic_3.png"
				},
				new Menu
				{
					MenuID = "4",
					MenuTitle = "КОРАН",
					ImagePath = "ic_4.png"
				},
				new Menu
				{
					MenuID = "5",
					MenuTitle = "БИБЛИОТЕКА",
					ImagePath = "ic_5.png"
				},
				new Menu
				{
					MenuID = "6",
					MenuTitle = "ФОТО",
					ImagePath = "ic_6.png"
				},
				new Menu
				{
					MenuID = "7",
					MenuTitle = "КОНТАКТЫ",
					ImagePath = "ic_7.png"
				}
			};

			ListMenu.ItemsSource = menu;

			switch (Device.RuntimePlatform)
			{
				case Device.iOS:
				{
					ListMenu.Margin = new Thickness(0, 21, 0, 0);
					break;
				}
				case Device.Android:
				{
					ListMenu.Margin = new Thickness(0, 21, 0, 0);
					break;
				}
					;
			}

			Detail = new NavigationPage(new Start());
		}

		public bool IsConnected()
		{
			if (CrossConnectivity.Current.IsConnected)
			{
				return true;
			}

			return false;
		}

		public void ListMenu_ItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			if (e.SelectedItem is Menu menu)
			{
				if (menu.MenuID.Equals("1"))
				{
					Detail = new NavigationPage(new About());
					IsPresented = false;
				}
				else if (menu.MenuID.Equals("2"))
				{
					Detail = new NavigationPage(new Namaz());
					IsPresented = false;
				}
				else if (menu.MenuID.Equals("3"))
				{
					if (IsConnected())
					{
						Detail = new NavigationPage(new News());
						IsPresented = false;
					}
					else
					{
						DisplayAlert("Ошибка", "Отсутствует подключение к сети!", "Ок");
					}
				}
				else if (menu.MenuID.Equals("4"))
				{
					var packageManager = Application.Context.PackageManager;
					var quranMajeed = packageManager.GetLaunchIntentForPackage("com.pakdata.QuranMajeed");
					if (quranMajeed == null)
					{
						if (IsConnected())
						{
							quranMajeed = new Intent(Intent.ActionView, Uri.Parse("http://play.google.com/store/apps/details?id=com.pakdata.QuranMajeed"));
						}
						else
						{
							DisplayAlert("Ошибка", "Отсутствует подключение к сети!", "Ок");
						}
					}

					quranMajeed.AddFlags(ActivityFlags.NewTask);
					Application.Context.StartActivity(quranMajeed);
				}
				else if (menu.MenuID.Equals("5"))
				{
					Detail = new NavigationPage(new Library());
					IsPresented = false;
				}
				else if (menu.MenuID.Equals("6"))
				{
					Detail = new NavigationPage(new Photo());
					IsPresented = false;
				}
				else if (menu.MenuID.Equals("7"))
				{
					Detail = new NavigationPage(new Contacts());
					IsPresented = false;
				}
			}
		}
		#endregion
	}

	public class Menu
	{
		#region Properties
		public string ImagePath
		{
			get;
			set;
		}

		public string MenuID
		{
			get;
			set;
		}

		public string MenuTitle
		{
			get;
			set;
		}
		#endregion
	}
}

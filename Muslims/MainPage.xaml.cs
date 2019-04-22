using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Plugin.Connectivity;
using Android.Content.PM;
using Android.Content;

namespace Muslims
{

    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            Init();
        }
        public void Init()
        {
            List<Menu> menu = new List<Menu>
            {
                new Menu { MenuID="1", MenuTitle = "О НАС", ImagePath = "ic_1.png"},
                new Menu { MenuID="2", MenuTitle = "НАМАЗ", ImagePath = "ic_2.png"},
                new Menu { MenuID="3", MenuTitle = "НОВОСТИ", ImagePath = "ic_3.png"},
                new Menu { MenuID="4", MenuTitle = "КОРАН", ImagePath = "ic_4.png"},
                new Menu { MenuID="5", MenuTitle = "БИБЛИОТЕКА", ImagePath = "ic_5.png"},
                new Menu { MenuID="6", MenuTitle = "ФОТО", ImagePath = "ic_6.png"},
                new Menu { MenuID="7", MenuTitle = "КОНТАКТЫ", ImagePath = "ic_7.png"}
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
                    };
            }

            Detail = new NavigationPage(new Start());
        }
        public void ListMenu_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            var menu = e.SelectedItem as Menu;
            if (menu != null)
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
                    if (IsConnected() == true)
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
                    Intent QuranMajeed;
                    PackageManager packageManager = Android.App.Application.Context.PackageManager;
                    QuranMajeed = packageManager.GetLaunchIntentForPackage("com.pakdata.QuranMajeed");
                    if (QuranMajeed == null )
                    {
                        if (IsConnected() == true)
                        {
                            QuranMajeed = new Intent(Intent.ActionView, Android.Net.Uri.Parse("http://play.google.com/store/apps/details?id=com.pakdata.QuranMajeed"));
                        }
                        else
                        {
                            DisplayAlert("Ошибка", "Отсутствует подключение к сети!", "Ок");
                        }
                    }
                    QuranMajeed.AddFlags(ActivityFlags.NewTask);
                    Android.App.Application.Context.StartActivity(QuranMajeed);
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
        public bool IsConnected()
        {
            if (CrossConnectivity.Current.IsConnected)
            {
                return true;
            }
            return false;
        }
    }
    public class Menu
    {
        public string MenuTitle
        {
            get;
            set;
        }
        public string MenuID
        {
            get;
            set;
        }
        public string ImagePath
        {
            get;
            set;
        }
    }
}

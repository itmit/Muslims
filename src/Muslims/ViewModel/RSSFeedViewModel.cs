using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;
using Muslims.Models;
using Muslims.Models.Network;
using Xamarin.Forms;

namespace Muslims.ViewModel
{
    public class RssFeedViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<NewsItem> FeedList
        {
            get => _feedList;
            set
            {
                if (_feedList != value)
                {
                    _feedList = value;
                    OnPropertyChanged("FeedList");
                }
            }
        }
        public ObservableCollection<NewsItem> FeedListGazeta
        {
            get => _feedListGazeta;
            set
            {
                if (_feedListGazeta != value)
                {
                    _feedListGazeta = value;
                    OnPropertyChanged("FeedListGazeta");
                }

            }
        }
        public ObservableCollection<NewsItem> FeedListAdvert
        {
            get => _feedListAdvert;
            set
            {
                if (_feedListAdvert != value)
                {
                    _feedListAdvert = value;
                    OnPropertyChanged("FeedListAdvert");
                }

            }
        }

        private NewsItem _selectedItem;
        private NewsItem _selectedItemGazeta;
        private NewsItem _selectedItemAdvert;
        private INavigation Navigation;

        public NewsItem SelectedItem
        {
            get => _selectedItem;
            set
            {
                if (_selectedItem != value)
                {
                    _selectedItem = value;
                    OnPropertyChanged("SelectedItem");
                    OpenWebPage();
                }
            }
        }
        public NewsItem SelectedItemGazeta
        {
            get => _selectedItemGazeta;
            set
            {
                if (_selectedItemGazeta != value)
                {
                    _selectedItemGazeta = value;
                    OnPropertyChanged("SelectedItemGazeta");
                    OpenWebPageGazeta();
                }
            }
        }
        public NewsItem SelectedItemAdvert
        {
            get => _selectedItemAdvert;
            set
            {
                if (_selectedItemAdvert != value)
                {
                    _selectedItemAdvert = value;
                    OnPropertyChanged("SelectedItemAdvert");
                    OpenWebPageAdvert();
                }
            }
        }

        private ObservableCollection<NewsItem> _feedList;
		private ObservableCollection<NewsItem> _feedListGazeta;
		private ObservableCollection<NewsItem> _feedListAdvert;
        public event PropertyChangedEventHandler PropertyChanged;

        public RssFeedViewModel(INavigation navigation)
        {
			Navigation = navigation;
		}

		public async void SetNewsFeedAsync(NetworkManager manager)
        {
			FeedList = new ObservableCollection<NewsItem>(await manager.GetSyncFeedAsync());
        }

        public async void SetGazetaFeedAsync(NetworkManagerGazeta manager)
        {
            FeedListGazeta = new ObservableCollection<NewsItem>(await manager.GetSyncFeedAsync());
        }

        public async void SetAdvertFeedAsync(NetworkManagerAdvert manager)
        {
            FeedListAdvert = new ObservableCollection<NewsItem>(await manager.GetSyncFeedAsync());
        }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void OpenWebPage()
        {
            Navigation.PushAsync(new NewsPage(_selectedItem.Title, _selectedItem.Content, _selectedItem.Image));
        }

        private void OpenWebPageGazeta()
        {
            Navigation.PushAsync(new NewsPage(_selectedItemGazeta.Title, _selectedItemGazeta.Content, _selectedItemGazeta.Image));
        }

        private void OpenWebPageAdvert()
        {
            Navigation.PushAsync(new NewsPage(_selectedItemAdvert.Title, _selectedItemAdvert.Content, _selectedItemAdvert.Image));
        }
    }
}

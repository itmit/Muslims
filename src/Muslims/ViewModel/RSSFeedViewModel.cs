using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;
using Muslims.Models;
using Muslims.Network;
using Xamarin.Forms;

namespace Muslims.ViewModel
{
    public class RSSFeedViewModel : INotifyPropertyChanged
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
        private NewsItem selectedItem = null;
        private NewsItem selectedItemGazeta = null;
        private NewsItem selectedItemAdvert = null;
        private INavigation Navigation;
        public NewsItem SelectedItem
        {
            get => selectedItem;
            set
            {
                if (selectedItem != value)
                {
                    selectedItem = value;
                    OnPropertyChanged("SelectedItem");
                    OpenWebPage();
                }
            }
        }
        public NewsItem SelectedItemGazeta
        {
            get => selectedItemGazeta;
            set
            {
                if (selectedItemGazeta != value)
                {
                    selectedItemGazeta = value;
                    OnPropertyChanged("SelectedItemGazeta");
                    OpenWebPageGazeta();
                }
            }
        }
        public NewsItem SelectedItemAdvert
        {
            get => selectedItemAdvert;
            set
            {
                if (selectedItemAdvert != value)
                {
                    selectedItemAdvert = value;
                    OnPropertyChanged("SelectedItemAdvert");
                    OpenWebPageAdvert();
                }
            }
        }

        private ObservableCollection<NewsItem> _feedList;
		private ObservableCollection<NewsItem> _feedListGazeta;
		private ObservableCollection<NewsItem> _feedListAdvert;
        public event PropertyChangedEventHandler PropertyChanged;

        public RSSFeedViewModel(INavigation navigation)
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
            Navigation.PushAsync(new NewsPage(selectedItem.Title, selectedItem.Content, selectedItem.Image));
        }

        private void OpenWebPageGazeta()
        {
            Navigation.PushAsync(new NewsPage(selectedItemGazeta.Title, selectedItemGazeta.Content, selectedItemGazeta.Image));
        }

        private void OpenWebPageAdvert()
        {
            Navigation.PushAsync(new NewsPage(selectedItemAdvert.Title, selectedItemAdvert.Content, selectedItemAdvert.Image));
        }
    }
}

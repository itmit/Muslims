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
            get => feedList;
            set
            {
                if (feedList != value)
                {
                    feedList = value;
                    OnPropertyChanged("FeedList");
                }

            }
        }
        public ObservableCollection<NewsItem> FeedListGazeta
        {
            get => feedListGazeta;
            set
            {
                if (feedListGazeta != value)
                {
                    feedListGazeta = value;
                    OnPropertyChanged("FeedListGazeta");
                }

            }
        }
        public ObservableCollection<NewsItem> FeedListAdvert
        {
            get => feedListAdvert;
            set
            {
                if (feedListAdvert != value)
                {
                    feedListAdvert = value;
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
        ObservableCollection<NewsItem> feedList = null;
        ObservableCollection<NewsItem> feedListGazeta = null;
        ObservableCollection<NewsItem> feedListAdvert = null;
        public event PropertyChangedEventHandler PropertyChanged;

        public RSSFeedViewModel(INavigation navigation)
        {
            this.GetNewsFeedAsync();
            this.GetGazetaFeedAsync();
            this.GetAdvertFeedAsync();
            Navigation = navigation;
        }

        public async void GetNewsFeedAsync()
        {
            NetworkManager manager = NetworkManager.Instance;
            List<NewsItem> list = await manager.GetSyncFeedAsync();
            FeedList = new ObservableCollection<NewsItem>(list);
        }
        public async void GetGazetaFeedAsync()
        {
            NetworkManagerGazeta manager = NetworkManagerGazeta.Instance;
            List<NewsItem> gazetalist = await manager.GetSyncFeedAsync();
            FeedListGazeta = new ObservableCollection<NewsItem>(gazetalist);
        }
        public async void GetAdvertFeedAsync()
        {
            NetworkManagerAdvert manager = NetworkManagerAdvert.Instance;
            List<NewsItem> advertlist = await manager.GetSyncFeedAsync();
            FeedListAdvert = new ObservableCollection<NewsItem>(advertlist);
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

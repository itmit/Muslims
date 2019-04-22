using System.Collections.Generic;
using Muslims.Models;
using Muslims.ViewModel;
using Xamarin.Forms;

namespace Muslims
{
    public partial class News : TabbedPage
    {
        RSSFeedViewModel RSSFeedViewModelObject;

        public News()
        {
            InitializeComponent();

            RSSFeedViewModelObject = new RSSFeedViewModel(Navigation);

            BindingContext = RSSFeedViewModelObject;

        }

    }
}

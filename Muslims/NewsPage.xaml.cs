using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Muslims.Models;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Muslims
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NewsPage : ContentPage
	{
        private string ContentBind;
        private string ImageBind;
        private string TitleBind;
        public string NewsContentBind
        {
            get { return ContentBind; }
            set
            {
                ContentBind = value;
                OnPropertyChanged(nameof(NewsContentBind));
            }
        }
        public string NewsImageBind
        {
            get { return ImageBind; }
            set
            {
                ImageBind = value;
                OnPropertyChanged(nameof(NewsImageBind));
            }
        }
        public string NewsTitleBind
        {
            get { return TitleBind; }
            set
            {
                TitleBind = value;
                OnPropertyChanged(nameof(NewsTitleBind));
            }
        }
        public NewsPage (string PageTitle, string Description, string Image)
		{
			InitializeComponent ();
            BindingContext = this;

            NewsImageBind = Image;
            NewsContentBind = Description;
            NewsTitleBind = PageTitle;
        }

    }
}
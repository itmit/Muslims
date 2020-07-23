using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Muslims.View.News
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NewsPage : ContentPage
	{
		#region Data
		#region Fields
		private string ContentBind;
		private string ImageBind;
		private string TitleBind;
		#endregion
		#endregion

		#region .ctor
		public NewsPage(string PageTitle, string Description, string Image)
		{
			InitializeComponent();
			BindingContext = this;

			NewsImageBind = Image;
			NewsContentBind = Description;
			NewsTitleBind = PageTitle;
		}
		#endregion

		#region Properties
		public string NewsContentBind
		{
			get => ContentBind;
			set
			{
				ContentBind = value;
				OnPropertyChanged(nameof(NewsContentBind));
			}
		}

		public string NewsImageBind
		{
			get => ImageBind;
			set
			{
				ImageBind = value;
				OnPropertyChanged(nameof(NewsImageBind));
			}
		}

		public string NewsTitleBind
		{
			get => TitleBind;
			set
			{
				TitleBind = value;
				OnPropertyChanged(nameof(NewsTitleBind));
			}
		}
		#endregion
	}
}

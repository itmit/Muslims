using System.Threading.Tasks;
using Muslims.View.Gallery;
using Muslims.View.Library;
using Muslims.View.Namaz;
using Muslims.ViewModel;
using Plugin.Connectivity;
using Xamarin.Forms;

namespace Muslims.View
{
	public partial class MainPage : MasterDetailPage
	{
		#region .ctor
		public MainPage()
		{
			InitializeComponent();

			switch (Device.RuntimePlatform)
			{
				case Device.iOS:
				{
					MenuCollectionView.Margin = new Thickness(0, 21, 0, 0);
					break;
				}
				case Device.Android:
				{
					MenuCollectionView.Margin = new Thickness(0, 21, 0, 0);
					break;
				}
			}
			Master.BindingContext = new MenuViewModel();
		}
		#endregion

		private async void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			((CollectionView) sender).SelectedItem = null;
			await Task.Delay(500);
			IsPresented = false;
		}
	}
}

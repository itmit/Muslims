using Muslims.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Muslims.View.Namaz
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Namaz_Time : ContentPage
	{
		#region .ctor
		public Namaz_Time()
		{
			InitializeComponent();

			BindingContext = new NamazTimesViewModel();
		}
		#endregion
	}
}

using System.ComponentModel;

namespace Muslims
{
	internal class GalleryViewModel : INotifyPropertyChanged
	{
		#region Delegates and events
		public event PropertyChangedEventHandler PropertyChanged;
		#endregion

		#region Data
		#region Fields
		private readonly Gallery_Image path;
		#endregion
		#endregion

		#region .ctor
		public GalleryViewModel() => path = new Gallery_Image();
		#endregion

		#region Properties
		public string Image
		{
			get => path.Image_Path;
			set
			{
				if (path.Image_Path != value)
				{
					path.Image_Path = value;
					OnPropertyChanged("ImagePath");
				}
			}
		}
		#endregion

		#region Protected
		protected void OnPropertyChanged(string propName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propName));
			}
		}
		#endregion
	}
}

using Xamarin.Forms;
using XFTheme.Resources;

namespace XFTheme
{
	public partial class XFThemePage : ContentPage
	{
		App App => Application.Current as App;

		public XFThemePage()
		{
			InitializeComponent();

			AppThemeButton.Clicked += (sender, e) => {
				App.ApplyAppTheme();
			};

			OtherThemeButton.Clicked += (sender, e) => {
				App.ApplyOtherTheme();
			};
		}
	}
}

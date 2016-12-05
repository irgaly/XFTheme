using Xamarin.Forms;
using XFTheme.Resources;

namespace XFTheme
{
	public partial class App : Application
	{
		public bool IsOtherTheme { get; private set; }

		public App()
		{
			IsOtherTheme = true;

			InitializeComponent();
		}

		protected override void OnStart()
		{
			// App.xaml により Resources = AppTheme が設定されている状態で開始

			if (IsOtherTheme)
			{
				Resources = new OtherTheme(); // リソース差し替え
			}

			MainPage = new XFThemePage();
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}

		public void ApplyAppTheme() {
			MainPage.Parent = null;
			Resources = new AppTheme();
			MainPage.Parent = this;  // Parent を再設定することにより View 内の DynamicResource プロパティを更新させる
		}

		public void ApplyOtherTheme() {
			MainPage.Parent = null;
			Resources = new OtherTheme();
			MainPage.Parent = this;  // Parent を再設定することにより View 内の DynamicResource プロパティを更新させる
		}
	}
}

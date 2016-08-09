using Xamarin.Forms;

namespace SecondApp
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new SecondAppPage();
		}

		protected override void OnStart()
		{
			
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}


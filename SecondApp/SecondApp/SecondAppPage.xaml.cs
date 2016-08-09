using System;
using Xamarin.Forms;

namespace SecondApp
{
	public partial class SecondAppPage : ContentPage
	{
		int count = 0;
		public SecondAppPage()
		{
			InitializeComponent();

			Button button = new Button
			{
				Text = String.Format("Tap for click count!")
			};
			button.Clicked += (sender, args) =>
			{
				count++;
				button.Text =
					String.Format("{0} click{1}!", count, count == 1 ? "" : "s");
			};

			this.Content = button;
		}
	}
}


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

			Padding = new Thickness(20);
			var red = new Label
			{
				Text = "Stop",
				BackgroundColor = Color.Red,
				FontSize = 20
			};
			var yellow = new Label
			{
				Text = "Slow down",
				BackgroundColor = Color.Yellow,
				FontSize = 20
			};
			var green = new Label
			{
				Text = "Go",
				BackgroundColor = Color.Green,
				FontSize = 20
			};


			var button = new Button
			{
				Text = String.Format("Tap for click count!")
			};
			button.Clicked += (sender, args) =>
			{
				count++;
				button.Text =
					String.Format("{0} click{1}!", count, count == 1 ? "" : "s");
			};

			//this.Content = button;
			this.Content = new StackLayout
			{
				Spacing = 10,
				Children = { red, yellow, green, button }
			};
		}
	}
}


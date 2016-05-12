using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CrossAPp
{
	public partial class SecondPage : ContentPage
	{
		public SecondPage ()
		{
			InitializeComponent ();
		}

		async void OnNavigateButtonClicked (object sender, EventArgs e)
		{
			await Navigation.PopAsync ();
		}
	}
}


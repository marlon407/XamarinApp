using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CrossAPp
{
	public partial class MainPage : ContentPage
	{
		public MainPage ()
		{
			InitializeComponent ();

			List<Bill> bills = new List<Bill> ();
			bills.Add (
				new Bill () {
					Day = 1, Id = 1, Name = "Luz", Value = 20
				}
			);
			bills.Add (
				new Bill () {
					Day = 2, Id = 2, Name = "Agua", Value = 20
				}
			);
			bills.Add (
				new Bill () {
					Day = 3, Id = 3, Name = "Aluguel", Value = 20
				}
			);
			bills.Add (
				new Bill () {
					Day = 4, Id = 4, Name = "Academia", Value = 20
				}
			);
			BillView.ItemTapped += (object sender, ItemTappedEventArgs e) => {
				var secondPage = new SecondPage ();
				secondPage.BindingContext = (sender as ListView).SelectedItem;
				Navigation.PushAsync (secondPage);	
			};
			BillView.ItemsSource = bills;
		}

		async void OnNavigateButtonClicked (object sender, EventArgs e)
		{
			var secondPage = new SecondPage ();
			await Navigation.PushAsync (secondPage);
		}
	}
}


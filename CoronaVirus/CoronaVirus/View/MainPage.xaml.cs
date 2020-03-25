using CoronaVirus.Utils;
using CoronaVirus.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CoronaVirus.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
			BindingContext = ViewModelLocator.GetVirus;
		}
		protected override void OnAppearing()
		{
			RestApi restApi = new RestApi();
			restApi.GetInfoViruses();
			base.OnAppearing();
		}
	}
}
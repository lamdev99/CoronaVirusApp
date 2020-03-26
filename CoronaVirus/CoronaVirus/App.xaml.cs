using CoronaVirus.Utils;
using CoronaVirus.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CoronaVirus
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new MainTabbedPane();
		}

		protected override void OnStart()
		{
			RestApi restApi = new RestApi();
			restApi.GetInfoViruses();
			restApi.GetSummary();
			base.OnStart();

			
		}

		protected override void OnSleep()
		{
		}

		protected override void OnResume()
		{
		}
	}
}

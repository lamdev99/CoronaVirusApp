using CoronaVirus.Utils;
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
	public partial class MainTabbedPane : TabbedPage
	{
		public MainTabbedPane()
		{
			InitializeComponent();
		}
		protected override void OnAppearing()
		{
			base.OnAppearing();
		}
	}
}
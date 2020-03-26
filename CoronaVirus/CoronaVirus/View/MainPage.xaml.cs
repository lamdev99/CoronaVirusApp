using CoronaVirus.Model;
using CoronaVirus.Utils;
using CoronaVirus.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

		private void OnItemTapped(object sender, ItemTappedEventArgs e)
		{
			var infoVirus = e.Item as InfoVirus;
			var masterPage = this.Parent as TabbedPage;
			ViewModelLocator.GetVirus.InfoVirus = infoVirus;
			masterPage.CurrentPage = masterPage.Children[1];
		}

		private void OnTextChanged(object sender, TextChangedEventArgs e)
		{
			string s = searchBar.Text.ToLower();
			if (s.Length == 0) {
				ViewModelLocator.GetVirus.InfoViruses = ViewModelLocator.GetVirus.DataUsage;
			}
			else
			{
				ObservableCollection<InfoVirus> dataSearch = new ObservableCollection<InfoVirus>();
				foreach (InfoVirus info in ViewModelLocator.GetVirus.DataUsage)
				{
					if (info.Country.ToLower().Contains(s))
					{
						dataSearch.Add(info);
					}
				}
				ViewModelLocator.GetVirus.InfoViruses = dataSearch;
			}
		}
	}
}
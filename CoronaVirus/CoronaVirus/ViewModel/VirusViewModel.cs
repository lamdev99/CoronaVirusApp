using CoronaVirus.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using Xamarin.Forms.Maps;

namespace CoronaVirus.ViewModel
{
	class VirusViewModel : INotifyPropertyChanged
	{

		private Summary summary;
		private ObservableCollection<InfoVirus> infoViruses;
		private ObservableCollection<InfoVirus> dataUseage;
		private InfoVirus infoVirus;
		private List<Pins> pins;
		bool firstChanged = true;
		public List<Pins> Pinss
		{
			get => pins;
			set
			{
				pins = value;
				RaisePropertyChanged("Pinss");
			}
		}
		public ObservableCollection<InfoVirus> DataUsage
		{
			get => dataUseage;
			set
			{
				dataUseage = value;
				if (firstChanged)
				{
					infoViruses = dataUseage;
					RaisePropertyChanged("InfoViruses");
					infoVirus = InfoViruses[0];
					RaisePropertyChanged("InfoVirus");
					firstChanged = false;
					List<Pins> pos = new List<Pins>();
					foreach(InfoVirus info in dataUseage)
					{
						Position position = new Position(info.CountryInfo.Lat, info.CountryInfo.Long);
						string address = info.Country;
						string label = info.Cases + "";
						pos.Add(new Pins(position, address, label));
					}
					pins = pos;
					RaisePropertyChanged("Pinss");
					
				}
				RaisePropertyChanged("DataUsage");
			}
		}
		public InfoVirus InfoVirus
		{
			get => infoVirus;
			set
			{
				infoVirus = value;
				RaisePropertyChanged("InfoVirus");
			}
		}
		public Summary Summaryy
		{
			get => summary;
			set
			{
				summary = value;
				RaisePropertyChanged("Summaryy");
			}
		}
		public ObservableCollection<InfoVirus> InfoViruses
		{
			get => infoViruses;
			set
			{
				infoViruses = value;
				
				RaisePropertyChanged("InfoViruses");
			}
		}
		public VirusViewModel()
		{
		}
		public event PropertyChangedEventHandler PropertyChanged;
		void RaisePropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
				PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}

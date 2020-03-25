using CoronaVirus.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace CoronaVirus.ViewModel
{
	class VirusViewModel : INotifyPropertyChanged
	{
		private ObservableCollection<InfoVirus> infoViruses;
		public ObservableCollection<InfoVirus> InfoViruses
		{
			get => infoViruses;
			set
			{
				infoViruses = value;
				RaisePropertyChanged("InfoViruses");
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;
		void RaisePropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
				PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}

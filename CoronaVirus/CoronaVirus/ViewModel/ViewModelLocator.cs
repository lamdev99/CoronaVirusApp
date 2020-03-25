using System;
using System.Collections.Generic;
using System.Text;

namespace CoronaVirus.ViewModel
{
	class ViewModelLocator
	{
		private static VirusViewModel virusViewModel = new VirusViewModel();
		public static VirusViewModel GetVirus
		{
			get => virusViewModel;
		}
	}
}

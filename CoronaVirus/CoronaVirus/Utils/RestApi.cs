using CoronaVirus.Model;
using CoronaVirus.ViewModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Text;

namespace CoronaVirus.Utils
{
	class RestApi
	{

		private const string Url1 = "https://corona.lmao.ninja/all";
		private const string Url = "https://corona.lmao.ninja/countries"; //This url is a free public api intended for demos
		private readonly HttpClient _client = new HttpClient(); //Creating a new instance of HttpClient. (Microsoft.Net.Http)
		private ObservableCollection<InfoVirus> viruses = new ObservableCollection<InfoVirus>();
		private Summary summaries = new Summary();
		public async void GetInfoViruses()
		{
			string content = await _client.GetStringAsync(Url); //Sends a GET request to the specified Uri and returns the response body as a string in an asynchronous operation
			viruses = JsonConvert.DeserializeObject<ObservableCollection<InfoVirus>>(content); //Deserializes or converts JSON String into a collection of Post
			ViewModelLocator.GetVirus.DataUsage = viruses;

		}
		public async void GetSummary()
		{
			string content = await _client.GetStringAsync(Url1); //Sends a GET request to the specified Uri and returns the response body as a string in an asynchronous operation
			summaries = JsonConvert.DeserializeObject<Summary>(content); //Deserializes or converts JSON String into a collection of Post
			ViewModelLocator.GetVirus.Summaryy = summaries;
		}
	}
}

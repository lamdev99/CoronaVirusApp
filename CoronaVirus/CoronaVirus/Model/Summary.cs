using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CoronaVirus.Model
{
	class Summary
	{
		[JsonProperty("cases")]
		public int cases { get;set; }
		[JsonProperty("deaths")]
		public int deaths { get; set; }
		[JsonProperty("recovered")]
		public int recovered { get; set; }
		[JsonProperty("time")]
		public long time { get; set; }
		public string datetime
		{
			get
			{
				long i = this.time;
				DateTime dt;
				string formattedDateTime = "";
				if (DateTime.TryParseExact(this.time.ToString(), "yyyyMMdd",
										  CultureInfo.InvariantCulture,
										  DateTimeStyles.None, out dt))
				{
					formattedDateTime = dt.ToString("yyyy:MM:dd", CultureInfo.InvariantCulture);
				}
				return formattedDateTime;
			}
			set { if(this.time>0) datetime = this.time.ToString(); }
		}
	}
}

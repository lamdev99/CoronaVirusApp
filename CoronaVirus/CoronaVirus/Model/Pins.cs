using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms.Maps;

namespace CoronaVirus.Model
{
	class Pins
	{
		public Position position { get; set; }
		public string address { get; set; }
		public string label { get; set; }
		public Pins(Position position,string address, string label)
		{
			this.position = position;
			this.address = address;
			this.label = label;
		}
	}
}

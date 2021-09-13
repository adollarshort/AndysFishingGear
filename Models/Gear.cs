using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AndysFishingGear.Models
{
	public class Gear
	{
		public int Id { get; set; }
		public string Model { get; set; }
		public string Manufacturer { get; set; }
		public string Type { get; set; }
		public decimal Price { get; set; }
	}
}

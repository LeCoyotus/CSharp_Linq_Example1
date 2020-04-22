using System;
using System.Collections.Generic;
using System.Xml;

namespace ExoLinq9
{
	public class Monument
	{
		public UniqueId Id { get; set; }
		public string Name { get; set; }
		public UniqueId CityId { get; set; }

		public Dictionary<DateTime,int> NbVisiteByDay { get; set; }

		public Monument(string name, UniqueId cityId)
		{
			Name = name;
			Id = new UniqueId();
			CityId = cityId;
			NbVisiteByDay = new Dictionary<DateTime, int>();
		}
	}
}
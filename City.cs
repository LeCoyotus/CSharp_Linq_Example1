using System.Xml;

namespace ExoLinq9
{
	public class City
	{
		public UniqueId Id { get; set; }
		public string Name { get; set; }
		public string Country { get; set; }

		public City(string name, string country)
		{
			Id = new UniqueId();
			Name = name;
			Country = country;
		}
	}
}
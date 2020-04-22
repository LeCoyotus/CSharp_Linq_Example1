using System.Xml;

namespace ExoLinq9
{
	public class Product
	{
		public UniqueId Id { get; set; }
		public UniqueId MonumentId { get; set; }
		public string Name { get; set; }
		public int Price { get; set; }

		public Product(UniqueId monumentId, string name, int price)
		{
			Id = new UniqueId();
			MonumentId = monumentId;
			Name = name;
			Price = price;
		}
	}
}
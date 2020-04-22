using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace ExoLinq9
{
	public class ShoppingCart
	{
		public UniqueId Id { get; set; }
		public List<Product> Products { get; set; }

		public int Total
		{
			get { return Products.Sum(p => p.Price); }
		}

		public ShoppingCart()
		{
			Id = new UniqueId();
			Products = new List<Product>();
		}
	}
}
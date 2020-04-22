using System;
using System.Collections.Generic;
using System.Linq;

namespace ExoLinq9
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Monument> monuments = new List<Monument>();
			List<ShoppingCart> shoppingCarts = new List<ShoppingCart>();
			List<Product> products = new List<Product>();
			List<City> cities = new List<City>();

			DateTime date1 = new DateTime(2010, 9, 10);
			DateTime date2 = new DateTime(2011, 10, 10);

			City metz = new City("Metz", "France");

			var averageVisite = monuments[0].NbVisiteByDay.Average(d => d.Value);

			var nbVisiteBetween =
				monuments[0].NbVisiteByDay.Where(d => d.Key > date1 && d.Key < date2).Sum(n => n.Value);

			var allMonumentOfThisCountry = monuments.Where(m => m.CityId == metz.Id);

			var ordMonument = monuments.GroupBy(m => m.CityId).ToList();

			var averageShoppingCart = shoppingCarts.Average(s => s.Total);

			var averageProductPrice = shoppingCarts.SelectMany(s => s.Products).Average(p => p.Price);
		}
	}
}

using System;

namespace Project 
{
	class Program
	{
		static void Main(string[] args) 
		{
			Jo brand1 = new Jo();
			brand1.WeedBrands = "17 Farms";
			brand1.WeedName = "Tropicana Cookies";
			brand1.WeedType = "Flower";

			Jo brand2 = new Jo();
			brand2.WeedBrands = "#HASH";
			brand2.WeedName = "#HASH #WAX Sugar";
			brand2.WeedType = "hash";

			Jo brand3 = new Jo();
			brand3.WeedBrands = "1(833) SEED USA";
			brand3.WeedName = "AK 47 ";
			brand3.WeedType = "seed";

			Jo[] brands = new Jo[] { brand1, brand2, brand3 };

            foreach (var brand in brands)
            {
                Console.WriteLine("Brand:" + brand.WeedBrands);
				Console.WriteLine("Type:" + brand.WeedType);
                Console.WriteLine("Name:" + brand.WeedName);
            }

			Console.ReadKey();


        }
	}
	class Jo
	{
        public string WeedBrands { get; set; }
		public string WeedName { get; set; }
        public string WeedType { get; set; }
    }
}

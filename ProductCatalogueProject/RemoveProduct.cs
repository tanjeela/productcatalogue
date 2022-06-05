using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace ProductCatalogueProject
{
    public class RemoveProduct : MainMenu
    {
        public void RemoveAProduct()
        {
            Console.WriteLine("Please select which product to remove: \n 1. Sneakers \n 2.Bag");
            int Remove = Int32.Parse(Console.ReadLine());
            string SneakersData = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "SneakersCatalogue.json"));
            SneakersCatalogue = JsonSerializer.Deserialize<Catalogue<Sneakers>>(SneakersData);

            if (Remove == 1)
            {
                Console.WriteLine("Please enter which Sneakers to be removed");
                name = Console.ReadLine();
                SneakersCatalogue.RemoveItem(name);
                filepath = Path.Combine(Directory.GetCurrentDirectory(), "SneakersCatalogue.json");
                File.WriteAllText(filepath, JsonCatalogue.serialise(SneakersCatalogue));
            }
            if (Remove == 2)
            {
                Console.WriteLine("Please enter which Bag to be removed");
                name = Console.ReadLine();
                BagCatalogue.RemoveItem(name);
                string BagData = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "BagCatalogue.json"));
                BagCatalogue = JsonSerializer.Deserialize<Catalogue<Bag>>(BagData);
                
                filepath = Path.Combine(Directory.GetCurrentDirectory(), "BagCatalogue.json");
                File.WriteAllText(filepath, JsonCatalogue.serialise(BagCatalogue));
            }
        }

    }
}

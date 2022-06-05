using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace ProductCatalogueProject
{
    public class ClearCatalogue : MainMenu
    {
       // public int OptionNumber = Int32.Parse(Console.ReadLine());
        public void ClearACatalogue()
        
        {
            while (OptionsSelected == true)
            {   int OptionNumber = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Please select which Catalogue you would like to Clear: \n 1.Sneakers \n 2.Bag \n 3.Exit");

                if (OptionNumber == 3)
                {
                    OptionsSelected = false;
                }

                if (OptionNumber == 1)
                {
                    string SneakersData = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "SneakersCatalogue.json"));
                    SneakersCatalogue = JsonSerializer.Deserialize<Catalogue<Sneakers>>(SneakersData);
                    SneakersCatalogue.ClearItem();
                    filepath = Path.Combine(Directory.GetCurrentDirectory(), "SneakersCatalogue.json");
                    File.WriteAllText(filepath, JsonCatalogue.serialise(SneakersCatalogue));
                    Console.WriteLine("Sneaker Catalogue is now cleared");
                }

                if (OptionNumber == 2)
                {
                    string BagData = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "BagCatalogue.json"));
                    BagCatalogue = JsonSerializer.Deserialize<Catalogue<Bag>>(BagData);
                    BagCatalogue.ClearItem();
                    filepath = Path.Combine(Directory.GetCurrentDirectory(), "BagCatalogue.json");
                    File.WriteAllText(filepath, JsonCatalogue.serialise(BagCatalogue));
                    Console.WriteLine("Bag Catalogue is now cleared");
                }
            }
        }
    }
}

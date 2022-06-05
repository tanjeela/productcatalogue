using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace ProductCatalogueProject
{
    public class ViewCatalogue : MainMenu
    {
         
        public void ViewACatalogue()
        {
            Console.WriteLine("Please select which Catalogue to view: \n 1. Sneakers \n 2.Bag");
            int OptionNumber = Int32.Parse(Console.ReadLine());
            if (OptionNumber == 1)
            {
                //string SneakersData = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "SneakersCatalogue.json"));
                //SneakersCatalogue = JsonSerializer.Deserialize<Catalogue<Sneakers>>(SneakersData);
                Console.WriteLine("Sneakers Catalogue: ");
                //if (SneakersCatalogue.ProductsCatalogue.Count == 0)
                //{
                //    Console.WriteLine("\n Catalogue is Empty \n");

                //}
                //foreach (Sneakers item in SneakersCatalogue.ProductsCatalogue)
                //{
                //    Console.WriteLine($"\n Products in Sneakers Catalogue: {item.ProductName}");
                //}
                foreach (KeyValuePair<string, Sneakers> pair in SneakersCatalogue.Dictionary)
                {

                    Console.WriteLine($"Sneakers Name:{pair.Key} - {pair.Value}");

                }
                string SneakersData = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "SneakersCatalogue.json"));
                SneakersCatalogue = JsonSerializer.Deserialize<Catalogue<Sneakers>>(SneakersData);
            }
            else
            {
                //string BagData = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "BagCatalogue.json"));
                //BagCatalogue = JsonSerializer.Deserialize<Catalogue<Bag>>(BagData);
                Console.WriteLine("Bag Catalogue: ");
                foreach (KeyValuePair<string, Bag> pair in BagCatalogue.Dictionary)
                {

                    Console.WriteLine($"Bag Name:{pair.Key} - {pair.Value}");

                }
                //if (BagCatalogue.ProductsCatalogue.Count == 0)
                //{
                //    Console.WriteLine("\n Catalogue is Empty \n");

                //}
                //foreach (Bag item in BagCatalogue.ProductsCatalogue)
                //{
                //    Console.WriteLine($"\n Products in Bag Catalogue: {item.ProductName}");
                //}
                string BagData = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "BagCatalogue.json"));
                BagCatalogue = JsonSerializer.Deserialize<Catalogue<Bag>>(BagData);
            }
        }
        
    }
}

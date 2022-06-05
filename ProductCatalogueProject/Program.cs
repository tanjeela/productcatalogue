using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
namespace ProductCatalogueProject
{
    class Program
    {
        

        static void Main(string[] args)
        {


            //The menu should have:
            //Create Catalogue(optional)
            //View a catalogue --> User input say numbers to pick their choices. 
            //Add a new product to a catalogue
            //Remove a product
            //Remove a catalogue


            //Console.WriteLine("Please input which Catalogue you would like to view: ");
            //Console.WriteLine("Which product would you like to add?");
            //Create two catalogues for Bags and Shoes
            //For the user to input
            //Catalogue<Bag> BagCatalogue = new Catalogue<Bag>();
            //Catalogue<Shoe> Shoecatalogue = new Catalogue<Shoe>();

            

            bool showMenu = true;

            MainMenu MainMenu = new MainMenu();

            while (showMenu)
            {
                showMenu = MainMenu.ShowMainMenu();
            }

            //SneakersData = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "SneakersCatalogue.json"));
            //Catalogue<Sneakers> SneakersCatalogue = JsonSerializer.Deserialize<Catalogue<Sneakers>>(SneakersData);

            //BagData = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "BagCatalogue.json"));
            //Catalogue<Bag> BagCatalogue = JsonSerializer.Deserialize<Catalogue<Bag>>(BagData);


        }
    }
}

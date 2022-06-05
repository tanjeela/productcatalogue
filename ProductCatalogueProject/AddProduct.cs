using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProductCatalogueProject
{
    public class AddProduct : MainMenu
    {
        //public Catalogue<Bag> bagCatalogue = new Catalogue<Bag>();
        //public Catalogue<Sneakers> sneakersCatalogue = new Catalogue<Sneakers>();
        
        public void AddAProduct()
        {
            //bool options = true;
            while (OptionsSelected == true)
            {   
                
                Console.WriteLine("Would you like to add: \n 1.Sneakers \n 2. Bag \n 3. or Exit");
                int OptionNumber = Int32.Parse(Console.ReadLine());

                if (OptionNumber == 3)
                {
                    OptionsSelected = false;
                }

                if (OptionNumber == 1)
                {
                    Console.WriteLine("Please enter name of Sneakers");
                    name = Console.ReadLine();
                    Console.WriteLine("Please enter price of Sneakers");
                    price = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter your Sneaker size");
                    size = Int32.Parse(Console.ReadLine());

                    // Need an if statement if user doesn't enter details correctly
                    if (price < 0 || name.Length == 0 || size < 0)
                    {
                        Console.WriteLine("Incomplete/Incorrect Details. Please check and enter correctly.");
                        OptionsSelected = false;
                    }

                else
                    {
                        SneakersCatalogue.AddItem(name,Sneakers.SneakersInput(name, price, size));
                        Console.WriteLine($"{name} has been added to the catalogue");
                        //Need to do GST with total price????
                        Console.Write($"Total including GST of {name} is: ");
                        Console.WriteLine(Sneakers.SneakersInput(name, price, size).GST());

                    }

                    filepath = Path.Combine(Directory.GetCurrentDirectory(), "SneakersCatalogue.json");
                    File.WriteAllText(filepath, JsonCatalogue.serialise(SneakersCatalogue));
                }

                if (OptionNumber == 2)
                {
                    Console.WriteLine("Please enter name of Bag");
                    name = Console.ReadLine();
                    Console.WriteLine("Please enter price of Bag");
                    price = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter colour of Bag");
                    colour = Console.ReadLine();
                    if (price < 0 || name.Length == 0 || colour.Length == 0)
                    {
                        Console.WriteLine("Incomplete/Incorrect Details. Please check and enter correctly.");
                        OptionsSelected = false;
                    }
                else
                    {
                        BagCatalogue.AddItem(name, Bag.BagInput(name, price, colour));
                        Console.WriteLine($"{name} has been added to the catalogue");
                        //Need to do GST with total price????
                        Console.Write($"Total including GST of {name} is: ");
                        Console.WriteLine(Bag.BagInput(name, price, colour).GST());
                        filepath = Path.Combine(Directory.GetCurrentDirectory(), "BagCatalogue.json");
                        File.WriteAllText(filepath, JsonCatalogue.serialise(BagCatalogue));
                    }

                    //if (OptionNumber == 3)
                    //{
                    //    OptionsSelected = false;
                    //}

                }
                
            }
        }

    }
}

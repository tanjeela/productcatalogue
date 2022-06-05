using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
//using System.IO;

namespace ProductCatalogueProject
{
    public class MainMenu
    {
        
        public string name = " ";
        public double price = 0;
        public string colour = " ";
        public int size = 0;
        public bool OptionsSelected = true;
        //public int OptionNumber = Int32.Parse(Console.ReadLine());
        public string filepath = " ";
     

        public Catalogue<Bag> BagCatalogue = new Catalogue<Bag>();
        public Catalogue<Sneakers> SneakersCatalogue = new Catalogue<Sneakers>();





        public static bool ShowMainMenu()

        {
            Console.Clear();
            Console.WriteLine("Please select an option by adding the number from the Menu: \n");
            Console.WriteLine("1. Add a product \n");
            Console.WriteLine("2. Remove product from Catalogue \n");
            Console.WriteLine("3. View Catalogue \n");
            Console.WriteLine("4. Clear Catalogue \n");
           // Console.WriteLine("5. Calculate Total Price (inc. GST) \n ");

            // Console.Clear(); // Prints a blank screen

            string UserSelection = Console.ReadLine();

            switch (UserSelection)
            {
                    case "1":
                    
                    AddProduct AddProduct = new AddProduct();
                    AddProduct.AddAProduct();
                    return true;
                    

                    case "2":
                    RemoveProduct RemoveProduct = new RemoveProduct();
                    RemoveProduct.RemoveAProduct();
                    return true;
                   

                    case "3":
                    ViewCatalogue ViewCatalogue = new ViewCatalogue();
                    ViewCatalogue.ViewACatalogue();
                    return true;
                   

                    case "4":
                    ClearCatalogue ClearCatalogue = new ClearCatalogue();
                    ClearCatalogue.ClearACatalogue();
                    return true;
                    

                    default:
                    return true;


            }


            


        }
    }
}
//    Console.WriteLine("Which Catalogue would you like to view?");
//    Console.WriteLine("1. Sneakers Catalogue");
//    Console.WriteLine("2. Bag Catalogue");

//    if (UserSelection == "1")
//    {
//        sneakersCatalogue.viewCatalogue(sneakersCatalogue.ProductsCatalogue);
//        break;

//    }

//    else
//    {
//        bagCatalogue.viewCatalogue(bagCatalogue.ProductsCatalogue);
//    }
//    break;

//case "2":

//    Console.WriteLine("Which product would you like to add?");
//    Console.WriteLine("Please select from the following options: ");
//    Console.WriteLine("1. Sneakers");
//    Console.WriteLine("2. Bags");

//public MainMenu(Catalogue<Bag> BagCatalogue, Catalogue<Sneakers> SneakersCatalogue)
//{
//    bagCatalogue = BagCatalogue;
//    sneakersCatalogue = SneakersCatalogue;
//}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using System.IO;
//Generic in use
//<----Breakdown ----> 
// The type is the Products Class and has a constraint which bounds Product to Catalogue
namespace ProductCatalogueProject
{
    public class Catalogue<T> where T : Products


    {
        public Dictionary<string, T> ProductsCatalogue = new Dictionary<string, T>();
        // public Dictionary<string, T> Dictionary { get { return _catalogue; } }
        public Dictionary<string, T> Dictionary { get => ProductsCatalogue; set => ProductsCatalogue = value; }

        //Creating List to add Products to Catologue
        //public List<T> ProductsCatalogue = new List<T>();




        //// View Catalogue
        // public void viewCatalogue(List<T> ProductsCatalogue)
        // {
        //     string result = " "; 
        //   //  result = String.Format($"Product name = {productname.ProductName}")
        //     foreach (T ProductName in ProductsCatalogue)
        //     {
        //         Console.WriteLine(ProductName);
        //     }
        //}
        // Add item to Product Catalogue
        public void AddItem(string productname, T product)
        {
            ProductsCatalogue.Add(productname, product);
        }



        // Remove items from Product Catalogue
       public void RemoveItem(string productname)
        {
            ProductsCatalogue.Remove(productname);
        }

        public void ClearItem()
        {
            ProductsCatalogue.Clear();
        }




        public double CalculateTotalPrice()
        {
            double totalPrice = 0;
            foreach (Products item in Dictionary.Values)
            {
                totalPrice += item.GST();

            }
            return totalPrice;
        }





    }

}

//public static bool ProductAdded(Catalogue<Bag> BagCatalogue, Catalogue<Sneakers> SneakersCatalogue)
//{      
//   string userInput = Console.ReadLine();
//    if (userInput == "1")
//    {
//        Console.WriteLine("Which Sneakers would you like to add?");
//        Console.ReadLine(ProductName);
//    }

//}

//public void RemoveItem(string name)
//{
//    // Assumming its not there (-1 is your invalid index number)
//    int itemToRemoveIndex = -1;

//    for (int i = 0; i < ProductsCatalogue.Count; i++)
//    {
//        if (ProductsCatalogue[i].ProductName == name)
//        {
//            itemToRemoveIndex = i; // i represents the index of the product (i.e.ProductName)
//            break;
//        }
//    }

//    if (itemToRemoveIndex == -1)
//    {

//    }
//    else
//    {
//        ProductsCatalogue.RemoveAt(itemToRemoveIndex);

//    }
//}
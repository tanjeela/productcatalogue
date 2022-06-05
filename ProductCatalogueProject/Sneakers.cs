using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//public string ProductName;
//public string Occasion;
//public double Price;
//public string Colour;
//public string Type;
//public int Size;
namespace ProductCatalogueProject
{
    public class Sneakers : Products
        
    {
        public int _Size;
        public Sneakers(string productname, double price, int size)
    {       
            _Size = size; 
            _Price = price;
            _ProductName = productname;

    }

    
        
        public static Sneakers SneakersInput(string productname, double price, int size)
        {  
            Sneakers newSneakers = new Sneakers(productname, price, size);
            return newSneakers;
        }

        public override string ToString()
        {
            return $"Sneaker Price: {Price}, Sneaker Size: {_Size}";
        }


    }
}

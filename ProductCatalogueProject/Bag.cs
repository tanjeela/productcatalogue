using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalogueProject
{
    public class Bag : Products
    {
        string Colour;
        public Bag(string productname, double price, string colour)
        {

            _Price = price;
            _ProductName = productname;
            Colour = colour;
        }

        public static Bag BagInput(string productname, double price, string colour)
        {
                Bag newBag = new Bag(productname, price, colour);
                return newBag;
        }

        public override string ToString()
        {
            return $" Bag Price: {Price}, Bag Colour: {Colour}";
        }
    }
}

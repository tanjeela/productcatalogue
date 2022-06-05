using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ProductCatalogueProject
{
    public abstract class Products
    {
        // Declaring fields
        
 
        public string ProductName { get => _ProductName; }
        public double Price { get => _Price; }
        public string _ProductName;
        public double _Price;

        public Products(string productname, double price)
        {
            _ProductName = productname;
            _Price = price;
        }

        // empty constructor
        public Products()
        {

        }

        public virtual double GST()
        {
            return Price + (Price * 0.1);
        }

    }
}



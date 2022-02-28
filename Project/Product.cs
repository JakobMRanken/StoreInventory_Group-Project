using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Product
    {
        // ATTRIBUTES

        private string _name;
        private string _upc;
        private decimal _storePrice;
        private decimal _costPerCase;
        private int _unitsPerCase;
        private string _distributor;

        // CONSTRUCTOR(S)

        public Product(string name, string upc, decimal storePrice, decimal costPerCase, int unitsPerCase, string distributor)
        {
            _name = name;
            _upc = upc;
            _storePrice = storePrice;
            _costPerCase = costPerCase;
            _unitsPerCase = unitsPerCase;
            _distributor = distributor;
        }

        // PROPERTIES

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string UPC
        {
            get { return _upc; }
            set { _upc = value; }
        }

        public decimal StorePrice
        {
            get { return _storePrice; }
            set { _storePrice = value; }
        }

        public decimal CostPerCase
        {
            get { return _costPerCase; }
            set { _costPerCase = value; }
        }

        public int UnitsPerCase
        {
            get { return _unitsPerCase; }
            set { _unitsPerCase = value; }
        }

        public string Distributor
        {
            get { return _distributor; }
            set { _distributor = value; }
        }
    }
}
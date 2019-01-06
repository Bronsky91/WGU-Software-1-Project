using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968
{
    public abstract class Part
    {
        protected int _partID;
        protected string _name;
        protected double _price;
        protected int _inStock;
        protected int _min;
        protected int _max;

        public int getPartID()
        {
            return _partID;
        }

        public string getName()
        {
            return _name;
        }

        public double getPrice()
        {
            return _price;
        }

        public int getInStock()
        {
            return _inStock;
        }

        public int getMin()
        {
            return _min;
        }

        public int getMax()
        {
            return _max;
        }

        public void setPartID(int id)
        {
            _partID = id;
        }

        public void setName(string name)
        {
            _name = name;
        }

        public void setPrice(double price)
        {
            _price = price;
        }

        public void setInStock(int inStock)
        {
            _inStock = inStock;
        }

        public void setMin(int min)
        {
            _min = min;
        }

        public void setMax(int max)
        {
            _max = max;
        }
    }
}

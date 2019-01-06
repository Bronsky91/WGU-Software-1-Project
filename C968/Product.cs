using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968
{
    public class Product
    {
        private int _productID;
        private string _name;
        private double _price;
        private int _inStock;
        private int _min;
        private int _max;
        private ArrayList associatedParts = new ArrayList();

        public int getProductID()
        {
            return _productID;
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

        public void setProductID(int id)
        {
            _productID = id;
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

        public void addAssociatedPart(Part part)
        {
            associatedParts.Add(part);
        }

        public Part lookupPart(int partID)
        {
            foreach (Part p in associatedParts)
            {
                if (p.getProductID() == partID)
                {
                    return p;
                }
            }
            return null;
        }

        public bool removeAssociatedPart(int partID)
        {
            Part partToRemove = lookupPart(partID);
            if (partToRemove == null)
            {
                return false;
            }
            else
            {
                associatedParts.Remove(partToRemove);
                return true;
            }
        }
    }
}

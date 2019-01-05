using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968
{
    public static class Inventory
    {
        private static ArrayList productList = new ArrayList();
        private static ArrayList allParts = new ArrayList();

        public static void addProduct(Product product)
        {
            productList.Add(product);
        }

        public static Product lookupProduct(int productID)
        {
            foreach (Product p in productList)
            {
                if (p.getProductID() == productID)
                {
                    return p;
                }
            }
            return null;
        }

        public static bool removeProduct(int productID)
        {
            Product productToRemove = lookupProduct(productID);
            if (productToRemove == null)
            {
                return false;
            } 
            else
            {
                productList.Remove(productToRemove);
                return true;
            }
        }

        public static void updateProduct(int productID, Product product)
        {
            removeProduct(productID);
            addProduct(product);
        }

       
    }
}

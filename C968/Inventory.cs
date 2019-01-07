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

        public static ArrayList getAllParts()
        {
            return allParts;
        }

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

        public static void addPart(Part part)
        {
            allParts.Add(part);
        }

        public static Part lookupPart(int partID)
        {
            foreach (Part p in allParts)
            {
                if (p.getPartID() == partID)
                {
                    return p;
                }
            }
            return null;
        }

        public static bool deletePart(int partID)
        {
            Part partToDelete = lookupPart(partID);
            if (partToDelete == null)
            {
                return false;
            }
            else
            {
                productList.Remove(partToDelete);
                return true;
            }
        }

        public static void updatePart(int partID, Part part)
        {
            deletePart(partID);
            addPart(part);
        }

        public static int createPartID()
        {
            int highestID = 0;
            foreach (Part p in allParts)
            {
                if (p.getPartID() > highestID)
                    highestID = p.getPartID();
            }
            return highestID + 1;
        }

        public static int createProductID()
        {
            int highestID = 0;
            foreach (Product p in productList)
            {
                if (p.getProductID() > highestID)
                    highestID = p.getProductID();
            }
            return highestID + 1;
        }
    }
}

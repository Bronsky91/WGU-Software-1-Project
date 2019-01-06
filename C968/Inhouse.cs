using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968
{
    class Inhouse : Part
    {
        private int _machineID;

        public int getMachineID()
        {
            return _machineID;
        }

        public void setMachineID(int id)
        {
            _machineID = id;
        }

        public Inhouse(BasePart b, int machineID)
        {
            setPartID(b.partID);
            setName(b.name);
            setPrice(b.price);
            setInStock(b.inStock);
            setMin(b.min);
            setMax(b.max);
            setMachineID(machineID);
        }
    }
}

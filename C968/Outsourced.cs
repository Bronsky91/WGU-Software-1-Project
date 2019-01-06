using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968
{
    class Outsourced : Part
    {
        private string _companyName;

        public string getCompanyName()
        {
            return _companyName;
        }

        public void setCompanyName(string companyName)
        {
            _companyName = companyName;
        }
    }
}

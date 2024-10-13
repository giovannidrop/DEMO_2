using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace MyLibrary
{
    public class Product(int id,  string name, decimal unitPrice,int unitsInStock)
    {
        //propiedades
        public int Id => Id;
        public string Name => name;
        public decimal UnitPrice => unitPrice;
        public int UnitsInStock => unitsInStock;

        public bool Discontinued { get; private set; }

        public void SetDiscontinued() =>
            Discontinued = true;

        public bool GetStatus() =>
            Discontinued;
    }
}

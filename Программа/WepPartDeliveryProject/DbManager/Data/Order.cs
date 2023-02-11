using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbManager.Data
{
    public class Order:IModel
    {
        public double Price { get; set; }
        public List<OrderedObject> OrderedObjects { get; set; }
        public Person
    }
}

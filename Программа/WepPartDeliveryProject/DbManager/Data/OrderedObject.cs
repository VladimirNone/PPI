using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbManager.Data
{
    internal class OrderedObject : IModel
    {
        public double Price { get; set; }
        public Dish OrderedDish {get;set;}
        public int Count { get; set; }
    }
}

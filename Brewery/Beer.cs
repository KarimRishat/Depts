using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brewery
{
    public enum Filter { Unfiltered, Filtred }
    public enum Type { Ale, Lager}
    class Beer
    {
        readonly Type type;
        readonly Filter filter = Filter.Unfiltered;
        public decimal price;
        public Beer()
        {
            type = Type.Lager;
            filter = Filter.Filtred;
            price = 1;
        }
        public Beer(Type t)
        {
            type = t;
            filter = Filter.Filtred;
            price = 1;
        }
        public Beer(Type t, Filter f)
        {
            type = t;
            filter = f;
            price = 1;
        }
        public Beer(Type t, Filter f, decimal x)
        {
            type = t;
            filter = f;
            price = x;
        }
    }
}

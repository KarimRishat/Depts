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
        Type type;
        Filter filter = Filter.Unfiltered;

    }
}

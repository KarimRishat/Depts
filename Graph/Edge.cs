using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    class Edge
    {
        public Vertex start;
        public Vertex end;
        public int weight;
        public Edge(Vertex from, Vertex to, int weight = 1)
        {
            this.start = from;
            this.end = to;
            this.weight = weight;
        }
    }
}

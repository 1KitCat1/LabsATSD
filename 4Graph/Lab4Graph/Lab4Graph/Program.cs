using System;

namespace Lab4Graph
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int ed = 9, vert = 7;
            var edges = new Edge[ed];
            edges[0] = new Edge(0,1,28);
            edges[1] = new Edge(0,5,10);
            edges[2] = new Edge(1,6,14);
            edges[3] = new Edge(1,2,16);
            edges[4] = new Edge(2,3,12);
            edges[5] = new Edge(3,4,22);
            edges[6] = new Edge(3,6,18);
            edges[7] = new Edge(4,5,25);
            edges[8] = new Edge(4,6,24);

            
            var graph = new Graph(ed, vert, edges);
            var kruskal = graph.Kruskals();
            kruskal.PrintGraph();
            graph.Dijkstra(0);
            var dij = graph.DijkstraWithNextHop(0);
            var nextHope = dij[1];
            var dijkstraVal = dij[0];
            for (int i = 0; i < graph.AmountVert; i++)
            {
                Console.WriteLine(dijkstraVal[i] + " " + nextHope[i]);
            }
            //graph.PrintGraph();
        }
    }
}
using System;

namespace Lab4Graph
{
    public class Edge
    {
        public int Vertex1 { get; protected set; }
        public int Vertex2 { get; protected set; }
        public int Weight { get; protected set; }

        public Edge(int vertex1, int vertex2, int weight)
        {
            Vertex1 = vertex1;
            Vertex2 = vertex2;
            Weight = weight;
        }
    }
}
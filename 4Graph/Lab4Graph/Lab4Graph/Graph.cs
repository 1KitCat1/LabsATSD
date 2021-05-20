using System;
using System.Runtime.InteropServices;

namespace Lab4Graph
{
    public class Graph
    {
        public Edge [] EdgeArray;
        public int AmountVert;
        public int AmountEdges;

        public Graph(int amountEdges, int amountVert)
        {
            EdgeArray = new Edge[amountEdges];
            AmountEdges = amountEdges;
            AmountVert = amountVert;
            Console.WriteLine($"Enter {amountEdges} pair of vertexes and weight of the edge between them");
            int entered = 0;
            while (entered < amountEdges)
            {
                var line = Console.ReadLine();
                if (line == null) 
                {
                    Console.WriteLine("Input error. Enter 3 integers");
                    continue;
                }
                var input = line.Split(' ');
                if (input.Length != 3)
                {
                    Console.WriteLine("Input error. Enter 3 integers");
                    continue;
                }

                int ver1, ver2, weight;
                if (int.TryParse(input[0], out int val1) && val1 < amountVert && val1 >= 0)
                {
                    ver1 = val1;
                }
                else
                {
                    Console.WriteLine("Input error. Enter 3 integers");
                    continue;
                }
                if (int.TryParse(input[1], out int val2) && val2 < amountVert && val2 >= 0)
                {
                    ver2 = val2;
                }
                else
                {
                    Console.WriteLine("Input error. Enter 3 integers");
                    continue;
                }
                if (int.TryParse(input[2], out int val3))
                {
                    weight = val3;
                }
                else
                {
                    Console.WriteLine("Input error. Enter 3 integers");
                    continue;
                }

                var edge = new Edge(ver1, ver2, weight);
                EdgeArray[entered++] = edge;
            }
            SortEdges();

        }

        private void SortEdges()
        {
            for (int i = 0; i < AmountEdges - 1; i++)
            {
                for (int j = 0; j < AmountEdges - 1 ; j++)
                {
                    if (EdgeArray[j].Weight > EdgeArray[j + 1].Weight)
                    {
                        var temp = EdgeArray[j];
                        EdgeArray[j] = EdgeArray[j + 1];
                        EdgeArray[j + 1] = EdgeArray[j];
                    }
                }    
            }

        }

        public void PrintGraph()
        {
            foreach(var el in EdgeArray)
            {
                Console.WriteLine("V1: " + el.Vertex1 + " V2: " + el.Vertex2 + " Weight: " + el.Weight);
            }
        }
        public Graph(int amountEdges, int amountVert, Edge[] edges)
        {
            AmountEdges = amountEdges;
            AmountVert = amountVert;
            EdgeArray = edges;
            SortEdges();
        }
        
        public int Kruskals()
        {
            
        }
    }
}
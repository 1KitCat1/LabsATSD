namespace Lab4Graph
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int ed = 9, vert = 7;
            var edges = new Edge[ed];
            edges[0] = new Edge(1,2,28);
            edges[1] = new Edge(1,6,28);
            edges[2] = new Edge(2,7,28);
            edges[3] = new Edge(2,3,28);
            edges[4] = new Edge(3,4,28);
            edges[5] = new Edge(4,5,28);
            edges[6] = new Edge(4,7,28);
            edges[7] = new Edge(5,6,25);
            edges[8] = new Edge(5,7,24);

            
            var graph = new Graph(ed, vert, edges);
        }
    }
}
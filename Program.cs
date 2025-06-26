// See https://aka.ms/new-console-template for more information

using Graph;
List<List<int>> edges = new List<List<int>>();
Console.Write("n = ?");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("e = ?");
int e = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < e; i++)
{
    Console.Write("node1 => ");
    int node1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("node2 => ");
    int node2 = Convert.ToInt32(Console.ReadLine());
    List<int> l=  new List<int>{node1 , node2};
    edges.Add(l);
}

AdjacencyMatrix adjacencyMatrix = new AdjacencyMatrix(n, edges);
AdjacencyList adjacencyList = new AdjacencyList(n, edges);


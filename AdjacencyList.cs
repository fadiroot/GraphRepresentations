namespace Graph;

public class AdjacencyList
{
    public int n;
    public List<List<int>> edges = new List<List<int>>();
    public Dictionary<int, List<int>> adjacencyList = new Dictionary<int, List<int>>();
    
    public AdjacencyList(int n, List<List<int>> edges)
    {
        this.n = n;
        this.edges = edges;
        for(int i = 0; i < n; i++)
        {
            adjacencyList.Add(i, new List<int>());
            
        }
        GenerateAdjencecyList(this.edges);
        Print();
    }
    private void GenerateAdjencecyList(List<List<int>> edges)
    {
        foreach (var edge in edges)
        {
            adjacencyList[edge[0]-1].Add(edge[1]);
        }
    }
    public void Print()
    {
        Console.WriteLine("Adjacency List:");
        foreach (var kvp in adjacencyList)
        {
            Console.Write($"Node {kvp.Key+1}: ");
            Console.WriteLine(string.Join(", ", kvp.Value));
        }
    }
}

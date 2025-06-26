namespace Graph;

public class AdjacencyMatrix
{
    public int n;
    public List<List<int>> edges;
    private int[,] Matrix;

    public AdjacencyMatrix(int n, List<List<int>> edges)
    {
        this.n = n;
        this.edges = edges;
        GenerateEmptyMatrix();
        GenerateMatrix();
        PrintMatrix();
    }

    private void GenerateMatrix()
    {
        foreach (var edge in edges)
        {
            int node1 = edge[0]; 
            int node2 = edge[1];
            Matrix[node1 - 1, node2 - 1] = 1;
        }
    }

    private void GenerateEmptyMatrix()
    {
        Matrix = new int[n, n];
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Matrix[row, col] = 0;
            }
        }
    }
    private void PrintMatrix()
    {
        int rows = Matrix.GetLength(0);
        int cols = Matrix.GetLength(1);

        Console.WriteLine("Adjacency Matrix:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(Matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

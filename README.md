# GraphRepresentations

A C# implementation of two fundamental graph representations:

- ✅ **Adjacency List** — Efficient for sparse graphs
- ✅ **Adjacency Matrix** — Fast for edge lookups

## 📁 Project Structure

- `AdjacencyList.cs` – Represents a graph using a dictionary of lists
- `Graph.cs` – Represents a graph using a 2D matrix

## 💡 Example Usage

```csharp
var edges = new List<List<int>>
{
    new() { 0, 1 },
    new() { 1, 2 },
    new() { 2, 0 }
};

var listGraph = new AdjacencyList(3, edges);
var matrixGraph = new Graph(3, edges);

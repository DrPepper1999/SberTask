// See https://aka.ms/new-console-template for more information

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using SberTask;


BenchmarkRunner.Run<TreeHelperBenchmarks>();

[MemoryDiagnoser]
public class TreeHelperBenchmarks
{
    private readonly Node _tree1 = CreateTree(10_000);
    private readonly Node _tree2 = CreateTree(10_000);
    
    [Benchmark]
    public void SwapBenchmark()
    {
        TreeHelper.Swap(_tree1);
    }
    
    [Benchmark]
    public void SwapRecursiveBenchmark()
    {
        TreeHelper.SwapRecursive(_tree2);
    }
    
    private static Node CreateTree(int size)
    {
        var root = new Node(1);
        var queue = new Queue<Node>();
        queue.Enqueue(root);

        var i = 2;
        while (i < size)
        {
            var node = queue.Dequeue();
            node.Left = new Node(i++);
            node.Right = new Node(i++);
            
            queue.Enqueue(node.Left);
            queue.Enqueue(node.Right);
        }

        return root;
    }
}
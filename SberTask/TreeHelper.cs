namespace SberTask;

public class Node
{
    public int Value { get; set; }

    public Node Left { get; set; }

    public Node Right { get; set; }

    public Node(int value)
    {
        Value = value;
    }

    public override string ToString() => Value.ToString();
}

/// <summary>
/// //Задача 1: В бинарном дереве поменять местами листья на всю глубину.
/// </summary>
public static class TreeHelper
{
    public static Node Swap(Node tree)
    {
        if (tree == null)
        {
            return null;
        }

        var stack = new Stack<Node>();
        stack.Push(tree);
        while (stack.Count > 0)
        {
            var node = stack.Pop();
            (node.Left, node.Right) = (node.Right, node.Left);

            if (node.Left != null)
            {
                stack.Push(node.Left);
            }

            if (node.Right != null)
            {
                stack.Push(node.Right);
            }
        }

        return tree;
    }

    public static Node SwapRecursive(Node tree)
    {
        if (tree != null)
        {
            var t = tree.Left;
            tree.Left = SwapRecursive(tree.Right);
            tree.Right = SwapRecursive(t);
        }

        return tree;
    }
}
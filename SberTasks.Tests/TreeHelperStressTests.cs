using SberTask;

namespace SberTasks.Tests;

public class TreeHelperStressTests
{
    [Test]
    public void SwapRecursive_ShouldDoesNotThrowException_WhenTreeContainsManyElements()
    {
        var root = CreateTree(100_000);

        Assert.DoesNotThrow(() =>
        {
            TreeHelper.SwapRecursive(root);
        });

    }
    
    [Test]
    public void Swap_ShouldDoesNotThrowException_WhenTreeContainsManyElements()
    {
        var root = CreateTree(100_000);
        
        // Assert
        Assert.DoesNotThrow(() =>
        {
            TreeHelper.Swap(root);
        });
    }

    private static Node CreateTree(int size)
    {
        var root = new Node(1);
        var stack = new Stack<Node>();
        stack.Push(root);

        var i = 2;
        while (i < size)
        {
            var node = stack.Pop();
            node.Left = new Node(i++);
            node.Right = new Node(i++);
            
            stack.Push(node.Left);
            stack.Push(node.Right);
        }

        return root;
    }
}
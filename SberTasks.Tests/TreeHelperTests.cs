using SberTask;

namespace SberTasks.Tests;

public class TreeHelperTests
{
    [Test]
    public void Swap_ShouldReturnNull_WhenTreeIsNull()
    {
        // Arrange
        Node tree = null;
        
        // Act
        var result = TreeHelper.Swap(tree);
        
        // Assert
        Assert.That(result, Is.Null);
    }
    
    [Test]
    public void Swap_ShouldReturnOneNode_WhenTreeContainsOneElement()
    {
        // Arrange
        var tree = new Node(0);
        
        // Act
        var result = TreeHelper.Swap(tree);
        
        // Assert
        Assert.That(result.Value, Is.EqualTo(tree.Value));
    }

    [Test] public void Swap_ShouldReturnInvertTree_WhenTreeContainsNullNode()
    {
        // Arrange
        var tree = new Node(1);
        tree.Left = new Node(2);
        tree.Right = null;
        
        // Act
        var result = TreeHelper.Swap(tree);
        
        // Assert
        Assert.That(result.Value, Is.EqualTo(1));
        Assert.That(result.Left, Is.EqualTo(null));
        Assert.That(result.Right.Value, Is.EqualTo(2));
    }
    
    [Test]
    public void Swap_ShouldReturnInvertTree_WhenTreeContainsManyElements()
    {
        // Arrange
        var tree = CreateTree();
        var originalTree = CreateTree();
        
        // Act
        var result = TreeHelper.Swap(tree);
        
        // Assert
        Assert.That(result.Value, Is.EqualTo(originalTree.Value));
        
        Assert.That(result.Right.Value, Is.EqualTo(originalTree.Left.Value));
        Assert.That(result.Left.Value, Is.EqualTo(originalTree.Right.Value));
        
        Assert.That(result.Right.Right.Value, Is.EqualTo(originalTree.Left.Left.Value));
        Assert.That(result.Right.Left.Value, Is.EqualTo(originalTree.Left.Right.Value));
        
        Assert.That(result.Right.Right.Value, Is.EqualTo(originalTree.Left.Left.Value));
        Assert.That(result.Right.Left.Value, Is.EqualTo(originalTree.Left.Right.Value));
    }

    private static Node CreateTree()
    {
        var tree = new Node(1);
        
        tree.Left = new Node(2);
        tree.Right = new Node(3);
        
        tree.Left.Left = new Node(4);
        tree.Left.Right = new Node(5);
        
        tree.Right.Left = new Node(6);
        tree.Right.Right = new Node(7);

        return tree;
    }
}
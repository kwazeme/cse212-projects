public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        // TODO Start Problem 1
        // update insert to insert unique values only (i.e. if the value is already in the tree, do not insert it again)
        if (value == Data)
        {
            // Value already exists in the tree, do not insert it again
            return;
        }

        if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value)
    {
        // TODO Start Problem 2
        // search for a value; 
        // return true if found 
        // otherwise return false
        if (value == Data)
        {
            return true;
        }
        else if (value < Data)
        {
            // Search to the left
            if (Left is null)
                return false;
            else
                return Left.Contains(value);
        }
        else
        {
            // Search to the right
            if (Right is null)
                return false;
            else
                return Right.Contains(value);
        }
    }

    public int GetHeight()
    {
        // TODO Start Problem 4
        // find the height of the longest path from this node to a leaf node
        
        int leftHeight = 0;
        int rightHeight = 0;

        if (Left != null)
        {
            leftHeight = Left.GetHeight();
        }

        if (Right != null)
        {
            rightHeight = Right.GetHeight();
        }
    // return the lenght of the longest path from this node to a leaf node plus one
    
        return 1 + Math.Max(leftHeight, rightHeight);
    }
}
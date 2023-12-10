public class Node {
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data) {
        this.Data = data;
    }

    public void Insert(int value) {
        //The value is already in the BST
        if (value == Data)
        {
            Console.WriteLine($"ERROR The BST already contains the value {value}");
        }
        else if (value < Data) {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value) {
        //the vaule is in the BST
        if (value == Data)
        {
            return true;
        }
        // Moving higher or to the right 
        else if (value > Data && Right != null)
        {
            return Right.Contains(value);
        }
        //moving lower or to the left
        else if (value < Data && Left != null)
        {
            return Left.Contains(value);
        }
        // the item is NOT in the BST
        else
        {
            return false;
        }
    }

    public int GetHeight() {
        // more options to the right 
        if (Left == null && Right != null)
        {
            return 1 + Right.GetHeight() ; 
        }
        // more options to the left 
        else if (Right == null && Left != null)
        {
            return 1 + Left.GetHeight() ;
        }
        // no other options or paths 
        else if (Right == null && Left == null)
        {
            return 1;
        }
        else
        // base case and returns the bigest height 
        {
            int leftmax = Left.GetHeight() + 1;
            int rightmax = Right.GetHeight() + 1;
            return Math.Max(leftmax,rightmax);
        }
    }

}
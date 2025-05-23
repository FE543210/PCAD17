namespace Assignments7._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BST tree = new BST();
            tree.InsertNode(tree.root, 30);
            tree.InsertNode(tree.root, 20);
            tree.InsertNode(tree.root, 45);
            tree.InsertNode(tree.root, 20);
            tree.InsertNode(tree.root, 10);
            tree.Inorder(tree.root);


            Node testOne = tree.Search(tree.root, 10);
            Console.WriteLine(tree.Search(tree.root, 9));//Returns null so ""
            Console.WriteLine(testOne.data);
            Console.ReadKey();
        }
    }
}

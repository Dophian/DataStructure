public class Program
{
    static void Main(string[] args)
    {
        // 트리 생성.
        BinarySearchTree tree = new BinarySearchTree();

        tree.Insert(10);
        tree.Insert(7);
        tree.Insert(11);
        tree.Insert(5);
        tree.Insert(5);
        tree.Insert(7);

        // 순회.
        tree.InorderTraverse();

        int findValue = 7;
        if (tree.Find(findValue))
        {
            Console.WriteLine($"값 {findValue} 검색에 성공");
        }
        else
        {
            Console.WriteLine($"값 {findValue} 검색에 실패");
        }


        Console.ReadKey();
    }
}
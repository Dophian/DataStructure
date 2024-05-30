public class Program
{
    // 재귀 함수 - 자기 자신을 호출하는 함수.
    static void RecursiveFunction(int count)
    {
        // 종료 조건 - 먼저 작성하고 시작.
        if (count == 5)
        {
            return;
        }

        Console.WriteLine($"count: {count}");

        RecursiveFunction(count + 1);
    }

    static void Main(string[] args)
    {
        RecursiveFunction(0);

        Console.ReadKey();
    }
}
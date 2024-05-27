// 진입점을 제공하는 프로그램 클래스.
// Entry Point.
class Program
{
    static void Main(string[] args)
    {
        // 경험치 삽입.
        ExpStack stack = new ExpStack();

        Console.WriteLine("첫번째 게임 종료 - 현재 경험치 145.5f");
        stack.Push(145.5f);

        Console.WriteLine("두번째 게임 종료 - 현재 경험치 183.25f");
        stack.Push(183.25f);

        Console.WriteLine("세번째 게임 종료 - 현재 경험치 162.3f");
        stack.Push(162.3f);

        // 값 추출 및 출력.
        int count = stack.Count;
        for (int ix = 0; ix < count; ++ix)
        {
            // 값 추출.
            if (stack.Pop(out float value))
            {
                Console.WriteLine($"현재 경험치: {value}");
            }
        }

        Console.ReadKey();
    }
}
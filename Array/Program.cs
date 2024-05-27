//using Array = Container.Array;

System.Array

// 진입점(Entry Point)를 갖는 프로그램 클래스.
class Program
{
    static void Main(string[] args)
    {
        // 크기가 10인 배열 객체 생성.
        Container.Array<int> array = new Container.Array<int>(10);
        //Container.Array<float> array2 = new Container.Array<float>(10);

        //int test = array[0];
        //array[1] = 10;

        // 값 설정.
        for (int ix = 0; ix < array.Length; ++ix)
        {
            //array.SetData(ix, ix + 1);
            array[ix] = ix + 1;
        }

        // 값 읽고 출력.
        for (int ix = 0; ix < array.Length; ++ix)
        {
            //Console.Write($"[{ix}] = {array.At(ix)} ");
            Console.WriteLine($"[{ix}] = {array(ix)} ");
        }

        Console.WriteLine();

        // 그냥 종료되지 말라고 추가하는 의미 없는 코드.
        Console.ReadKey();
    }
}
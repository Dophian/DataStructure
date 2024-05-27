using System;

public class Program
{
    // 대문자를 소문자로 변환하는 함수.
    static char ToLower(char uppperCase)
    {
        int width = 'a' - 'A';
        return (char)(uppperCase + width);
    }

    // 소문자를 대문자로 변환하는 함수.
    static char ToUpper(char lowerCase)
    {
        int width = 'a' - 'A';
        return (char)(lowerCase - width);
    }

    // 프로그램 메인 함수 (진입점).
    static void Main(string[] args)
    {
        // -------------------------- 소문자 -> 대문자 변환 -------------------------- //
        Console.WriteLine("소문자를 입력하세요");
        string? lowerCase = Console.ReadLine();
        while (lowerCase != null && (lowerCase[0] < 'a' || lowerCase[0] > 'z'))
        {
            Console.WriteLine("입력하신 문자는 소문자가 아닙니다. 다시 입력하세요.");
            lowerCase = Console.ReadLine();
        }

        if (lowerCase != null && lowerCase.Length > 0)
        {
            Console.WriteLine($"입력하신 문자의 대문자는 {ToUpper(lowerCase[0])} 입니다.");
        }
        // ------------------------------------------------------------------------- //

        // -------------------------- 대문자 -> 소문자 변환 -------------------------- //
        Console.WriteLine("\n대문자를 입력하세요");
        string? upperCase = Console.ReadLine();
        while (upperCase != null && (upperCase[0] < 'A' || upperCase[0] > 'Z'))
        {
            Console.WriteLine("입력하신 문자는 대문자가 아닙니다. 다시 입력하세요.");
            upperCase = Console.ReadLine();
        }

        if (upperCase != null && upperCase.Length > 0)
        {
            Console.WriteLine($"입력하신 문자의 소문자는 {ToLower(upperCase[0])} 입니다.");
        }
        // ------------------------------------------------------------------------- //

        // 바로 종료되는 것을 방지하기 위해 호출.
        Console.ReadKey();
    }
}
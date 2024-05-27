﻿using System;

public class MazeStack<T>
{
    // 필드 (필드는 감추기).
    // 현재 스택에 저장된 요소의 수.
    private int count = 0;

    // 스택에 저장할 수 있는 최대 개수.
    private const int maxCapacity = 100;

    // 스택에서 사용할 데이터 저장 공간.
    private T[] data;

    // 스택이 가득 찼는지를 알려주는 메소드/프로퍼티 (IsFull).
    // 스택에 현재 저장된 요소의 수가 스택이 저장할 수 있는 크기와 같은지를 비교.
    public bool IsFull
    {
        get
        {
            return count == maxCapacity;
        }
    }
    // 스택이 비었는지를 알려주는 메소드/프로퍼티 (IsEmpty).
    // 스택이 비었는지를 알려주는 메소드/프로퍼티 (IsEmpty).
    // count 값이 0인지 확인.
    public bool IsEmpty
    {
        get
        {
            return count == 0;
        }
    }

    // 스택에 저장된 요소의 수를 알려주는 메소드/프로퍼티 (Count).
    public int Count
    {
        get
        {
            return count;
        }
    }

    // 메시지 (공개 메소드).
    // 객체 생성.
    public MazeStack()
    {
        // 초기화 - Initialization/Initialize (Init).
        count = 0;
        data = new T[maxCapacity];
    }

    // 스택에 새로운 자료를 저장하는 메소드(Push).
    public bool Push(T item)
    {
        // 검사 - 스택이 가득차지 않았나 확인이 필요함.
        if (IsFull)
        {
            Console.WriteLine("오류: 스택이 가득찼기 때문에 데이터를 추가할 수 없습니다.");
            return false;
        }

        // 데이터 추가.
        data[count] = item;
        count++;

        // 데이터 추가 성공 반환.
        return true;
    }

    // 스택에 저장된 요소 중 가능 위에 있는 요소를 반환하는 메소드(Pop).
    public bool Pop(out T outValue)
    {
        // 검사 - 스택이 비어있지 않은지 확인이 필요함.
        if (IsEmpty)
        {
            // 오류 메시지.
            Console.WriteLine("오류: 스택이 비어있어 반환할 값이 없습니다.");

            // C#의 out 키워드로 전달된 변수는 함수에서 꼭 값을 할당해야함.
            outValue = default(T);

            // 데이터 반환 실패.
            return false;
        }

        // 반환할 데이터를 설정 후 count 감소 처리.
        count--;
        outValue = data[count];

        // 데이터 반환 처리 성공.
        return true;
    }
}
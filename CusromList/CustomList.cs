using System;
using System.Collections;

// 동적 배열을 구현하는 클래스.
// Dynamic Array.
public class CustomList<T> : IEnumerator
{
    // 내부 저장소.
    private T[] data;
    private int size = 0;           // 리스트의 크기를 추적해 저장할 변수.
    private int capacity = 2;       // 리스트가 현재의 크기에서 저장할 수 있는 실제 크기.
    
    // GetEnumerator 구현에 필요한 변수.
    private int index = 0;
    private T current;

    // 생성자.
    public CustomList() 
    {
        // 내부 저장소 초기화(생성).
        data = new T[capacity];
        size = 0;
    }

    // 인덱서.
    // 내부 저장소의 값을 읽어 반환하거나, 값을 설정할 때 사용.

    public T this[int index]
    {
        get
        {
            return data[index];
        }
        set
        {
            // 위험.
            data[index] = value;
        }
    }

    // 데이터 추가.
    public void Add(T newValue)
    {
        // 크기가 변해야하는지 확인하고, 필요하면 이사.
        if (size == capacity)
        {
            // 새로운 곳을 확보하고.
            ReAllocate(capacity * 2);
        }

        // 데이터를 저장할 지점에 새로운 값을 저장한다.
        data[size] = newValue;

        // 저장소의 크기를 하나 늘린다.
        size++;
    }
    // 데이터 저장 공간을 변경하는 메소드.
    private void ReAllocate(int newCapacity)
    {
        // 큰 저장공간 확보.
        T[] newData = new T[newCapacity];
        // 기존의 데이터를 새로운 위치로 옮기기.
        for (int ix = 0; ix < size; ++ix)
        {
            newData[ix] = data[ix];
        }
        // 내부 저장소를 새로운 위치로 옮김.
        data = newData;

        // capacity값 업데이트.
        capacity = newCapacity;
    
    }

    // 데이터 삭제1 - 삭제할 데이터 값을 전달해서 삭제.
    // 전달한 데이터의 삭제를 시도한 후 삭제의 성공 실패 여부를 반환.
    public bool Remove(T deleteValue)
    {
        // 저장된 값이 없으면, 찾을 필요도 없이 삭제 실패.
        if (size == 0)
        {
            return false;
        }

        // 검색 시작.
        int targetIndex = -1;
        for (int ix = 0;ix < size; ++ix)
        {
            // 내부 저장소에서 삭제하려는 값과 비교해 검색을 진행.
            if (data[ix].Equals(deleteValue) == true)
            {
                targetIndex = ix; 
                break;
            }
        }

        // 검색 여부를 확인하고, 찾았으면 해당 데이터 삭제.
        if (targetIndex >= 0)
        {
            // 인덱스를 기반으로 데이터 삭제.
            RemoveAt(targetIndex);
            return true;
        }

        return false;
    }

    // 데이터 삭제2 - 삭제할 위치를 인덱스로 전달해서 삭제.
    public bool RemoveAt(int index)
    {
        if (size == 0 || index < 0 || index >= size)
        {
            return false;
        }

        // 정렬.
        int listIndex = 0;
        for (int ix = 0; ix < size; ++ix)
        {
            // 삭제하려는 인덱스라면, 복사를 하지 않고 건너뜀.
            if (ix == index)
            {
                continue;
            }

            data[listIndex] = data[ix];
            listIndex++;
        }

        // 크기 조정 및 데이터 정리.
        data[size -1] = default(T);
        size--;

        return true;
    }

    // 리스트에서 다음 위치에 있는 요소가 있으면 true를 반환하고,
    // 없으면 false를 반환하면서 current 변수에 현재 위치의 요소를 설정하는 함수.
    public bool MoveNext()
    {
        if (index < size)
        {
            // 현재 위치의 요소를 할당.
            current = data[index];

            // 다음 위치를 가리키기 위해 인덱스 증가.
            index++;

            // 다음으로 이동이 가능하다고 true 반환.
            return true;
        }

        return false;
    }

    // IEnumerator 초기화.

    public void Reset()
    {
        index = 0;
        current = default(T);
    }

    // 길이 확인.
    public int Count
    {
        get
        {
            return size;
        }
    }

    public object Current  { get { return current;}}

    public IEnumerator GetEnumerator()
    {
        Reset();
        return this;
    }
}
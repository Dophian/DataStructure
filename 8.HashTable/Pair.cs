using System;

// 키-값을 쌍으로 데이터를 저장할 때 사용할 Pair 클래스.
public class Pair<TKey, TValue>
{
    // 키(Key)를 나타내는 변수.
    private TKey key;

    // 값(Value)을 나타내는 변수.
    private TValue value;

    // Getter.
    public TKey Key { get { return key; } }
    public TValue Value { get { return value; } }

    // 생성자.
    public Pair()
    {
        key = default(TKey);
        value = default(TValue);
    }

    public Pair(TKey key, TValue value)
    {
        this.key = key;
        this.value = value;
    }
}
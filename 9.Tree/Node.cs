using System;

// 트리의 구성 요소가 될 노드 클래스.
public class Node<T>
{
    // 필드.
    // 데이터를 저장하는 데이터 필드.
    public T Data { get; set; }

    // 부모 링크 필드.
    public Node<T> Parent { get; set; }

    // 자손 링크 필드.
    public List<Node<T>> Children { get; set; }

    // 메시지 (공개 메소드) - 인터페이스.

    // 생성.
    public Node(T data = default(T))
    {
        Data = data;
        Parent = null;
        Children = new List<Node<T>>();
    }

    // 자손 노드 추가.(데이터만 입력/노드를 입력).
    public void AddChild(T data)
    {
        // 아래 함수를 호출.
        AddChild(new Node<T>(data));
    }

    public void AddChild(Node<T> child)
    {
        // 추가할 자손의 부모를 나로 지정.
        child.Parent = this;
        // 자손으로 추가.
        Children.Add(child);
    }

    // 트리에서 노드 제거.
    public void Destroy()
    {
        // 부모의 자식 목록에서 나를 제거.
        if (Parent != null)
        {
            Parent.Children.Remove(this);
        }
    }
}
using System;

// 2차원 좌표를 나타내는 클래스.
public class Location2D
{
    // 행 (가로 좌표).
    public int X { get; set; }

    // 열 (세로 좌표)
    public int Y { get; set; }

    public Location2D(int row = 0, int column = 0)
    {
        X = row;
        Y = column;
    }
}

// 미로 정보를 저장하는 클래스.

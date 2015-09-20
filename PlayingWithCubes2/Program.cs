using System;

public class Cube
{
    private int Side;

    //This cube needs your help. 
    //Define a constructor which takes one integer and assignes its value to 'Side'

    public Cube()
    {
        Side = 0;
    }

    public Cube(int s)
    {
        SetSide(s);
    }

    public int GetSide() => Side;

    public void SetSide(int s) => Side = Math.Abs(s);
}
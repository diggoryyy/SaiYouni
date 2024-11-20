using UnityEngine;

public class DataStorage<T>
{
    private T data;

    public void SetData(T value)
    {
        data = value;
    }

    public T GetData()
    {
        return data;
    }
}
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager<T>
{
    private List<T> objects = new List<T>();

    public void AddObject(T obj)
    {
        objects.Add(obj);
    }

    public void RemoveObject(T obj)
    {
        objects.Remove(obj);
    }

    public void DisplayAll()
    {
        foreach (T obj in objects)
        {
            Debug.Log(obj);
        }
    }
}
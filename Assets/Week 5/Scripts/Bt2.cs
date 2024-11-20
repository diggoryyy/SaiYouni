using UnityEngine;

public static class ArrayHelper
{
    public static T FindMax<T>(T[] array) where T : System.IComparable<T>
    {
        if (array == null || array.Length == 0) return default;

        T max = array[0];
        foreach (T item in array)
        {
            if (item.CompareTo(max) > 0)
                max = item;
        }
        return max;
    }
}